using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monamur
{
    public class User
    {
        public int ID;
        public string Login;
        public string Password;
        public string Role;

        public User(int id, string login, string password,  string role) {
            ID = id;
            Login = login;
            Password = password;
            Role = role;
        }

        public User() {
            
        }

        public void UpdateProfile()
        {
            MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdap = new MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            MonamurDBDataSet.V_usersDataTable v_usersDT = new MonamurDBDataSet.V_usersDataTable();
            v_usersTableAdap.FillById(v_usersDT, ID);
            Login = v_usersDT.Rows[0]["login"].ToString();
        }

        public bool ChangeProfileLogin(string newLogin) {
            MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdap = new MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            MonamurDBDataSet.V_usersDataTable v_usersDT = new MonamurDBDataSet.V_usersDataTable();
            v_usersTableAdap.FillByLogin(v_usersDT, newLogin);
            if (v_usersDT.Rows.Count == 0)
            {
                MonamurDBDataSetTableAdapters.UsersTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UsersTableAdapter();
                t_usersTableAdap.UpdateUserProfile(newLogin, ID);
                return true;
            }
            else return false;
          
        }

        public bool ChangeProfilePassword(string oldPassword, string newPassword)
        {
            MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdap = new MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            MonamurDBDataSet.V_usersDataTable v_usersDT = new MonamurDBDataSet.V_usersDataTable();
            v_usersTableAdap.FillById(v_usersDT, ID);
            if (oldPassword == v_usersDT.Rows[0]["password"].ToString())
            {
                MonamurDBDataSetTableAdapters.UsersTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UsersTableAdapter();
                t_usersTableAdap.UpdateUserPassword(newPassword, ID);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeUserPassword(string newPassword) {
            MonamurDBDataSetTableAdapters.UsersTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UsersTableAdapter();
            t_usersTableAdap.UpdateUserPassword(newPassword, ID);
            return true;
        }

        public int GetUserRoleId() {
            MonamurDBDataSetTableAdapters.UserRolesTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UserRolesTableAdapter();
            MonamurDBDataSet.UserRolesDataTable t_userRoles = new MonamurDBDataSet.UserRolesDataTable();
            t_usersTableAdap.FillByRole(t_userRoles, Role);
            return Convert.ToInt32(t_userRoles[0]["id"]);
        }

        public string GetUserRole()
        {
            MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdapter = new MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            MonamurDBDataSet.V_usersDataTable v_usersDataTable = new MonamurDBDataSet.V_usersDataTable();
            v_usersTableAdapter.FillById(v_usersDataTable, ID);
            return v_usersDataTable.Rows[0]["role"].ToString();
        }

        public void DeleteUser() {
            MonamurDBDataSetTableAdapters.UsersTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UsersTableAdapter();
            t_usersTableAdap.DeleteUser(ID);
        }

        public bool AddUser(int roleId) {
            MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdap = new MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            MonamurDBDataSet.V_usersDataTable v_usersDT = new MonamurDBDataSet.V_usersDataTable();
            v_usersTableAdap.FillByLogin(v_usersDT, Login);
            if (v_usersDT.Rows.Count == 0)
            {
                MonamurDBDataSetTableAdapters.UsersTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UsersTableAdapter();
                t_usersTableAdap.InsertUser(Login, Password, roleId);
                return true;
            }
            else {
                return false;
            }
        }

        public bool EditUser(string newLogin, int newRoleId) {
            MonamurDBDataSetTableAdapters.V_usersTableAdapter v_usersTableAdap = new MonamurDBDataSetTableAdapters.V_usersTableAdapter();
            MonamurDBDataSet.V_usersDataTable v_usersDT = new MonamurDBDataSet.V_usersDataTable();
            v_usersTableAdap.FillByLogin(v_usersDT, newLogin);
            if ((v_usersDT.Rows.Count == 0) || ((v_usersDT.Rows.Count == 1) && (Convert.ToInt32(v_usersDT.Rows[0]["id"]) == ID)))
            {
                MonamurDBDataSetTableAdapters.UsersTableAdapter t_usersTableAdap = new MonamurDBDataSetTableAdapters.UsersTableAdapter();
                t_usersTableAdap.UpdateUserAllParams(newLogin, newRoleId, ID);
                return true;
            }
            else {
                return false;
            }
        }

        public void AddLog(string logText) {
            MonamurDBDataSetTableAdapters.logsTableAdapter t_logsTableAdap = new MonamurDBDataSetTableAdapters.logsTableAdapter();
            t_logsTableAdap.InsertLog(DateTime.Now, ID, logText);
        }

        public void AddLog(List <string> logText)
        {
            MonamurDBDataSetTableAdapters.logsTableAdapter t_logsTableAdap = new MonamurDBDataSetTableAdapters.logsTableAdapter();
            foreach (string log in logText) {
                t_logsTableAdap.InsertLog(DateTime.Now, ID, log);
            }
        }

    }
}
