using System;

namespace Monamur
{
    public class Visit : ICloneable
    {
        public int ID;
        public DateTime Date;
        public TimeSpan TimeBegin;
        public int PetID;
        public string PetName;
        public string ClientName;
        public int BreedId;
        public int Agress;
        public int Sum;
        public string Info;
        public int UserID;
        public string Login;
        public bool Status;
        public string Payment;

        public Visit() { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int InsertVisit() {
            try {
                MonamurDBDataSetTableAdapters.VisitsTableAdapter t_visitsTableAdap = new MonamurDBDataSetTableAdapters.VisitsTableAdapter();
                t_visitsTableAdap.InsertVisit(Date.ToShortDateString(), TimeBegin.ToString(), PetID, Agress, Sum, Info, UserID, Payment);
                MonamurDBDataSet.VisitsDataTable t_visitsDataTable = new MonamurDBDataSet.VisitsDataTable();
                t_visitsTableAdap.FillByLastVisit(t_visitsDataTable);
                return Convert.ToInt32(t_visitsDataTable.Rows[0]["id"]);
            }
            catch {
                return 0;
            }
        }

        public bool DeleteVisit() {
            try {
                MonamurDBDataSetTableAdapters.VisitsTableAdapter t_visitTableAdap = new MonamurDBDataSetTableAdapters.VisitsTableAdapter();
                t_visitTableAdap.DeleteVisit(ID);
                return true;
            }
            catch {
                return false;
            }
        }

        public void GetInfo() {
            MonamurDBDataSetTableAdapters.V_visitesTableAdapter v_visitTableAdap = new MonamurDBDataSetTableAdapters.V_visitesTableAdapter();
            MonamurDBDataSet.V_visitesDataTable v_visitDataTable = new MonamurDBDataSet.V_visitesDataTable();
            v_visitTableAdap.FillById(v_visitDataTable, ID);
            Date = Convert.ToDateTime(v_visitDataTable.Rows[0]["date"]);
            TimeBegin = TimeSpan.Parse(v_visitDataTable.Rows[0]["time_begin"].ToString());
            PetID = Convert.ToInt32(v_visitDataTable.Rows[0]["id_pet"]);
            PetName = v_visitDataTable.Rows[0]["name"].ToString();
            ClientName = v_visitDataTable.Rows[0]["fio"].ToString();
           // BreedId = Convert.ToInt32(v_visitDataTable.Rows[0]["id_pet"]);
            Agress = Convert.ToInt32(v_visitDataTable.Rows[0]["agress"]);
            Sum = Convert.ToInt32(v_visitDataTable.Rows[0]["sum"]);
            Info = v_visitDataTable.Rows[0]["info"].ToString();
            UserID = Convert.ToInt32(v_visitDataTable.Rows[0]["user_id"]);
            Login = v_visitDataTable.Rows[0]["login"].ToString();
            Status = Convert.ToBoolean(v_visitDataTable.Rows[0]["status"]);
            Payment = v_visitDataTable.Rows[0]["payment"].ToString();
        }

        public bool UpdateVisit() {
            try {
                MonamurDBDataSetTableAdapters.VisitsTableAdapter t_visitTableAdap = new MonamurDBDataSetTableAdapters.VisitsTableAdapter();
                t_visitTableAdap.UpdateVisit(Date.ToShortDateString(), TimeBegin.ToString(), PetID, Agress, Sum, Info, UserID, Payment, ID);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool UpdateStatus() {
            try
            {
                MonamurDBDataSetTableAdapters.VisitsTableAdapter t_visitTableAdap = new MonamurDBDataSetTableAdapters.VisitsTableAdapter();
                t_visitTableAdap.UpdateStatus(ID);
                return true;
            }
            catch {
                return false;
            }
            
            
        }



    }
}
