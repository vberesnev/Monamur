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
    public partial class SelectPetForm : Form
    {
        static User user = new User();
        static bool newVisit;

        public SelectPetForm(User userObj, bool isNewVisitObj)
        {
            InitializeComponent();
            user = userObj;
            newVisit = isNewVisitObj;
        }

        private void SelectPetForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_pets". При необходимости она может быть перемещена или удалена.
            this.v_petsTableAdapter.FillByAlive(this.monamurDBDataSet.V_pets);
        }

        private void addClient_button_Click(object sender, EventArgs e)
        {
            AddPetForm APF = new AddPetForm(user);
            APF.ShowDialog();
            search_textBox.Clear();
            this.v_petsTableAdapter.FillByAlive(this.monamurDBDataSet.V_pets);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Pets pet = new Pets();
            Clients client = new Clients();
            pet.ID = Convert.ToInt32(pets_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
            client.ID = Convert.ToInt32(pets_dataGridView.SelectedRows[0].Cells["clientidDataGridViewTextBoxColumn"].Value);
            pet.GetInfo();
            client.GetInfo();
            if (newVisit)
            {
                AddVisitForm AVF = this.Owner as AddVisitForm;
                if (AVF != null)
                {
                    AVF.SetPet(pet);
                    AVF.SetClient(client);
                }
            }
            else
            {
                EditVisitForm EVF = this.Owner as EditVisitForm;
                if (EVF != null)
                {
                    EVF.SetPet(pet);
                    EVF.SetClient(client);
                }
            }
            this.Close();
        }

        private void pets_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            save_button_Click(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("name like '%{0}%'", textTofind);
            vpetsBindingSource.Filter = filter;
        }
    }
}
