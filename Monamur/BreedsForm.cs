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
    public partial class BreedsForm : Form
    {
        static User user = new User();
        List<string> log = new List<string>();
        DataTable dt;
        public BreedsForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void BreedsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Breeds". При необходимости она может быть перемещена или удалена.
            this.breedsTableAdapter.Fill(this.monamurDBDataSet.Breeds);
            dt = this.monamurDBDataSet.Animals.Copy();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            DataTable changeDeleteTable = this.monamurDBDataSet.Breeds.GetChanges(DataRowState.Deleted);
            DataTable changeAddTable = this.monamurDBDataSet.Breeds.GetChanges(DataRowState.Added);
            DataTable changeEditTable = this.monamurDBDataSet.Breeds.GetChanges(DataRowState.Modified);

            if (changeDeleteTable != null)
            {
                for (int i = 0; i < changeDeleteTable.Rows.Count; i++)
                {
                    log.Add(String.Format("Удалил породу: <{0}>, животное:<{1}> из справочника ПОРОДЫ", 
                                            changeDeleteTable.Rows[i][2, DataRowVersion.Original], 
                                            GetAnimal(Convert.ToInt32(changeDeleteTable.Rows[i][1, DataRowVersion.Original]))));
                }
            }
            if (changeAddTable != null)
            {
                for (int i = 0; i < changeAddTable.Rows.Count; i++)
                {
                    log.Add(String.Format("Добавил породу: <{0}>, животное:<{1}> в справочник ПОРОДЫ", 
                                            changeAddTable.Rows[i][2],
                                            GetAnimal(Convert.ToInt32(changeAddTable.Rows[i][1]))));
                }
            }

            if (changeEditTable != null)
            {
                for (int i = 0; i < changeEditTable.Rows.Count; i++)
                {
                    log.Add(String.Format("Изменил породу: <{0}>, животное:<{1}> на породу:<{2}>, животное:<{3}> в справочнике ПОРОДЫ",
                                           changeEditTable.Rows[i][2, DataRowVersion.Original],
                                           GetAnimal(Convert.ToInt32(changeEditTable.Rows[i][1, DataRowVersion.Original])),
                                           changeEditTable.Rows[i][2],
                                           GetAnimal(Convert.ToInt32(changeEditTable.Rows[i][1]))));
                }
            }

            this.breeds_dataGridView.DataSource = this.monamurDBDataSet.Breeds;
            this.breedsTableAdapter.Update(this.monamurDBDataSet);
            this.monamurDBDataSet.Breeds.AcceptChanges();

            if (log.Count != 0)
            {
                user.AddLog(log);
            }
            this.Close();
        }

        private string GetAnimal(int id) {
            string animal = "";
            DataRow[] row = dt.Select(String.Format("id = {0}", id));
            return animal = row[0]["animal"].ToString();
        }

        private void find_toolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = find_toolStripTextBox.Text;
            string filter = String.Format("breed like '%{0}%'", textTofind);
            breedsBindingSource.Filter = filter;
        }
    }
}
