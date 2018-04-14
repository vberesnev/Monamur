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
    public partial class EditClientForm : Form
    {
        static Clients client = new Clients();
        static User user = new User();
        static bool addVisit = false;
        static bool editVisit = false;

        public EditClientForm(Clients clientObj, User userObj, bool isAddVisit, bool isEditVisit)
        {
            InitializeComponent();
            client = clientObj;
            addVisit = isAddVisit;
            editVisit = isEditVisit;
            user = userObj;
            client.GetInfo();
            this.Text = client.Fio;
            

            fio_textBox.Text = client.Fio;
            character_numericUpDown.Value = Convert.ToDecimal(client.Character);
            phone_textBox.Text = client.Phone;
            social_textBox.Text = client.Social;
            about_textBox.Text = client.About;
            bonus_textBox.Text = client.Bonus.ToString();
            sms_checkBox.Checked = client.Sms;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (fio_textBox.Text == String.Empty)
            {
                MessageBox.Show("Введите имя клиента");
            }
            else {
                Clients oldClient = (Clients)client.Clone();
                client.Fio = fio_textBox.Text;
                client.Character = Convert.ToInt32(character_numericUpDown.Value);
                client.Phone = phone_textBox.Text;
                client.Social = social_textBox.Text;
                client.About = about_textBox.Text;
                client.Bonus = Convert.ToInt32(bonus_textBox.Text);
                client.Sms = sms_checkBox.Checked;
                if (client.UpdateClient() == true)
                {
                    user.AddLog(String.Format("Изменил параметры КЛИЕНТА ФИО: <{0}> -> <{1}>, " +
                                              "Характер: <{2}> -> <{3}>, Телефон: <{4}> -> <{5}>, " +
                                              "Соц.сети: <{6}> -> <{7}>, Инфо: <{8}> -> <{9}>," +
                                              "Бонусы: <{10}> -> <{11}>, СМС <{12}> -> <{13}> в справочнике КЛИЕНТОВ", oldClient.Fio, client.Fio,
                                              oldClient.Character, client.Character, oldClient.Phone, client.Phone,
                                              oldClient.Social, client.Social, oldClient.About, client.About,
                                              oldClient.Bonus, client.Bonus, oldClient.Sms, client.Sms));
                    if (addVisit)
                    {
                        AddVisitForm AVF = this.Owner as AddVisitForm;
                        AVF.SetClient(client);
                    }
                    if (editVisit)
                    {
                        EditVisitForm EVF = this.Owner as EditVisitForm;
                        EVF.SetClient(client);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения");
                }
                this.Close();
            }
           
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            if (user.GetUserRole() != "Администратор")
            {
                phone_textBox.Visible = false;
                social_textBox.Visible = false;
                labelPhone.Text = "Информация недоступна";
                labelSocial.Text = "Информация недоступна";
            }
        }
    }
}
