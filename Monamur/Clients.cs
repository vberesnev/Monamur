using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monamur
{
    public class Clients : ICloneable
    {
        public int ID;
        public string Fio;
        public int Character;
        public string Phone;
        public string Social;
        public string About;
        public int Bonus;
        public bool Sms;

        public Clients(string fio, int character, string phone, string social, string about, int bonus, bool sms)
        {           
            Fio = fio;
            Character = character;
            Phone = phone;
            Social = social;
            About = about;
            Bonus = bonus;
            Sms = sms;
        }

        public Clients(){}

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Delete() {
            try {
                MonamurDBDataSetTableAdapters.ClientsTableAdapter t_clientsTableAdap = new MonamurDBDataSetTableAdapters.ClientsTableAdapter();
                t_clientsTableAdap.DeleteClient(ID);
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex) {
                return false;
            }
        }

        public bool AddClient() {
            try
            {
                MonamurDBDataSetTableAdapters.ClientsTableAdapter t_clientsTableAdap = new MonamurDBDataSetTableAdapters.ClientsTableAdapter();
                t_clientsTableAdap.InsertClient(Fio, Character, Phone, Social, About, Bonus, Sms);
                MonamurDBDataSet.ClientsDataTable t_clientsDT = new MonamurDBDataSet.ClientsDataTable();
                t_clientsTableAdap.FillByFio(t_clientsDT, Fio);
                ID = Convert.ToInt32(t_clientsDT.Rows[0]["id"]);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool UpdateClient() {
            try
            {
                MonamurDBDataSetTableAdapters.ClientsTableAdapter t_clientsTableAdap = new MonamurDBDataSetTableAdapters.ClientsTableAdapter();
                t_clientsTableAdap.UpdateClient(Fio, Character, Phone, Social, About, Bonus, Sms, ID);
                return true;
            }
            catch {
                return false;
            }
        }

        public void GetInfo() {
            MonamurDBDataSetTableAdapters.ClientsTableAdapter t_clientsTableAdap = new MonamurDBDataSetTableAdapters.ClientsTableAdapter();
            MonamurDBDataSet.ClientsDataTable t_clientsDataTable = new MonamurDBDataSet.ClientsDataTable();
            t_clientsTableAdap.FillByID(t_clientsDataTable, ID);
            Fio = t_clientsDataTable.Rows[0]["fio"].ToString();
            Character = Convert.ToInt32(t_clientsDataTable.Rows[0]["character"]);
            Phone = t_clientsDataTable.Rows[0]["phone"].ToString();
            Social = t_clientsDataTable.Rows[0]["social"].ToString(); 
            About = t_clientsDataTable.Rows[0]["about"].ToString(); 
            Bonus = Convert.ToInt32(t_clientsDataTable.Rows[0]["bonus"]);
            Sms = (bool)t_clientsDataTable.Rows[0]["sms"];
        }
    }


}
