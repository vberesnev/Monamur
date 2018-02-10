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
    public partial class AnimalsForm : Form
    {
        static User user = new User();
        List<string> log = new List<string>();

        public AnimalsForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void AnimalsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);
        }

        private void save_toolStripButton_Click(object sender, EventArgs e)
        {
            DataTable changeDeleteTable = this.monamurDBDataSet.Animals.GetChanges(DataRowState.Deleted);
            DataTable changeAddTable = this.monamurDBDataSet.Animals.GetChanges(DataRowState.Added);
            DataTable changeEditTable = this.monamurDBDataSet.Animals.GetChanges(DataRowState.Modified);

            if (changeDeleteTable != null)
            {
                for (int i = 0; i < changeDeleteTable.Rows.Count; i++)
                {
                    log.Add(String.Format("Удалил <{0}> из справочника ЖИВОТНЫЕ", changeDeleteTable.Rows[i][1, DataRowVersion.Original]));
                }
            }
            if (changeAddTable != null)
            {
                for (int i = 0; i < changeAddTable.Rows.Count; i++)
                {
                    log.Add(String.Format("Добавил <{0}> в справочник ЖИВОТНЫЕ", changeAddTable.Rows[i][1]));
                }
            }

            if (changeEditTable != null)
            {
                for (int i = 0; i < changeEditTable.Rows.Count; i++)
                {
                    log.Add(String.Format("Изменил <{0}> на <{1}> из справочника ЖИВОТНЫЕ",
                                           changeEditTable.Rows[i][1, DataRowVersion.Original],
                                           changeEditTable.Rows[i][1]));
                }
            }

            animals_dataGridView.DataSource = this.monamurDBDataSet.Animals;
            animalsTableAdapter.Update(monamurDBDataSet);
            this.monamurDBDataSet.Animals.AcceptChanges();

            if (log.Count != 0)
            {
                user.AddLog(log);
            }
        }
    }
}

