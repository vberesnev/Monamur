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
    public partial class AddUserForm : Form
    {
        static User user = new User();

        public AddUserForm(User userObj)
        {
            InitializeComponent();
            user = userObj;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.UserRoles". При необходимости она может быть перемещена или удалена.
            this.userRolesTableAdapter.Fill(this.monamurDBDataSet.UserRoles);
            this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if ((login_textBox.Text != String.Empty) && (password_textBox.Text != String.Empty))
            {
                User newUser = new User();
           
                newUser.Login = login_textBox.Text;
                using (MD5 md5hash = MD5.Create())
                {
                    newUser.Password = GetHash(md5hash, password_textBox.Text);
                }
                if (newUser.AddUser(Convert.ToInt32(role_comboBox.SelectedValue)) == true)
                {
                    user.AddLog(String.Format("Добавил пользователя {0}", newUser.Login));
                    this.Close();
                }
                else {
                    MessageBox.Show("Пользователь с таким логином уже есть, придумайте другой логин");
                }
            }
            else {
                MessageBox.Show("Введите все данные");
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
