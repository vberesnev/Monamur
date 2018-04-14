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
    


    public partial class PetsForm : Form
    {
        class Month
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }


        static User user = new User();

        public PetsForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        List<Month> months1 = new List<Month>
        {
            new Month { Id=1, Name="января"},
            new Month { Id=2, Name="февраля"},
            new Month { Id=3, Name="марта"},
            new Month { Id=4, Name="апреля"},
            new Month { Id=5, Name="мая"},
            new Month { Id=6, Name="июня"},
            new Month { Id=7, Name="июля"},
            new Month { Id=8, Name="августа"},
            new Month { Id=9, Name="сентября"},
            new Month { Id=10, Name="октября"},
            new Month { Id=11, Name="ноября"},
            new Month { Id=12, Name="декабря"}
        };

        List<Month> months2 = new List<Month>
        {
            new Month { Id=1, Name="января"},
            new Month { Id=2, Name="февраля"},
            new Month { Id=3, Name="марта"},
            new Month { Id=4, Name="апреля"},
            new Month { Id=5, Name="мая"},
            new Month { Id=6, Name="июня"},
            new Month { Id=7, Name="июля"},
            new Month { Id=8, Name="августа"},
            new Month { Id=9, Name="сентября"},
            new Month { Id=10, Name="октября"},
            new Month { Id=11, Name="ноября"},
            new Month { Id=12, Name="декабря"}
        };


        private void PetsForm_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_pets". При необходимости она может быть перемещена или удалена.
            this.v_petsTableAdapter.Fill(this.monamurDBDataSet.V_pets);
            search_textBox.Focus();
            month1_comboBox.DataSource = months1;
            month1_comboBox.DisplayMember = "Name";
            month1_comboBox.ValueMember = "Id";

            month2_comboBox.DataSource = months2;
            month2_comboBox.DisplayMember = "Name";
            month2_comboBox.ValueMember = "Id";

            if (user.GetUserRole() != "Администратор")
            {
                dlt_button.Enabled = false;
            }
            



        }

        private void dlt_button_Click(object sender, EventArgs e)
        {
            if (pets_dataGridView.SelectedRows.Count != 0)
            {
                Pets  dltPet = new Pets();
                dltPet.ID = Convert.ToInt32(pets_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                dltPet.Name = pets_dataGridView.SelectedRows[0].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                DialogResult dialog = MessageBox.Show(String.Format("Вы действительно хотите удалить питомца <{0}> из базы ПИТОМЦЕВ?", dltPet.Name),
                                                      "ВНИМАНИЕ",
                                                      MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (dltPet.Delete() == true)
                    {
                        user.AddLog(String.Format("Удалил питомца <{0}> из базы ПИТОМЦЕВ", dltPet.Name));
                        pets_dataGridView.Rows.Remove(pets_dataGridView.SelectedRows[0]);
                        this.v_petsTableAdapter.Fill(this.monamurDBDataSet.V_pets);
                    }
                    else {
                        MessageBox.Show(String.Format("Питомцу <{0}> были оказаны процедуры. Удалите посещение питомца <{0}>", dltPet.Name));
                    }
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddPetForm APF = new AddPetForm(user);
            APF.ShowDialog();
            this.v_petsTableAdapter.Fill(this.monamurDBDataSet.V_pets);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (pets_dataGridView.SelectedRows.Count != 0) {
                Pets editPet = new Pets();
                editPet.ID = Convert.ToInt32(pets_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
                //editPet.GetInfo();
               
                EditPetForm EPF = new EditPetForm(editPet, user, false, false);
                EPF.ShowDialog();
                this.v_petsTableAdapter.Fill(this.monamurDBDataSet.V_pets);
                SelectRow(editPet.ID);
                
            }
        }

      

        private void pets_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            edit_button_Click(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("name like '%{0}%'", textTofind);
            vpetsBindingSource.Filter = filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectBreedForm SBF = new SelectBreedForm(Convert.ToInt32(animal_comboBox.SelectedValue), user, false, false, true);
            SBF.Owner = this;
            SBF.ShowDialog();
        }

        public void SetFilterBreed(int breedId, string breed) {
            breedID_textBox.Text = breedId.ToString();
            breed_textBox.Text = breed;
        }

        private void byAnimal_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (byAnimal_checkBox.Checked)
            {
                byAnimal_panel.Enabled = true;
            }
            else {
                animal_comboBox.SelectedValue = 1; 
                breedID_textBox.Text = "0";
                breed_textBox.Clear();
                byAnimal_panel.Enabled = false;
            }
        }

        private void cleartFilter_button_Click(object sender, EventArgs e)
        {
            all_radioButton.Checked = true;
            byAnimal_checkBox.Checked = false;
            client_textBox.Clear();
            vpetsBindingSource.Filter = "";

        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            string byActiv = "";
            if (activ_radioButton.Checked)
            {
                byActiv = "  alive = true ";
            }
            else if (notActiv_radioButton.Checked)
            {
                byActiv = "  alive = false ";
            }
            else byActiv = " (alive = true OR alive = false) ";

            string byBreed = "";
            if (byAnimal_checkBox.Checked)
            {
                if (Convert.ToInt32(breedID_textBox.Text) == 0)
                {
                    int animalID = Convert.ToInt32(animal_comboBox.SelectedValue);
                    string breedsList = "";
                    this.breedsTableAdapter.FillByAnimalID(this.monamurDBDataSet.Breeds, animalID);
                    foreach (DataRow row in this.monamurDBDataSet.Breeds.Rows) {
                        breedsList += row["id"].ToString() + ", ";
                    }
                    if (breedsList.Length == 0) {
                        byBreed = " AND breed_id = 0";
                    }
                    else
                    {
                        breedsList = breedsList.Remove(breedsList.LastIndexOf(","));
                        byBreed = " AND breed_id IN (" + breedsList + ")";
                    }
                    
                }
                else {
                    int breedID = Convert.ToInt32(breedID_textBox.Text);
                    byBreed = " AND breed_id = " + breedID + " ";
                }
            }
            else {
                byBreed = "";
            }

            string byClient = "";
            if (client_textBox.Text != String.Empty) {
                string clientName = client_textBox.Text;
                byClient = " AND fio LIKE '%" + clientName + "%' ";
            }

            string filter = byActiv + byBreed + byClient;
            vpetsBindingSource.Filter = filter;

        }

        private void bday_button_Click(object sender, EventArgs e)
        {
            DateTime date1;
            DateTime date2;

            if (month_radioButton.Checked)
            {
                DateTime now = DateTime.Now;
                date1 = new DateTime(1950, now.Month, 1);
                date2 = new DateTime(1950, now.Month + 1, 1).AddDays(-1);
            }
            else {
                date1 = new DateTime(1950, Convert.ToInt32(month1_comboBox.SelectedValue), Convert.ToInt32(day1_comboBox.Text));
                date2 = new DateTime(1950, Convert.ToInt32(month2_comboBox.SelectedValue), Convert.ToInt32(day2_comboBox.Text));
            }
            this.v_petsTableAdapter.FillByBD(this.monamurDBDataSet.V_pets, date1.ToString(), date2.ToString());





        }

        private void month_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void between_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (between_radioButton.Checked)
            {
                dates_panel.Enabled = true;
            }
            else {
                day1_comboBox.Text= "1";
                day2_comboBox.Text = "1";
                month1_comboBox.SelectedValue = 1;
                month2_comboBox.SelectedValue = 1;
                dates_panel.Enabled = false;
            }
        }

        private void cancelBDay_button_Click(object sender, EventArgs e)
        {
            month_radioButton.Checked = true;
            between_radioButton.Checked = false;
            vpetsBindingSource.Filter = "";
            this.v_petsTableAdapter.Fill(this.monamurDBDataSet.V_pets);
        }

        public void SelectRow(int id)
        {
            vpetsBindingSource.Position = vpetsBindingSource.Find("id", id.ToString());
        }
    }
}
