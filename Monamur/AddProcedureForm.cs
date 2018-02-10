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
    public partial class AddProcedureForm : Form
    {
        static User user = new User();
        Procedure proc = new Procedure();

        public AddProcedureForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void AddProcedureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);
        }

        private void cost_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cost_checkBox.Checked)
            {
                cost_textBox.Enabled = true;
            }
            else {
                cost_textBox.Clear();
                cost_textBox.Enabled = false;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (procedure_textBox.Text == String.Empty)
            {
                MessageBox.Show("Введите название процедуры!");
            }
            else if ((cost_checkBox.Checked == true) && cost_textBox.Text == String.Empty)
            {
                MessageBox.Show("Укажите фиксированную стоимость процедуру или отмените фиксированную стоимость");
            }
            else {
                proc.ProcedureName = procedure_textBox.Text;
                proc.AnimalID = Convert.ToInt32(animal_comboBox.SelectedValue);
                if (cost_textBox.Text != String.Empty)
                {
                    proc.Cost = Convert.ToInt32(cost_textBox.Text);
                }
                proc.Info = info_textBox.Text;
                if (proc.InsertProcedure() == true)
                {
                    user.AddLog(String.Format("Добавил ПРОЦЕДУРУ <{0}>, для животного <{1}> в справочник ПРОЦЕДУР", proc.ProcedureName, animal_comboBox.Text));
                    this.Close();
                }
                else MessageBox.Show("Ошибка сохранения");
            }
        }

    }
}
