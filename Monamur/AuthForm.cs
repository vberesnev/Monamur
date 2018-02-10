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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Activated(object sender, EventArgs e)
        {
            this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            if (Auth(Convert.ToInt32(login_comboBox.SelectedValue), password_textBox.Text))
            {
                DataTable dt = this.monamurDBDataSet.V_users;
                User user = new User(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["login"].ToString(), password_textBox.Text, dt.Rows[0]["role"].ToString());
                user.AddLog("Вошел в систему");
                password_textBox.Text = String.Empty;
                Container container = new Container(user, this);
                this.Hide();
                container.Show();
            }
            else {
                password_textBox.Clear();
                MessageBox.Show("Ошибка авторизации");
                password_textBox.Focus();
            }
            
        }

        private string GetHash(MD5 md5Hash, string input) {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private bool Auth(int id, string password) {
            this.v_usersTableAdapter.FillById(this.monamurDBDataSet.V_users, id);
            if (this.monamurDBDataSet.V_users.Rows.Count == 0)
            {
                return false;
            }
            else {
                using (MD5 md5hash = MD5.Create())
                {
                    if (this.monamurDBDataSet.V_users.Rows[0]["password"].ToString() == GetHash(md5hash, password))
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
        }

        private void AuthForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                auth_button_Click(sender, null); 
            }
        }
    }
}
