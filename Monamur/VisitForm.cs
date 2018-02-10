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
    public partial class VisitForm : Form
    {
        static User user = new User();

        public VisitForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_users". При необходимости она может быть перемещена или удалена.
            this.v_usersTableAdapter.FillByMaster(this.monamurDBDataSet.V_users);
            GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                              Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
            if (user.GetUserRole() != "Администратор") {
                deleteVisit_button.Enabled = false;
            }
        }

        private void GetVisitsByDate(DateTime date1, DateTime date2)
        {
            this.v_visitesTableAdapter.FillByDate(this.monamurDBDataSet.V_visites, date1.ToString(), date2.ToString());
            sum_textBox.Text = GetSum().ToString();
        }

        private void GetVisitsByMaster(DateTime date1, DateTime date2, int masterId) {
            this.v_visitesTableAdapter.FillByUserID(this.monamurDBDataSet.V_visites, date1.ToString(), date2.ToString(), masterId);
        }


        private void dayPlus_button_Click(object sender, EventArgs e)
        {
            visits_dateTimePicker.Value = visits_dateTimePicker.Value.AddDays(1);
            GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                             Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
        }

        private void dayMinus_button_Click(object sender, EventArgs e)
        {
            visits_dateTimePicker.Value = visits_dateTimePicker.Value.AddDays(-1);
            GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                             Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
        }

        private void visits_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                             Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
        }

        private void addVisit_button_Click(object sender, EventArgs e)
        {
            AddVisitForm AVF = new AddVisitForm(user);
            AVF.ShowDialog();
            GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                             Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
        }

        private void deleteVisit_button_Click(object sender, EventArgs e)
        {
            if (visitList_dataGridView.SelectedRows.Count > 0)
            {
                VisitProcedure dltVisitProcedure = new VisitProcedure();
                dltVisitProcedure.VisitID = Convert.ToInt32(visitList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                Visit dltVisit = new Visit();
                dltVisit.ID = Convert.ToInt32(visitList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                dltVisit.GetInfo();
                DialogResult dialog = MessageBox.Show(String.Format("Вы действительно хотите удалить посещение питомца <{0}> клиента <{1}>?", dltVisit.PetName, dltVisit.ClientName),
                                                     "ВНИМАНИЕ",
                                                     MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes) {
                    if (dltVisitProcedure.DeletetVisitProcedure() == true)
                    {
                        if (dltVisit.DeleteVisit() == true)
                        {
                            user.AddLog(String.Format("Удалил ПОСЕЩЕНИЕ питомца <{0}>, клиент <{1}>, дата и время: {2} {3}:{4} из базы ПОСЕЩЕНИЙ",
                            dltVisit.PetName, dltVisit.ClientName, dltVisit.Date.ToShortDateString(), dltVisit.TimeBegin.Hours, dltVisit.TimeBegin.Minutes));
                            visitList_dataGridView.Rows.Remove(visitList_dataGridView.SelectedRows[0]);
                        }
                        else
                        {
                            MessageBox.Show(String.Format("Не удалось удалить посещение питомца <{0}>", dltVisit.PetName));
                        }
                    }
                    else {
                        MessageBox.Show(String.Format("Не удалось удалить посещение питомца <{0}>", dltVisit.PetName));
                    }
                }  
            }
            else {
                MessageBox.Show("Необходимо выбрать хотя бы одно посещение");
            }
        }

        private void editVisit_button_Click(object sender, EventArgs e)
        {
            if ((user.GetUserRole() != "Администратор") && ((bool)visitList_dataGridView.SelectedRows[0].Cells["status"].Value == true))
            {
                MessageBox.Show("Запрещено редактировать посещение со статусом ИСПОЛНЕНО");
            }
            else {
                if (visitList_dataGridView.SelectedRows.Count > 0)
                {
                    Visit editVisit = new Visit();
                    editVisit.ID = Convert.ToInt32(visitList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                    editVisit.GetInfo();
                    EditVisitForm EVF = new EditVisitForm(user, editVisit);
                    EVF.ShowDialog();
                    GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                                 Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
                }
            }
        }

        private void visitList_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editVisit_button_Click(sender, null);
        }

        private void master_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (master_checkBox.Checked)
            {
                master_comboBox.Enabled = true;
            }
            else {
                master_comboBox.Enabled = false;
            }
        }

        private void cleartFilter_button_Click(object sender, EventArgs e)
        {
            begin_dateTimePicker.Value = DateTime.Now;
            end_dateTimePicker.Value = DateTime.Now;
            petName_textBox.Clear();
            master_checkBox.Checked = false;
            master_comboBox.Enabled = false;
            payment_comboBox.Text = "ЛЮБАЯ";
            status_comboBox.Text = "ВСЕ";
            vvisitesBindingSource.Filter = "";
            GetVisitsByDate(Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                              Convert.ToDateTime(visits_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            if (begin_dateTimePicker.Value.Date > end_dateTimePicker.Value.Date)
            {
                MessageBox.Show("Начальная дата не может быть больше конечной");
            }
            else {
                GetVisitsByDate(Convert.ToDateTime(begin_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                                 Convert.ToDateTime(end_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
                string master = "";
                if (master_checkBox.Checked)
                {
                    master = " login = '" + master_comboBox.Text + "' ";
                }
                else {
                    master = " login LIKE '%' ";
                }

                string client = "";
                if (petName_textBox.Text != String.Empty)
                {
                    client = " AND name LIKE '%" + petName_textBox.Text + "%'";
                }

                string payment;
                if (payment_comboBox.Text == "КАРТОЙ")
                {
                    payment = " AND payment = 'КАРТОЙ'";
                }
                else if (payment_comboBox.Text == "НАЛИЧНЫЙ РАСЧЕТ")
                {
                    payment = " AND payment = 'НАЛИЧНЫЙ РАСЧЕТ'";
                }
                else {
                    payment = "";
                }

                string status;
                if (status_comboBox.Text == "ИСПОЛНЕНО")
                {
                    status = " AND status = true ";
                }
                else if (status_comboBox.Text == "НЕ ИСПОЛНЕНО")
                {
                    status = " AND status = false ";
                }
                else
                {
                    status = "";
                }

                vvisitesBindingSource.Filter =  master + client + payment + status;
                sum_textBox.Text = GetSum().ToString();
            }
        }

        private int GetSum() {
            int sum = 0;
            foreach (DataGridViewRow row in visitList_dataGridView.Rows) {
                sum += Convert.ToInt32(row.Cells["sumDataGridViewTextBoxColumn"].Value);
            }
            return sum;
        }
    }
}
