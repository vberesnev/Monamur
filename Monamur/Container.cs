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
    public partial class Container : Form
    {
        static Form AuthForm;
        static User user = new User();
        public Container(User userObject, Form startForm)
        {
            InitializeComponent();
            AuthForm = startForm;
            user = userObject;
            this.Text += " - " + user.Login;
            this.выходToolStripMenuItem.Text += " " + user.Login;
            VisitForm VF = new VisitForm(user);
            VF.MdiParent = this;
            VF.Show();
        }


        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.AddLog("Вышел из системы");
            AuthForm.Show();
        }

        private void моиПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseMdiChild();
            MyProfileForm MPF = new MyProfileForm(user, this.выходToolStripMenuItem);
            MPF.MdiParent = this;
            MPF.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            UsersListForm ULF = new UsersListForm(user, this.выходToolStripMenuItem);
            ULF.MdiParent = this;
            ULF.Show();
        }

        private void CloseMdiChild() {
            if (this.MdiChildren.Length != 0) {
                this.ActiveMdiChild.Close();
            }
        }

        private void вЫхХОДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.AddLog("Вышел из системы");
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.AddLog("Вышел из системы");
            this.Close();
        }

        private void логиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            LogsForm LF = new LogsForm();
            LF.MdiParent = this;
            LF.Show();
        }

        private void животныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalsForm AF = new AnimalsForm(user);
            AF.ShowDialog();
        }

        private void породыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BreedsForm BF = new BreedsForm(user);
            BF.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            ClientsForm CF = new ClientsForm(user);
            CF.MdiParent = this;
            CF.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AF = new AboutForm();
            AF.ShowDialog();
        }

        private void питомцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            PetsForm PF = new PetsForm(user);
            PF.MdiParent = this;
            PF.Show();
        }

        private void процедурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProceduresForm PF = new ProceduresForm(user);
            PF.ShowDialog();
        }

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiChild();
            VisitForm VF = new VisitForm(user);
            VF.MdiParent = this;
            VF.Show();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            if (user.GetUserRole() != "Администратор")
            {
                сервисToolStripMenuItem.Visible = false;
                животныеToolStripMenuItem.Visible = false;
            }

        }
    }
}
