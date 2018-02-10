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
    public partial class ClientsForm : Form
    {
        static User user = new User();

        public ClientsForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
            search_textBox.Focus();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.monamurDBDataSet.Clients);
            search_textBox.Focus();
            if (user.GetUserRole() != "Администратор")
            {
                dlt_button.Enabled = false;
            }
        }

        private void dlt_button_Click(object sender, EventArgs e)
        {
            if (clients_dataGridView.SelectedRows.Count != 0)
            {
                Clients dltClient = new Clients();
                dltClient.ID = Convert.ToInt32(clients_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                dltClient.Fio = clients_dataGridView.SelectedRows[0].Cells["fioDataGridViewTextBoxColumn"].Value.ToString();
                DialogResult dialog = MessageBox.Show(String.Format("Вы действительно хотите удалить клиента <{0}> из базы КЛИЕНТОВ?", dltClient.Fio),
                                                      "ВНИМАНИЕ",
                                                      MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes) {
                    if (dltClient.Delete() == true)
                    {
                        user.AddLog(String.Format("Удалил клиента <{0}> из базы КЛИЕНТОВ", dltClient.Fio));
                        clients_dataGridView.Rows.Remove(clients_dataGridView.SelectedRows[0]);
                    }
                    else {
                        MessageBox.Show(String.Format("У клиента <{0}> имеются питомцы в базе ПИТОМЦЕВ. Вначале необходимо удалить всех питомцев клиента <{0}>", dltClient.Fio));
                    }
                    
                    
                } 
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddClientForm ACF = new AddClientForm(user);
            ACF.ShowDialog();
            this.clientsTableAdapter.Fill(this.monamurDBDataSet.Clients);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            Clients client = new Clients(clients_dataGridView.SelectedRows[0].Cells["fioDataGridViewTextBoxColumn"].Value.ToString(),
                                         Convert.ToInt32(clients_dataGridView.SelectedRows[0].Cells["characterDataGridViewTextBoxColumn"].Value),
                                         clients_dataGridView.SelectedRows[0].Cells["phoneDataGridViewTextBoxColumn"].Value.ToString(),
                                         clients_dataGridView.SelectedRows[0].Cells["socialDataGridViewTextBoxColumn"].Value.ToString(),
                                         clients_dataGridView.SelectedRows[0].Cells["aboutDataGridViewTextBoxColumn"].Value.ToString(),
                                         Convert.ToInt32(clients_dataGridView.SelectedRows[0].Cells["bonusDataGridViewTextBoxColumn"].Value));
            client.ID = Convert.ToInt32(clients_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
            EditClientForm ECF = new EditClientForm(client, user, false, false);
            ECF.ShowDialog();
            this.clientsTableAdapter.Fill(this.monamurDBDataSet.Clients);
        }

        private void clients_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            edit_button_Click(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("fio like '%{0}%'", textTofind);
            clientsBindingSource.Filter = filter;
        }

        private void cleartFilter_button_Click(object sender, EventArgs e)
        {
            phone_textBox.Clear();
            mark_checkBox.Checked = false;
            markStart_numericUpDown.Value = 1;
            markStart_numericUpDown.Enabled = false;
            markEnd_numericUpDown.Value = 5;
            markEnd_numericUpDown.Enabled = false;
            bonus_checkBox.Checked = false;
            bonusStart_textBox.Text = "0";
            bonusStart_textBox.Enabled = false;
            bonusEnd_textBox.Text = "0";
            bonusEnd_textBox.Enabled = false;
            clientsBindingSource.Filter = "";
            this.clientsTableAdapter.Fill(this.monamurDBDataSet.Clients);
        }

        private void mark_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mark_checkBox.Checked)
            {
                markStart_numericUpDown.Enabled = true;
                markEnd_numericUpDown.Enabled = true;
            }
            else {
                markStart_numericUpDown.Value = 1;
                markStart_numericUpDown.Enabled = false;
                markEnd_numericUpDown.Value = 5;
                markEnd_numericUpDown.Enabled = false;
            }
        }

        private void bonus_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bonus_checkBox.Checked)
            {
                bonusStart_textBox.Enabled = true;
                bonusEnd_textBox.Enabled = true;
            }
            else {
                bonusStart_textBox.Text = "0";
                bonusStart_textBox.Enabled = false;
                bonusEnd_textBox.Text = "0";
                bonusEnd_textBox.Enabled = false;
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            if ((mark_checkBox.Checked == true) && (Convert.ToInt32(markStart_numericUpDown.Value) > Convert.ToInt32(markEnd_numericUpDown.Value)))
            {
                MessageBox.Show("Не может начальная оценка быть больше конечной");
            }
            else if ((bonus_checkBox.Checked == true) && (Convert.ToInt32(bonusStart_textBox.Text) > Convert.ToInt32(bonusEnd_textBox.Text)))
            {
                MessageBox.Show("Не может начальный диапазон бонусов быть больше конечного диапазона");
            }
            else {
                if ((mark_checkBox.Checked == true) && (bonus_checkBox.Checked == true))
                {
                    this.clientsTableAdapter.FillByCharacterAndBonus(this.monamurDBDataSet.Clients, Convert.ToInt32(markStart_numericUpDown.Value)
                                                                                                  , Convert.ToInt32(markEnd_numericUpDown.Value)
                                                                                                  , Convert.ToInt32(bonusStart_textBox.Text)
                                                                                                  , Convert.ToInt32(bonusEnd_textBox.Text));
                }
                else if ((mark_checkBox.Checked == true) && (bonus_checkBox.Checked == false))
                {
                    this.clientsTableAdapter.FillByCharacterAndBonus(this.monamurDBDataSet.Clients, Convert.ToInt32(markStart_numericUpDown.Value)
                                                                                                  , Convert.ToInt32(markEnd_numericUpDown.Value)
                                                                                                  , 0
                                                                                                  , 1000000);
                }
                else if ((mark_checkBox.Checked == false) && (bonus_checkBox.Checked == true))
                {
                    this.clientsTableAdapter.FillByCharacterAndBonus(this.monamurDBDataSet.Clients, 1
                                                                                                  , 5
                                                                                                  , Convert.ToInt32(bonusStart_textBox.Text)
                                                                                                  , Convert.ToInt32(bonusEnd_textBox.Text));
                }
                else {

                }
            }

            if (phone_textBox.Text != String.Empty) {
                string textTofind = phone_textBox.Text;
                string filter = String.Format("phone like '%{0}%'", textTofind);
                clientsBindingSource.Filter = filter;
            }
        }
    }
}
