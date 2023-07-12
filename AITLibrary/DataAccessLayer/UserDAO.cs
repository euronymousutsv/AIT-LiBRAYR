using DataAccessLayer.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class UserDAO
    {
        private DataSet1 userDataSet;
        private TabUserTableAdapter TabUserTableAdapter;
        
        public UserDAO()
        {
            userDataSet = new DataSet1();
            TabUserTableAdapter = new TabUserTableAdapter();
        }
        public DataSet1.TabUserDataTable GetUserDataTable()
        {
            try
            {
                TabUserTableAdapter.FillAll(userDataSet.TabUser);
                return userDataSet.TabUser;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
       

        public DataSet1.TabUserDataTable GetUserByUserNamePassword(string userName, string password)
        {
            try
            {
                TabUserTableAdapter.FillByUserNamePassword(userDataSet.TabUser,userName, password);
                return userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool ValidateUser(string sUserName, string sPassword) 
        {
            TabUserTableAdapter objTabUserTableAdapter = new TabUserTableAdapter();
            DataSet1.TabUserDataTable objTabUserDataTable = objTabUserTableAdapter.ValidateUserLogin(sUserName,sPassword);
            int iDataCount = objTabUserDataTable.Count;
            if (iDataCount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
             }
    }
}
