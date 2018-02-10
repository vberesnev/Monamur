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
    public partial class SelectClientForm : Form
    {

        static User user = new User();
        static bool newPet;


        public SelectClientForm(User userObj, bool isNewPetObj)
        {
            InitializeComponent();
            user = userObj;
            newPet = isNewPetObj;
        }

        private void SelectClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.monamurDBDataSet.Clients);
            search_textBox.Focus();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(client_dataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);
            string clientFio = client_dataGridView.SelectedRows[0].Cells["fioDataGridViewTextBoxColumn"].Value.ToString();
            if (newPet)
            {
                AddPetForm APF = this.Owner as AddPetForm;
                if (APF != null)
                {
                    APF.SetClient(clientId, clientFio);
                }
            }
            else {
                EditPetForm EPF = this.Owner as EditPetForm;
                if (EPF != null)
                {
                    EPF.SetClient(clientId, clientFio);
                }
            }
          
            this.Close();
        }

        private void addClient_button_Click(object sender, EventArgs e)
        {
            AddClientForm ACF = new AddClientForm(user);
            ACF.ShowDialog();
            this.clientsTableAdapter.Fill(this.monamurDBDataSet.Clients);
        }

    
        private void client_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            save_button_Click(sender, null);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            string textTofind = search_textBox.Text;
            string filter = String.Format("fio like '%{0}%'", textTofind);
            clientsBindingSource.Filter = filter;
        }
    }
}
