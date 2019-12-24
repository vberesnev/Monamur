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
    public partial class EditVisitForm : Form
    {

        static User user = new User();
        static Pets editPet = new Pets();
        static Visit editVisit = new Visit();
        static Clients editClient = new Clients();

        string visitProcedureOLD = "";
        string petNameOLD = "";
        string clientNameOLD = "";
        
        public EditVisitForm(User userObj, Visit visitObj)
        {
            InitializeComponent();
            user = userObj;
            editVisit = visitObj;
            editPet.ID = visitObj.PetID;
            editPet.GetInfo();
            petNameOLD = editPet.Name;
            editClient.ID = editPet.ClientId;
            editClient.GetInfo();
            clientNameOLD = editClient.Fio;

            visitDate_dateTimePicker.Value = editVisit.Date;
            hour_textBox.Text = editVisit.TimeBegin.Hours.ToString();
            min_textBox.Text = editVisit.TimeBegin.Minutes.ToString();
            pet_textBox.Text = editPet.Name;
            breed_textBox.Text = editPet.Breed;
            client_textBox.Text = editClient.Fio;
            phone_textBox.Text = editClient.Phone;
            master_comboBox.SelectedValue = editVisit.UserID;
            info_textBox.Text = editVisit.Info;
            agress_numericUpDown.Value = Convert.ToDecimal(editVisit.Agress);
            GetProceduresList(editPet);
            GetVisitProcedures(editVisit.ID);
            sum_textBox.Text = editVisit.Sum.ToString();
            payment_comboBox.Text = editVisit.Payment;

            foreach (DataGridViewRow row in visitProc_dataGridView.Rows) {
                // формирую строчку для записи лога 
                visitProcedureOLD += String.Format(" <{0}>, цена {1}; ", row.Cells["proced_name"].Value, row.Cells["Cost"].Value);
            }

        }

        private void GetProceduresList(Pets petObj) {
            this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, petObj.GetAnimal());
        }

        private void GetVisitProcedures(int visitId) {
            this.v_visitProceduresTableAdapter.FillByVisitId(this.monamurDBDataSet.V_visitProcedures, visitId);
            foreach (DataRow row in this.monamurDBDataSet.V_visitProcedures.Rows) {
                VisitProcedure visitProc = new VisitProcedure();
                visitProc.ProcedureID = Convert.ToInt32(row["id_procedure"]);
                visitProc.GetInfoByProcId();
                visitProc.Cost = Convert.ToInt32(row["cost"]);
                AddProcedure(visitProc);
            }
        }

        private void GetSum()
        {
            if (visitProc_dataGridView.Rows.Count > 0)
            {
                try
                {
                    int sum = 0;
                    foreach (DataGridViewRow row in visitProc_dataGridView.Rows)
                    {
                        sum += Convert.ToInt32(row.Cells["cost"].Value);
                    }
                    sum_textBox.Text = sum.ToString();
                }
                catch
                {
                    MessageBox.Show("Введите стоимость процедуры цифрами");
                    sum_textBox.Text = "Ошибка";
                }
            }
        }

        private void AddProcedure(VisitProcedure visitProcObj)
        {
            int listMin = visitProc_dataGridView.Rows.Count;
            visitProc_dataGridView.Rows.Add(1);
            visitProc_dataGridView.Rows[listMin].Cells["number"].Value = listMin + 1;
            visitProc_dataGridView.Rows[listMin].Cells["proced_id"].Value = visitProcObj.ProcedureID;
            visitProc_dataGridView.Rows[listMin].Cells["proced_name"].Value = visitProcObj.ProcedureName;
            visitProc_dataGridView.Rows[listMin].Cells["Cost"].Value = visitProcObj.Cost;
            visitProc_dataGridView.Rows[listMin].Cells["info"].Value = visitProcObj.Info;
        }


        public void SetClient(Clients clientObj) {
            editClient = clientObj;
            client_textBox.Text = editClient.Fio;
            phone_textBox.Text = editClient.Phone;
        }

        public void SetPet(Pets petObj)
        {
            editPet = petObj;
            pet_textBox.Text = editPet.Name;
            breed_textBox.Text = editPet.Breed;
            editClient.ID = editPet.ClientId;
            editClient.GetInfo();
            client_textBox.Text = editClient.Fio;
            phone_textBox.Text = editClient.Phone;
        }

        public void GetProcedureList(Pets petObj)
        {
            this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, petObj.Animal);
            procList_dataGridView.Columns["idDataGridViewTextBoxColumn"].Visible = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delProc_button_Click(object sender, EventArgs e)
        {
            if (visitProc_dataGridView.Rows.Count > 0)
            {
                visitProc_dataGridView.Rows.Remove(visitProc_dataGridView.SelectedRows[0]);
            }
            UpdateNumbers();
            GetSum();
            if (visitProc_dataGridView.Rows.Count == 0) {
                sum_textBox.Text = "0";
            }
            
        }

        private void UpdateNumbers()
        {
            if (visitProc_dataGridView.Rows.Count > 0)
            {
                int i = 1;
                foreach (DataGridViewRow row in visitProc_dataGridView.Rows)
                {
                    row.Cells["number"].Value = i;
                    i++;
                }
            }
        }

        private void selectPet_button_Click(object sender, EventArgs e)
        {
            SelectPetForm SPF = new SelectPetForm(user, false);
            SPF.Owner = this;
            SPF.ShowDialog();
            GetProcedureList(editPet);
        }

        private void petPage_button_Click(object sender, EventArgs e)
        {
            EditPetForm EPF = new EditPetForm(editPet, user, false, true);
            EPF.Owner = this;
            EPF.ShowDialog();
        }

        private void clientPage_button_Click(object sender, EventArgs e)
        {
            EditClientForm ECF = new EditClientForm(editClient, user, false, true);
            ECF.Owner = this;
            ECF.ShowDialog();
        }

        private void addProc_button_Click_1(object sender, EventArgs e)
        {
            if (procList_dataGridView.SelectedRows.Count != 0)
            {
                VisitProcedure visitProc = new VisitProcedure();
                visitProc.ProcedureID = Convert.ToInt32(procList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                visitProc.GetInfoByProcId();
                AddProcedure(visitProc);
                GetSum();

            }
            else
            {
                MessageBox.Show("Выберете процедуру");
            }
        }

        private void save_button_Click_1(object sender, EventArgs e)
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
            else if (sum_textBox.Text == "Ошибка")
            {
                MessageBox.Show("Введите стоимость процедуры цифрами");
            }
            else
            {
                Visit oldVisit = (Visit)editVisit.Clone();
                editVisit.Date = Convert.ToDateTime(visitDate_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00");
                editVisit.TimeBegin = new TimeSpan(Convert.ToInt32(hour_textBox.Text), Convert.ToInt32(min_textBox.Text), 0);
                editVisit.Agress = Convert.ToInt32(agress_numericUpDown.Value);
                editVisit.Info = info_textBox.Text;
                editVisit.Sum = Convert.ToInt32(sum_textBox.Text);
                editVisit.UserID = Convert.ToInt32(master_comboBox.SelectedValue);
                editVisit.Login = master_comboBox.Text;
                editVisit.Payment = payment_comboBox.Text;
                if (editVisit.UpdateVisit() == true)
                {
                    //вначале удаляю все процедуры редакируемого посещения
                    VisitProcedure visitProcedure = new VisitProcedure();
                    visitProcedure.VisitID = editVisit.ID;
                    visitProcedure.DeletetVisitProcedure();

                    string log = ""; // переменная лога
                    foreach (DataGridViewRow row in visitProc_dataGridView.Rows)
                    {
                        visitProcedure.ProcedureName = row.Cells["proced_name"].Value.ToString();
                        visitProcedure.ProcedureID = Convert.ToInt32(row.Cells["proced_id"].Value);
                        visitProcedure.VisitID = editVisit.ID;
                        visitProcedure.Cost = Convert.ToInt32(row.Cells["cost"].Value);
                        if (visitProcedure.InsertVisitProcedure() == true) // заново вставляю процедуры в таблицу VisitProcedures
                        {
                            log += String.Format(" <{0}>, цена <{1}>; ", visitProcedure.ProcedureName, visitProcedure.Cost);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить процедуру. Смотрите логи");
                            log += String.Format(" Не удалось добавить процедуру <{0}>; ", visitProcedure.ProcedureName);
                        }
                    }
                    user.AddLog(String.Format("Обновил ПОСЕЩЕНИЕ: питомец <{0}> -> <{1}>, хозяин <{2}> -> <{3}>, дата и время {4} {5}:{6} -> {7} {8}:{9}, Цена {10} -> {11}, Оплата {12} -> {13}, Мастер <{14}> -> <{15}>. Процедуры: {16} -> {17}"
                        , petNameOLD, editPet.Name, clientNameOLD, editClient.Fio, oldVisit.Date.ToShortDateString(), oldVisit.TimeBegin.Hours, oldVisit.TimeBegin.Minutes, editVisit.Date.ToShortDateString(), editVisit.TimeBegin.Hours, editVisit.TimeBegin.Minutes, oldVisit.Sum, editVisit.Sum, oldVisit.Payment, editVisit.Payment,  oldVisit.Login, editVisit.Login, visitProcedureOLD, log));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось обновить инофрмацию о  посещении");
                }
            }
        }

        private void visitProc_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GetSum();
        }

        private void procList_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addProc_button_Click_1(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("procedure_name like '%{0}%'", textTofind);
            vproceduresBindingSource.Filter = filter;
        }

        private void EditVisitForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.v_usersTableAdapter.FillByMaster(this.monamurDBDataSet.V_users);
            master_comboBox.SelectedValue = editVisit.UserID;

            if (user.GetUserRole() != "Администратор")
            {
                phone_textBox.Visible = false;
                char[] charPhone = phone_textBox.Text.ToCharArray();
                for (int i = 0; i < charPhone.Length - 3; i++)
                {
                    labelPhone.Text += "* ";
                }
                for (int j = charPhone.Length - 3; j < charPhone.Length; j++)
                {
                    labelPhone.Text += charPhone[j] + " ";
                }
            }

        }

        private void status_button_Click(object sender, EventArgs e)
        {
            if (editVisit.UpdateStatus() == true)
            {
                user.AddLog(String.Format("Установил статус ИСПОЛНЕНО посещению: питомец <{0}>, хозяин <{1}>, дата и время {2} {3}:{4}", editPet.Name, editClient.Fio, editVisit.Date.ToShortDateString(), editVisit.TimeBegin.Hours, editVisit.TimeBegin.Minutes));
                this.Close();
            }
            else {
                MessageBox.Show("Невозможно обновить статус");
            }
        }
    }
}
