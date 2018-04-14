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
    public partial class AddClientForm : Form
    {
        static User user = new User();

        public AddClientForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (fio_textBox.Text == String.Empty)
            {
                MessageBox.Show("Поле ФИО не должно быть пустым!");
            }
            else {
                Clients newClient = new Clients(fio_textBox.Text, 
                                                Convert.ToInt32(character_numericUpDown.Value), 
                                                phone_textBox.Text, social_textBox.Text, 
                                                about_textBox.Text, 
                                                Convert.ToInt32(bonus_textBox.Text),
                                                sms_checkBox.Checked);
                if (newClient.AddClient() == true) {
                    user.AddLog(String.Format("Добавил клиента <{0}> в базу КЛИЕНТОВ", newClient.Fio));
                    this.Close();
                }
            }
        }
    }
}
