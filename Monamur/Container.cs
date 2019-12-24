using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Monamur
{
    public partial class Container : Form
    {
        private static string TIMER_PATH = Path.Combine(System.Environment.CurrentDirectory, "timer.ini");

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
            MakeFormHooks(VF);
            VF.Show();
        }


        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.AddLog("Вышел из системы");
            AuthForm.Show();
        }

        private void моиПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            CloseMdiChild();
            MyProfileForm MPF = new MyProfileForm(user, this.выходToolStripMenuItem);
            MPF.MdiParent = this;
            MakeFormHooks(MPF);
            MPF.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            CloseMdiChild();
            UsersListForm ULF = new UsersListForm(user, this.выходToolStripMenuItem);
            ULF.MdiParent = this;
            MakeFormHooks(ULF);
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
            RestartTimer();
            CloseMdiChild();
            LogsForm LF = new LogsForm();
            LF.MdiParent = this;
            MakeFormHooks(LF);
            LF.Show();
        }

        private void животныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            AnimalsForm AF = new AnimalsForm(user);
            AF.Owner = this;
            MakeFormHooks(AF);
            AF.ShowDialog();
            RestartTimer();
        }

        private void породыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            BreedsForm BF = new BreedsForm(user);
            BF.Owner = this;
            MakeFormHooks(BF);
            BF.ShowDialog();
            RestartTimer();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RestartTimer();
            CloseMdiChild();
            ClientsForm CF = new ClientsForm(user);
            CF.MdiParent = this;
            MakeFormHooks(CF);
            CF.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            AboutForm AF = new AboutForm();
            MakeFormHooks(AF);
            AF.ShowDialog();
            RestartTimer();
        }

        private void питомцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            CloseMdiChild();
            PetsForm PF = new PetsForm(user);
            PF.MdiParent = this;
            MakeFormHooks(PF);
            PF.Show();
        }

        private void процедурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            ProceduresForm PF = new ProceduresForm(user);
            PF.Owner = this;
            MakeFormHooks(PF);
            PF.ShowDialog();
            RestartTimer();
        }

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartTimer();
            CloseMdiChild();
            VisitForm VF = new VisitForm(user);
            VF.MdiParent = this;
            MakeFormHooks(VF);
            VF.Show();
        }

        Timer timer = new Timer();

        private void Container_Load(object sender, EventArgs e)
        {
            if (user.GetUserRole() != "Администратор")
            {
                сервисToolStripMenuItem.Visible = false;
                животныеToolStripMenuItem.Visible = false;
            }
            try
            {
                timer.Interval = Convert.ToInt32(File.ReadAllText(TIMER_PATH)) * 1000;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка считывания таймера {ex.Message}, таймер выставлен на 3 минуты");
                timer.Interval = 180000;
            }
            timer.Tick += Timer_Tick;
            timer.Start();
            this.MouseClick += UserActsHint;
            this.MouseDoubleClick += UserActsHint;
            this.KeyPress += UserActsHint;
        }

        public void MakeFormHooks(Form form)
        {
            form.MouseClick += UserActsHint;
            form.MouseDoubleClick += UserActsHint;
            form.KeyPress += UserActsHint;

            foreach (Control control in form.Controls)
            {
                SetControlEvents(control);

                if (control is GroupBox)
                {
                    GroupBox gb = control as GroupBox;
                    foreach (Control ctr in gb.Controls)
                    {
                        SetControlEvents(ctr);
                    }
                }
            }
        }

        public void SetControlEvents(Control control)
        {
            control.MouseClick += UserActsHint;
            control.MouseDoubleClick += UserActsHint;
            control.KeyDown += UserActsHint;
            control.TextChanged += UserActsHint;
            control.Click += UserActsHint;

            if (control is ComboBox)
                ((ComboBox)control).SelectedValueChanged += UserActsHint;

            if (control is CheckBox)
                ((CheckBox)control).CheckedChanged += UserActsHint;

            if (control is DateTimePicker)
                ((DateTimePicker)control).ValueChanged += UserActsHint;

            if (control is DataGridView)
                ((DataGridView)control).SelectionChanged += UserActsHint;

            if (control is RadioButton)
                ((RadioButton)control).CheckedChanged += UserActsHint;

            if (control is NumericUpDown)
                ((NumericUpDown)control).ValueChanged += UserActsHint;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UserActsHint(object sender, EventArgs e)
        {
            RestartTimer();
        }

        private void RestartTimer()
        {
            timer.Stop();
            timer.Start();
        }
    }
}
