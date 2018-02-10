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
    public partial class EditPetForm : Form
    {
        static Pets pet = new Pets();
        static Pets oldPet;
        static User user = new User();
        static bool addVisit = false;
        static bool editVisit = false;


        public EditPetForm(Pets petObj, User userObj, bool isAddVisit, bool isEditVisit)
        {
            InitializeComponent();

            pet = petObj;
            user = userObj;
            addVisit = isAddVisit;
            editVisit = isEditVisit;

            pet.GetInfo();

            name_textBox.Text = pet.Name;
            client_textBox.Text = pet.ClientName;
            breed_textBox.Text = pet.Breed;
            bday_dateTimePicker.Value = pet.Bday;
            age_textBox.Text = pet.Age.ToString();
            about_textBox.Text = pet.About;
            if (pet.ALive == true) {
                alive_checkBox.Checked = true;
            }
            else alive_checkBox.Checked = false;
            oldPet = (Pets)pet.Clone();

        }

        private void selectClient_button_Click(object sender, EventArgs e)
        {
            SelectClientForm SCF = new SelectClientForm(user, false);
            SCF.Owner = this;
            SCF.ShowDialog();
            client_textBox.Text = pet.ClientName;
        }

        public void SetClient(int clientId, string clientFio)
        {
            pet.ClientId = clientId;
            pet.ClientName = clientFio;
        }

        public void SetBreed(int breedId, string breed)
        {
            pet.BreedId = breedId;
            pet.Breed = breed;
        }

        private void bday_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int age = 0;
            age = DateTime.Now.Year - bday_dateTimePicker.Value.Year;
            if (DateTime.Now.Month < bday_dateTimePicker.Value.Month ||
                 (DateTime.Now.Month == bday_dateTimePicker.Value.Month && DateTime.Now.Day < bday_dateTimePicker.Value.Day)) age--;
            age_textBox.Text = age.ToString();
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
                    pet.Age = Convert.ToInt32(age_textBox.Text);
                }
                else
                {
                    pet.Age = Convert.ToInt32(age_textBox.Text);
                    pet.Bday = new DateTime(DateTime.Now.Year - pet.Age, DateTime.Now.Month, 1);
                }
                pet.About = about_textBox.Text;
                if (alive_checkBox.Checked)
                {
                    pet.ALive = true;
                }
                else pet.ALive = false;
                if (pet.UpdatePet() == true)
                {
                    user.AddLog(String.Format("Изменил параметры ПИТОМЦА Кличка: <{0}> -> <{1}>, " +
                                              "Хозяин: <{2}> -> <{3}>, Порода: <{4}> -> <{5}>, " +
                                              "Дата рождения: <{6}> -> <{7}>, Инфо: <{8}> -> <{9}>," +
                                              "Жив: <{10}> -> <{11}> в базе ПИТОМЦЕВ", oldPet.Name, pet.Name,
                                              oldPet.ClientName, pet.ClientName, oldPet.Breed, pet.Breed,
                                              oldPet.Bday, pet.Bday, oldPet.About, pet.About,
                                              oldPet.ALive, pet.ALive));
                   
                    if (addVisit)
                    {
                        AddVisitForm AVF = this.Owner as AddVisitForm;
                        AVF.SetPet(pet);
                        Clients client = new Clients();
                        client.ID = pet.ClientId;
                        client.GetInfo();
                        AVF.SetClient(client);
                       
                    }
                    if (editVisit) {
                        EditVisitForm EVF = this.Owner as EditVisitForm;
                        EVF.SetPet(pet);
                        Clients client = new Clients();
                        client.ID = pet.ClientId;
                        client.GetInfo();
                        EVF.SetClient(client);
                        
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения");
                }
                this.Close();
            }
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
                bday_dateTimePicker.Value = pet.Bday;
            }
            else
            {
                //bday_dateTimePicker.Value = DateTime.Now;
                bday_dateTimePicker.Enabled = false;
            }
        }

        private void age_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (age_radioButton.Checked)
            {
                age_textBox.ReadOnly = false;
                
                age_textBox.Focus();
            }
            else
            {
                age_textBox.Text = pet.Age.ToString();
                age_textBox.ReadOnly = true;
            }
        }

        private void selectBreed_button_Click(object sender, EventArgs e)
        {
            SelectBreedForm SBF = new SelectBreedForm(Convert.ToInt32(animal_comboBox.SelectedValue), user, false, true, false);
            SBF.Owner = this;
            SBF.ShowDialog();
            breed_textBox.Text = pet.Breed;
        }

        private void toClient_button_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.ID = pet.ClientId;
            pet.GetClient(client);
            EditClientForm ECF = new EditClientForm(client, user, false, false);
            ECF.ShowDialog();
        }

        private void EditPetForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Animals". При необходимости она может быть перемещена или удалена.
            this.animalsTableAdapter.Fill(this.monamurDBDataSet.Animals);
            animal_comboBox.SelectedValue = pet.Animal;
            breed_textBox.Text = pet.Breed;

        }

        private void animal_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            breed_textBox.Clear();
        }

        private void proced_button_Click(object sender, EventArgs e)
        {
            PetsAllProceduresForm PAPF = new PetsAllProceduresForm(pet);
            PAPF.ShowDialog();
        }
    }
}
