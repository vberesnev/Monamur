using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monamur
{
    public class Pets : ICloneable
    {
        public int ID;
        public string Name;
        public DateTime Bday;
        public int Age;
        public int ClientId;
        public string ClientName;
        public int BreedId;
        public string Breed;
        public string About;
        public bool ALive;
        public int Animal;
  


        public Pets() { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Delete()
        {
            try
            {
                MonamurDBDataSetTableAdapters.PetsTableAdapter t_petsTableAdap = new MonamurDBDataSetTableAdapters.PetsTableAdapter();
                t_petsTableAdap.DeletePet(ID);
                return true;
            }
            catch {
                return false;
            }
            
        }

        public void AddPet() {
            MonamurDBDataSetTableAdapters.PetsTableAdapter t_petsTableAdap = new MonamurDBDataSetTableAdapters.PetsTableAdapter();
            /*if (ClientId == 0 || BreedId == 0)
            {
                if (BreedId == 0 && ClientId == 0)
                {
                    t_petsTableAdap.InsertPet(Name, Bday, null, null, About);
                }
                else if (ClientId == 0)
                {
                    t_petsTableAdap.InsertPet(Name, Bday, null, BreedId, About);
                }
                else {
                    t_petsTableAdap.InsertPet(Name, Bday, ClientId, null, About);
                }
            }
            else {
                t_petsTableAdap.InsertPet(Name, Bday, ClientId, BreedId, About);
            }*/
            if (Bday == DateTime.Parse("1900-01-01"))
            {
                t_petsTableAdap.InsertPet(Name, null, ClientId, BreedId, About);
            }
            else {
                t_petsTableAdap.InsertPet(Name, Bday, ClientId, BreedId, About);
            }
            
        }

        public void GetClient(Clients client) {
            MonamurDBDataSetTableAdapters.ClientsTableAdapter t_clientsTableAdap = new MonamurDBDataSetTableAdapters.ClientsTableAdapter();
            MonamurDBDataSet.ClientsDataTable t_clientsDataTable = new MonamurDBDataSet.ClientsDataTable();
            t_clientsTableAdap.FillByID(t_clientsDataTable, client.ID);
            client.Fio = t_clientsDataTable.Rows[0]["fio"].ToString();
            client.Character = Convert.ToInt32(t_clientsDataTable.Rows[0]["character"]);
            client.Phone = t_clientsDataTable.Rows[0]["phone"].ToString();
            client.Social = t_clientsDataTable.Rows[0]["social"].ToString();
            client.About = t_clientsDataTable.Rows[0]["about"].ToString();
            client.Bonus = Convert.ToInt32(t_clientsDataTable.Rows[0]["bonus"]);
        }

        public bool UpdatePet() {
            MonamurDBDataSetTableAdapters.PetsTableAdapter t_petsTableAdap = new MonamurDBDataSetTableAdapters.PetsTableAdapter();
            try
            {
                /*if (ClientId == 0 || BreedId == 0)
                {
                    if (BreedId == 0 && ClientId == 0)
                    {
                        t_petsTableAdap.UpdatePet(Name, Bday, null, null, About, ALive, ID);
                    }
                    else if (ClientId == 0)
                    {
                        t_petsTableAdap.UpdatePet(Name, Bday, null, BreedId, About, ALive, ID);
                    }
                    else
                    {
                        t_petsTableAdap.UpdatePet(Name, Bday, ClientId, null, About, ALive, ID);
                    }

                }
                else
                {
                    t_petsTableAdap.UpdatePet(Name, Bday, ClientId, BreedId, About, ALive, ID);
                }*/
                if (Bday == DateTime.Parse("1900-01-01"))
                {
                    t_petsTableAdap.UpdatePet(Name, null, ClientId, BreedId, About, ALive, ID);
                }
                else
                {
                    t_petsTableAdap.UpdatePet(Name, Bday, ClientId, BreedId, About, ALive, ID);
                }
                return true;
            }
            catch {
                return false;
            }
        }

        public int GetAnimal() {
            MonamurDBDataSetTableAdapters.BreedsTableAdapter t_breedsTableAdap = new MonamurDBDataSetTableAdapters.BreedsTableAdapter();
            MonamurDBDataSet.BreedsDataTable t_breedsDataTable = new MonamurDBDataSet.BreedsDataTable();
            t_breedsTableAdap.FillById(t_breedsDataTable, BreedId);
            return Convert.ToInt32(t_breedsDataTable.Rows[0]["animal_id"]);
        }

        public void GetInfo()
        {
            MonamurDBDataSetTableAdapters.V_petsTableAdapter v_petsTableAdap = new MonamurDBDataSetTableAdapters.V_petsTableAdapter();
            MonamurDBDataSet.V_petsDataTable v_petsDataTable = new MonamurDBDataSet.V_petsDataTable();
            v_petsTableAdap.FillById(v_petsDataTable, ID);

            Name = v_petsDataTable[0]["name"].ToString();
            if (v_petsDataTable[0]["bday"].ToString() == "")
            {
                // Bday = Convert.ToDateTime("1900-01-01");
            }
            else {
                Bday = Convert.ToDateTime(v_petsDataTable[0]["bday"].ToString());
            }
            //Age = Convert.ToInt32(v_petsDataTable[0]["age"]);
            ClientId = Convert.ToInt32(v_petsDataTable[0]["client_id"]); 
            ClientName = v_petsDataTable[0]["fio"].ToString(); 
            BreedId = Convert.ToInt32(v_petsDataTable[0]["breed_id"]);
            Breed = v_petsDataTable[0]["breed"].ToString();
            About = v_petsDataTable[0]["about"].ToString(); 
            ALive = (bool)v_petsDataTable[0]["alive"];
            Animal = GetAnimal();
        }


    }
}
