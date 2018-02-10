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
    public partial class ChangePasswordForm : Form
    {
        static User user = new User();

        public ChangePasswordForm(User userObject)
        {
            InitializeComponent();
            user = userObject;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            using (MD5 md5hash = MD5.Create()) {
                if (user.ChangeProfilePassword(GetHash(md5hash, oldPassword_textBox.Text), GetHash(md5hash, newPassword_textBox.Text)) == true)
                {
                    info_label.Text = "Пароль изменен";
                    info_label.ForeColor = System.Drawing.Color.Green;
                    user.AddLog("Изменил свой пароль");
                }
                else {
                    info_label.Text = "Старый пароль неверен";
                    info_label.ForeColor = System.Drawing.Color.DarkRed;
                }
                oldPassword_textBox.Text = String.Empty;
                newPassword_textBox.Text = String.Empty;
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
