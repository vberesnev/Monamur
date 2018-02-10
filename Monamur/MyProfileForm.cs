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
    public partial class MyProfileForm : Form
    {
        static User user = new User();
        static ToolStripMenuItem menuItem;

        public MyProfileForm(User userObject, ToolStripMenuItem menu)
        {
            InitializeComponent();
            user = userObject;
            login_textBox.Text = user.Login;
            menuItem = menu;
            saveProfile_button.Focus();
        }

        private void saveProfile_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text != String.Empty) {
                if (user.Login == login_textBox.Text)
                {
                    infoLabel.Text = "Логин изменен";
                    infoLabel.ForeColor = System.Drawing.Color.Green;
                }
                else {
                    if (user.ChangeProfileLogin(login_textBox.Text) == true)
                    {
                        user.UpdateProfile();
                        menuItem.Text = "Выход, " + user.Login;
                        this.Parent.Text = "Monamur IS - " + user.Login;
                        infoLabel.Text = "Логин изменен";
                        infoLabel.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        infoLabel.Text = "Такой логин уже есть! Поменяйте логин";
                        infoLabel.ForeColor = System.Drawing.Color.DarkRed;
                        login_textBox.Text = user.Login;
                    }
                }
               
            }
        }

        private void changePass_button_Click(object sender, EventArgs e)
        {
            ChangePasswordForm CPF = new ChangePasswordForm(user);
            CPF.ShowDialog();
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            saveProfile_button.Focus();
        }
    }
}
