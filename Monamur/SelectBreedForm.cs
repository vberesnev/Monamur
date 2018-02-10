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
    public partial class SelectBreedForm : Form
    {

        static User user = new User();
        static bool newPet; // форма нового питомец
        static bool editPet; //форма редактирования питомца
        static bool petsList; //список всех питомцев
        static int id = 0;

        public SelectBreedForm(int animalId, User userObj, bool isNewPetObj, bool isEditPetObj, bool isPetsList)
        {
            InitializeComponent();
            user = userObj;
            newPet = isNewPetObj;
            editPet = isEditPetObj;
            petsList = isPetsList;
            id = animalId;
            
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetBreedForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Breeds". При необходимости она может быть перемещена или удалена.
            this.breedsTableAdapter.FillByAnimalID(this.monamurDBDataSet.Breeds, id);
            search_textBox.Focus();
        }

       

        private void save_button_Click(object sender, EventArgs e)
        {
            int breedId = Convert.ToInt32(breed_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
            string breed = breed_dataGridView.SelectedRows[0].Cells["breedDataGridViewTextBoxColumn"].Value.ToString();
            if (newPet)
            {
                AddPetForm APF = this.Owner as AddPetForm;
                if (APF != null)
                {
                    APF.SetBreed(breedId, breed);
                }
                this.Close();
            }
            if (editPet) {
                EditPetForm EPF = this.Owner as EditPetForm;
                if (EPF != null)
                {
                    EPF.SetBreed(breedId, breed);
                }
                this.Close();
            }
            if (petsList) {
                PetsForm PF = this.Owner as PetsForm;
                if (PF != null)
                {
                    PF.SetFilterBreed(breedId, breed);
                }
                this.Close();
            }

        }

        private void addBreed_button_Click(object sender, EventArgs e)
        {
            BreedsForm BF = new BreedsForm(user);
            BF.ShowDialog();
            this.breedsTableAdapter.FillByAnimalID(this.monamurDBDataSet.Breeds, id);
        }

        private void breed_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            save_button_Click(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("breed like '%{0}%'", textTofind);
            breedsBindingSource.Filter = filter;
        }
    }
}
