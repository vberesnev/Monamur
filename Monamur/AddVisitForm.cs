using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monamur
{
    public partial class AddVisitForm : Form
    {
        static User user = new User();
        static Pets pet = new Pets();
        static Clients client = new Clients();
        static Visit visit = new Visit();
        static VisitProcedure visitProcedure = new VisitProcedure();

        public AddVisitForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_users". При необходимости она может быть перемещена или удалена.
            this.v_usersTableAdapter.FillByMaster(this.monamurDBDataSet.V_users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_procedures". При необходимости она может быть перемещена или удалена.
            //  this.v_proceduresTableAdapter.Fill(this.monamurDBDataSet.V_procedures);
            if (user.GetUserRole() != "Администратор")
            {
                master_comboBox.SelectedValue = user.ID;
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectPet_button_Click(object sender, EventArgs e)
        {
            SelectPetForm SPF = new SelectPetForm(user, true);
            SPF.Owner = this;
            SPF.ShowDialog();
            if (pet_textBox.Text != String.Empty) {
                GetProcedureList(pet);
            }
        }

        public void SetPet(Pets petObj)
        {
            pet = petObj;
            pet_textBox.Text = pet.Name;
            breed_textBox.Text = pet.Breed;
            petPage_button.Enabled = true;
            proc_groupBox.Enabled = true;
            
        }

        public void SetClient(Clients clientObj)
        {
            client = clientObj;
            client_textBox.Text = client.Fio;
            phone_textBox.Text = client.Phone;
            clientPage_button.Enabled = true;
        }

        public void GetProcedureList(Pets petObj) {
            this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, petObj.GetAnimal());
        }

        private void petPage_button_Click(object sender, EventArgs e)
        {
            EditPetForm EPF = new EditPetForm(pet, user, true, false);
            EPF.Owner = this;
            EPF.ShowDialog();
        }

        private void clientPage_button_Click(object sender, EventArgs e)
        {
            EditClientForm ECF = new EditClientForm(client, user, true, false);
            ECF.Owner = this;
            ECF.ShowDialog();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if ((hour_textBox.Text == String.Empty) || (min_textBox.Text == String.Empty))
            {
                MessageBox.Show("Укажите время посещения");
            }
            else if (pet_textBox.Text == String.Empty)
            {
                MessageBox.Show("Укажите питомца");
            }
            else if (visitProc_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну процедуру для питомца");
            }
            else if (sum_textBox.Text == "Ошибка") {
                MessageBox.Show("Введите стоимость процедуры цифрами");
            }
            else if (payment_comboBox.Text == "НЕ ВЫБРАНО") {
                MessageBox.Show("Укажите вид оплаты");
            }
            else
            {
                Visit visit = new Visit();
                visit.Date = Convert.ToDateTime(visitDate_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00");
                visit.TimeBegin = new TimeSpan(Convert.ToInt32(hour_textBox.Text), Convert.ToInt32(min_textBox.Text), 0);
                visit.PetID = pet.ID;
                visit.Agress = Convert.ToInt32(agress_numericUpDown.Value);
                visit.Info = info_textBox.Text;
                visit.Sum = Convert.ToInt32(sum_textBox.Text);
                visit.UserID = Convert.ToInt32(master_comboBox.SelectedValue);
                visit.Login = master_comboBox.Text;
                visit.Payment = payment_comboBox.Text;

                visit.ID = visit.InsertVisit(); // Добавляю посещение
                if (visit.ID != 0)
                {
                    string log = "";
                    foreach (DataGridViewRow row in visitProc_dataGridView.Rows)
                    {
                        visitProcedure.ProcedureName = row.Cells["proced_name"].Value.ToString();
                        visitProcedure.ProcedureID = Convert.ToInt32(row.Cells["proced_id"].Value);
                        visitProcedure.VisitID = visit.ID;
                        visitProcedure.Cost = Convert.ToInt32(row.Cells["cost"].Value);
                        if (visitProcedure.InsertVisitProcedure() == true)
                        {
                            log += String.Format(" <{0}>, цена <{1}>; ", visitProcedure.ProcedureName, visitProcedure.Cost);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить процедуру. Смотрите логи");
                            log += String.Format(" Не удалось добавить процедуру <{0}>; ", visitProcedure.ProcedureName);
                        }
                    }
                    user.AddLog(String.Format("Добавил ПОСЕЩЕНИЕ: питомец <{0}>, хозяин <{1}>, Стоимость: {2}, Оплата: {3} дата и время {4} {5}:{6}, мастер <{7}>. Список процедур: {8}", pet.Name, pet.ClientName, visit.Sum, visit.Payment, visit.Date.ToShortDateString(), visit.TimeBegin.Hours, visit.TimeBegin.Minutes, visit.Login, log));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить посещение");
                }
            }
        }

        private void addProc_button_Click(object sender, EventArgs e)
        {
            if (procList_dataGridView.SelectedRows.Count != 0)
            {
                VisitProcedure visitProc = new VisitProcedure();
                visitProc.ProcedureID = Convert.ToInt32(procList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                visitProc.GetInfoByProcId();
                AddProcedure(visitProc);
                GetSum();

            }
            else {
                MessageBox.Show("Выберете процедуру");
            }
        }

        private void AddProcedure(VisitProcedure visitProcObj) {
            int listMin = visitProc_dataGridView.Rows.Count;
            visitProc_dataGridView.Rows.Add(1);
            visitProc_dataGridView.Rows[listMin].Cells["number"].Value = listMin + 1;
            visitProc_dataGridView.Rows[listMin].Cells["proced_id"].Value = visitProcObj.ProcedureID;
            visitProc_dataGridView.Rows[listMin].Cells["proced_name"].Value = visitProcObj.ProcedureName;
            if (visitProcObj.Cost != null)
            {
                visitProc_dataGridView.Rows[listMin].Cells["Cost"].Value = visitProcObj.Cost;
            }
            else {
                visitProc_dataGridView.Rows[listMin].Cells["Cost"].Value = String.Empty;
            }
            visitProc_dataGridView.Rows[listMin].Cells["info"].Value = visitProcObj.Info;
        }

        private void GetSum() {
            if (visitProc_dataGridView.Rows.Count > 0) {
                try
                {
                    int sum = 0;
                    foreach (DataGridViewRow row in visitProc_dataGridView.Rows)
                    {
                        sum += Convert.ToInt32(row.Cells["cost"].Value);
                    }
                    sum_textBox.Text = sum.ToString();
                }
                catch {
                    MessageBox.Show("Введите стоимость процедуры цифрами");
                    sum_textBox.Text = "Ошибка";
                }
            }
        }

        private void delProc_button_Click(object sender, EventArgs e)
        {
            if (visitProc_dataGridView.Rows.Count > 0) {
                visitProc_dataGridView.Rows.Remove(visitProc_dataGridView.SelectedRows[0]);
            }
            UpdateNumbers();
            GetSum();
        }

        private void UpdateNumbers() {
            if (visitProc_dataGridView.Rows.Count > 0)
            {
                int i = 1;
                foreach (DataGridViewRow row in visitProc_dataGridView.Rows) {
                    row.Cells["number"].Value = i;
                    i++;
                }
            }
        }

        private void visitProc_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GetSum();
        }

        private void procList_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addProc_button_Click(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("procedure_name like '%{0}%'", textTofind);
            vproceduresBindingSource.Filter = filter;
        }
    }
}
