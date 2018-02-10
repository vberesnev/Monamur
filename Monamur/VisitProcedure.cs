using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monamur
{
    class VisitProcedure
    {
        public int ID;
        public int ProcedureID;
        public string ProcedureName;
        public int VisitID;
        public int Cost;
        public string Info;


        public void GetInfoByProcId() {
            MonamurDBDataSetTableAdapters.ProceduresTableAdapter t_procedTableAdap = new MonamurDBDataSetTableAdapters.ProceduresTableAdapter();
            MonamurDBDataSet.ProceduresDataTable t_procedDataTable = new MonamurDBDataSet.ProceduresDataTable();
            t_procedTableAdap.FillById(t_procedDataTable, ProcedureID);
            ProcedureName = t_procedDataTable.Rows[0]["procedure_name"].ToString();
            if (t_procedDataTable.Rows[0]["cost"].ToString() != String.Empty)
            {
                Cost = Convert.ToInt32(t_procedDataTable.Rows[0]["cost"]);
            }
            Info = t_procedDataTable.Rows[0]["info"].ToString();
        }

        public bool InsertVisitProcedure() {
            try
            {
                MonamurDBDataSetTableAdapters.VisitProceduresTableAdapter t_visitProcTableAdap = new MonamurDBDataSetTableAdapters.VisitProceduresTableAdapter();
                t_visitProcTableAdap.Insert(VisitID, ProcedureID, Cost);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool DeletetVisitProcedure()
        {
            try
            {
                MonamurDBDataSetTableAdapters.VisitProceduresTableAdapter t_visitProcTableAdap = new MonamurDBDataSetTableAdapters.VisitProceduresTableAdapter();
                t_visitProcTableAdap.DeleteByVisitId(VisitID);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    
}
