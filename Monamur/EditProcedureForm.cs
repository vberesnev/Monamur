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
    public partial class EditProcedureForm : Form
    {

        static User user = new User();
        static Procedure editProc = new Procedure();

        public EditProcedureForm(Procedure procedObj, User userObj)
        {
            InitializeComponent();
            user = userObj;
            editProc = procedObj;
            this.Text = editProc.ProcedureName;

            procedure_textBox.Text = editProc.ProcedureName;
            if (editProc.Cost != 0) {
                cost_checkBox.Checked = true;
                cost_textBox.Enabled = true;
                cost_textBox.Text = editProc.Cost.ToString();
            }
            info_textBox.Text = editProc.Info;
            animal_comboBox.SelectedValue = editProc.AnimalID;


        }

        private void EditProcedureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);
            animal_comboBox.SelectedValue = editProc.AnimalID;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (procedure_textBox.Text == String.Empty)
            {
                MessageBox.Show("Введите название процедуры");
            }
            else if ((cost_checkBox.Checked == true) && cost_textBox.Text == String.Empty) {
                MessageBox.Show("Укажите фиксированную стоимость процедуру или отмените фиксированную стоимость");
            }
            else
            {
                Procedure oldProc = (Procedure)editProc.Clone();
                editProc.ProcedureName = procedure_textBox.Text;
                editProc.AnimalID = Convert.ToInt32(animal_comboBox.SelectedValue);
                editProc.Animal = animal_comboBox.Text;
                if (cost_checkBox.Checked)
                {
                    editProc.Cost = Convert.ToInt32(cost_textBox.Text);
                }
                else editProc.Cost = 0;
                editProc.Info = info_textBox.Text;
                if (editProc.UpdateProcedure() == true)
                {
                    user.AddLog(String.Format("Изменил параметры ПРОЦЕДУРЫ Название процедуры: <{0}> -> <{1}>, " +
                                          "Животное: <{2}> -> <{3}>, Цена: <{4}> -> <{5}>, " +
                                          "Инфо: <{6}> -> <{7}>в справочнике ПРОЦЕДУР", oldProc.ProcedureName, editProc.ProcedureName,
                                          oldProc.Animal, editProc.Animal, oldProc.Cost, editProc.Cost,
                                          oldProc.Info, editProc.Info));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения");
                }
            }
        }

        private void cost_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cost_checkBox.Checked)
            {
                cost_textBox.Enabled = true;
            }
            else
            {
                cost_textBox.Clear();
                cost_textBox.Enabled = false;
            }
        }


        private void animal_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
