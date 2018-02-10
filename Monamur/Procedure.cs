using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monamur
{
    public class Procedure : ICloneable
    {
        public int ID;
        public string ProcedureName;
        public int AnimalID;
        public string Animal;
        public int Cost;
        public string Info;

        public Procedure() { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Delete() {
            try
            {
                MonamurDBDataSetTableAdapters.ProceduresTableAdapter t_procedTableAdap = new MonamurDBDataSetTableAdapters.ProceduresTableAdapter();
                t_procedTableAdap.DeleteProcedure(ID);
                return true;
            }
            catch {
                return false;
            }
            
        }

        public bool InsertProcedure() {
            try
            {
                MonamurDBDataSetTableAdapters.ProceduresTableAdapter t_procedTableAdap = new MonamurDBDataSetTableAdapters.ProceduresTableAdapter();
                t_procedTableAdap.InsertProcedure(ProcedureName, AnimalID, Cost, Info);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool UpdateProcedure() {
            try
            {
                MonamurDBDataSetTableAdapters.ProceduresTableAdapter t_procedTableAdap = new MonamurDBDataSetTableAdapters.ProceduresTableAdapter();
                t_procedTableAdap.UpdateProcedure(ProcedureName, AnimalID, Cost, Info, ID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void GetInfo() {
            MonamurDBDataSetTableAdapters.V_proceduresTableAdapter v_procedTableAdap = new MonamurDBDataSetTableAdapters.V_proceduresTableAdapter();
            MonamurDBDataSet.V_proceduresDataTable v_procedDataTable = new MonamurDBDataSet.V_proceduresDataTable();
            v_procedTableAdap.FillById(v_procedDataTable, ID);
            ProcedureName = v_procedDataTable.Rows[0]["procedure_name"].ToString();
            AnimalID = Convert.ToInt32(v_procedDataTable.Rows[0]["animal_id"]);
            Animal = v_procedDataTable.Rows[0]["animal"].ToString();
            Cost = Convert.ToInt32(v_procedDataTable.Rows[0]["cost"]);
            Info = v_procedDataTable.Rows[0]["info"].ToString();
        }


    }

}
