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
    public partial class UsersListForm : Form
    {
        static User user = new User();
        static ToolStripMenuItem menuItem;

        public UsersListForm(User userObject, ToolStripMenuItem menu)
        {
            InitializeComponent();
            user = userObject;
            menuItem = menu;
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_users". При необходимости она может быть перемещена или удалена.
            this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
        }

        private void delUser_button_Click(object sender, EventArgs e)
        {
            User dltUser = new User();
            dltUser.ID = Convert.ToInt32(userList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
            dltUser.Login = userList_dataGridView.SelectedRows[0].Cells["loginDataGridViewTextBoxColumn"].Value.ToString();
            if (dltUser.ID == user.ID)
            {
                MessageBox.Show("Вы не можете удалить сами себя");
            }
            else {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить пользователя " + dltUser.Login + "?", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    user.AddLog(String.Format("Удалил пользователя {0}", dltUser.Login));
                    dltUser.DeleteUser();
                    this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
                }
            }
        }

        private void addUser_button_Click(object sender, EventArgs e)
        {
            AddUserForm AUF = new AddUserForm(user);
            Container container = this.MdiParent as Container;
            container.MakeFormHooks(AUF);
            AUF.ShowDialog();
            this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
        }

        private void editUser_button_Click(object sender, EventArgs e)
        {
            User editUser = new User(Convert.ToInt32(userList_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value),
                                    userList_dataGridView.SelectedRows[0].Cells["loginDataGridViewTextBoxColumn"].Value.ToString(),
                                    userList_dataGridView.SelectedRows[0].Cells["passwordDataGridViewTextBoxColumn"].Value.ToString(),
                                    userList_dataGridView.SelectedRows[0].Cells["roleDataGridViewTextBoxColumn"].Value.ToString());
            if (editUser.ID == user.ID)
            {
                MyProfileForm MPF = new MyProfileForm(user, menuItem);
                MPF.MdiParent = this.MdiParent;
                Container container = this.MdiParent as Container;
                container.MakeFormHooks(MPF);
                MPF.Show();
                this.Close();
            }
            else {
                EditUserForm EUF = new EditUserForm(editUser, user);
                EUF.ShowDialog();
                this.v_usersTableAdapter.Fill(this.monamurDBDataSet.V_users);
            }
        }
    }
}
