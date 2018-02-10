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
    public partial class EditUserForm : Form
    {
        static User editUser = new User();
        static User user = new User();

        public EditUserForm(User editUserObject, User userObject)
        {
            InitializeComponent();
            editUser = editUserObject;
            user = userObject;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            this.userRolesTableAdapter.Fill(this.monamurDBDataSet.UserRoles);
            login_textBox.Text = editUser.Login;
            role_comboBox.SelectedValue = editUser.GetUserRoleId();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text != String.Empty) {
                if (editUser.EditUser(login_textBox.Text, Convert.ToInt32(role_comboBox.SelectedValue)) == true)
                {
                    user.AddLog(String.Format("Отредактировал пользователя {0}", editUser.Login));
                    info_label.Text = "Данные сохранены";
                    info_label.ForeColor = System.Drawing.Color.LightGreen;
                }
                else {
                    info_label.Text = "Такой логин уже существует";
                    info_label.ForeColor = System.Drawing.Color.OrangeRed;
                }
            }
        }

        private void changePassword_button_Click(object sender, EventArgs e)
        {
            NewPasswordForm NPF = new NewPasswordForm(editUser, user);
            NPF.ShowDialog();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
