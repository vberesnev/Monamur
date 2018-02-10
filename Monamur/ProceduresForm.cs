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
    public partial class ProceduresForm : Form
    {
        static User user = new User();
        DataGridView dgw;
        public ProceduresForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void ProceduresForm_Load(object sender, EventArgs e)
        {
            if (user.GetUserRole() != "Администратор")
            {
                delete_button.Enabled = false;
                edit_button.Enabled = false;
            }
        }

        private void dogs_tabPage_Enter(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_procedures". При необходимости она может быть перемещена или удалена.
            this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 1);
            dogs_dataGridView.Columns[0].Visible = false;
        }

        private void cats_tabPage_Enter(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_procedures". При необходимости она может быть перемещена или удалена.
            this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 2);
            cats_dataGridView.Columns[0].Visible = false;
        }

        private void mouse_tabPage_Enter(object sender, EventArgs e)
        {
            this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 3);
            mouse_dataGridView.Columns[0].Visible = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
            if (procedures_tabControl.SelectedTab.Name == "dogs_tabPage") {
                dgw = dogs_dataGridView;
            }
            else if (procedures_tabControl.SelectedTab.Name == "cats_tabPage")
            {
                dgw = cats_dataGridView;
            }
            else dgw = mouse_dataGridView;

            if (dgw.SelectedRows.Count != 0)
            {
                Procedure dltProcedure = new Procedure();
                dltProcedure.ID = Convert.ToInt32(dgw.SelectedRows[0].Cells[0].Value);
                dltProcedure.ProcedureName = dgw.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show(String.Format("Вы действительно хотите удалить процедуру <{0}> из базы ПРОЦЕДУР?", dltProcedure.ProcedureName),
                                                      "ВНИМАНИЕ",
                                                      MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (dltProcedure.Delete() == true)
                    {
                        user.AddLog(String.Format("Удалил проедуру <{0}> из базы ПРОЦЕДУР", dltProcedure.ProcedureName));
                        dgw.Rows.Remove(dgw.SelectedRows[0]);
                    }
                    else {
                        MessageBox.Show(String.Format("Процедура <{0}> была оказана питомцу. Ее нельзя удалить", dltProcedure.ProcedureName));
                    }
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddProcedureForm APF = new AddProcedureForm(user);
            APF.ShowDialog();
            if (procedures_tabControl.SelectedTab.Name == "dogs_tabPage")
            {
                this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 1);
            }
            else if (procedures_tabControl.SelectedTab.Name == "cats_tabPage")
            {
                this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 2);
            }
            else this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 3);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (user.GetUserRole() != "Администратор")
            {
                MessageBox.Show("Редактирование запрещено");
            }
            else {
                if (procedures_tabControl.SelectedTab.Name == "dogs_tabPage")
                {
                    dgw = dogs_dataGridView;
                }
                else if (procedures_tabControl.SelectedTab.Name == "cats_tabPage")
                {
                    dgw = cats_dataGridView;
                }
                else dgw = mouse_dataGridView;
                if (dgw.SelectedRows.Count != 0)
                {
                    Procedure editProcedure = new Procedure();
                    editProcedure.ID = Convert.ToInt32(dgw.SelectedRows[0].Cells[0].Value);
                    editProcedure.GetInfo();

                    /*editProcedure.ProcedureName = dgw.SelectedRows[0].Cells[1].Value.ToString();
                    editProcedure.AnimalID = Convert.ToInt32(dgw.SelectedRows[0].Cells[2].Value);
                    editProcedure.Animal = dgw.SelectedRows[0].Cells[3].Value.ToString();
                    editProcedure.Cost = Convert.ToInt32(dgw.SelectedRows[0].Cells[4].Value);
                    editProcedure.Info = dgw.SelectedRows[0].Cells[5].Value.ToString();*/

                    EditProcedureForm EPF = new EditProcedureForm(editProcedure, user);
                    EPF.ShowDialog();
                    if (procedures_tabControl.SelectedTab.Name == "dogs_tabPage")
                    {
                        this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 1);
                    }
                    else if (procedures_tabControl.SelectedTab.Name == "cats_tabPage")
                    {
                        this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 2);
                    }
                    else this.v_proceduresTableAdapter.FillByAnimalId(this.monamurDBDataSet.V_procedures, 3);
                }
            }

            
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("procedure_name like '%{0}%'", textTofind);
            vproceduresBindingSource.Filter = filter;
        }

        private void dogs_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_button_Click(sender, null);
        }

        private void cats_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_button_Click(sender, null);
        }

        private void mouse_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_button_Click(sender, null);
        }
    }
}
