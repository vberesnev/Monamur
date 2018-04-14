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
    public partial class AddPetForm : Form
    {
        static User user = new User();
        static Pets pet = new Pets();

        public AddPetForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
            
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bday_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bday_radioButton.Checked)
            {
                bday_dateTimePicker.Enabled = true;
            }
            else {
                bday_dateTimePicker.Value = DateTime.Now;
                bday_dateTimePicker.Enabled = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == String.Empty)
            {
                MessageBox.Show("У питомца должна быть кличка");
            }
            else if (client_textBox.Text == String.Empty)
            {
                MessageBox.Show("У питомца должен быть хозяин");
            }
            else if (breed_textBox.Text == String.Empty) {
                MessageBox.Show("У питомца должна быть порода");
            }
            else
            {
                pet.Name = name_textBox.Text;
                if (bday_radioButton.Checked)
                {
                    pet.Bday = bday_dateTimePicker.Value;
                    //pet.Age = Convert.ToInt32(age_textBox.Text);
                }
                else
                {
                    //pet.Age = Convert.ToInt32(age_textBox.Text);
                    pet.Bday = DateTime.Parse("1900-01-01");
                }
                pet.About = about_textBox.Text;
                pet.AddPet();
                user.AddLog(String.Format("Добавил питомца <{0}>, хозяин <{1}> в базу ПИТОМЦЕВ", pet.Name, pet.ClientName));
                this.Close();

            }
        }

        private void bday_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void selectClient_button_Click(object sender, EventArgs e)
        {
            SelectClientForm SCF = new SelectClientForm(user, true);
            SCF.Owner = this;
            SCF.ShowDialog();
            client_textBox.Text = pet.ClientName;
        }

        public void SetClient(int clientId, string clientFio) {
            pet.ClientId = clientId;
            pet.ClientName = clientFio;
        }

        public void SetBreed(int breedId, string breed)
        {
            pet.BreedId = breedId;
            pet.Breed = breed;
        }

        private void selectBreed_button_Click(object sender, EventArgs e)
        {
            SelectBreedForm SBF = new SelectBreedForm(Convert.ToInt32(comboBox1.SelectedValue), user, true, false, false);
            SBF.Owner = this;
            SBF.ShowDialog();
            breed_textBox.Text = pet.Breed;
        }

        private void AddPetForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            breed_textBox.Clear();
        }

        private void unknownBD_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (unknownBD_radioButton.Checked)
            {
                bday_radioButton.Checked = false;
            }
        }
    }
}
