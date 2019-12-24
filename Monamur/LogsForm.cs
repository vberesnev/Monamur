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
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_users". При необходимости она может быть перемещена или удалена.
            this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
            //GetLogsByDate(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString()));
            GetLogsByDate(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"), Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
        }

        private void GetLogsByDate(DateTime date1, DateTime date2)
        {
            this.v_logsTableAdapter.FillByDate(this.monamurDBDataSet.V_logs, date1, date2);
        }

        private void GetLogsByDateAndLogin(DateTime date1, DateTime date2, string login)
        {
            this.v_logsTableAdapter.FillByDateAndLogin(this.monamurDBDataSet.V_logs, date1, date2, login);
        }

        private void GetLogsByText(string text)
        {
            this.v_logsTableAdapter.FillByText(this.monamurDBDataSet.V_logs, text);
        }


        private void dayMinus_button_Click(object sender, EventArgs e)
        {
            logs_dateTimePicker.Value =  logs_dateTimePicker.Value.AddDays(-1);
            if (filterByLogin_checkBox.Checked == true)
            {
                GetLogsByDateAndLogin(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                                     Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"),
                                     login_comboBox.SelectedValue.ToString());
            }
            else
            {
                GetLogsByDate(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"), 
                              Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
            }
        }

        private void dayPlus_button_Click(object sender, EventArgs e)
        {
            logs_dateTimePicker.Value = logs_dateTimePicker.Value.AddDays(1);
            if (filterByLogin_checkBox.Checked == true)
            {
                GetLogsByDateAndLogin(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                                     Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"),
                                     login_comboBox.SelectedValue.ToString());
            }
            else {
                GetLogsByDate(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"), 
                              Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
            }
        }

        private void filter_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterByLogin_checkBox.Checked == true)
            {
                login_comboBox.Enabled = true;
                GetLogsByDateAndLogin(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"), 
                                      Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"),
                                      login_comboBox.SelectedValue.ToString());
            }
            else {
                login_comboBox.Enabled = false;
                GetLogsByDate(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"), 
                              Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
            }
        }

        private void login_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetLogsByDateAndLogin(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                                      Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"),
                                      login_comboBox.SelectedValue.ToString());
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logs_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (filterByLogin_checkBox.Checked == true)
            {
                GetLogsByDateAndLogin(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                                     Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"),
                                     login_comboBox.SelectedValue.ToString());
            }
            else
            {
                GetLogsByDate(Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 0:00:00"),
                              Convert.ToDateTime(logs_dateTimePicker.Value.Date.ToShortDateString() + " 23:59:59"));
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            GetLogsByText("%" + search_textBox.Text + "%");
        }
    }
}
