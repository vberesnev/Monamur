using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Monamur
{
    public partial class NewPasswordForm : Form
    {
        User editUser = new User();
        User user = new User();

        public NewPasswordForm(User editUserObj, User userObj)
        {
            InitializeComponent();
            editUser = editUserObj;
            user = userObj;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (newPassword_textBox.Text != String.Empty) {
                using (MD5 md5hash = MD5.Create()) {
                    if (editUser.ChangeUserPassword(GetHash(md5hash, newPassword_textBox.Text)) == true) {
                        user.AddLog(String.Format("Сменил пароль пользователя {0}", editUser.Login));
                        this.Close();
                    }
                } 
            }
        }

        private string GetHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
