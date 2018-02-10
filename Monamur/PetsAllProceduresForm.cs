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
    public partial class PetsAllProceduresForm : Form
    {
        static Pets pet = new Pets();

        public PetsAllProceduresForm(Pets petObj)
        {
            InitializeComponent();
            pet = petObj;
            this.Text = pet.Name;
            label1.Text = "Список процедур питомца " + pet.Name;
        }

        private void PetsAllProceduresForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monamurDBDataSet.V_allVisitProcedures". При необходимости она может быть перемещена или удалена.
            this.v_allVisitProceduresTableAdapter.FillByPetID(this.monamurDBDataSet.V_allVisitProcedures, pet.ID);
        }
    }
}
