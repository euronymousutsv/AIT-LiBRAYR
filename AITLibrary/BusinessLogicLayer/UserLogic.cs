using BusinessLogic;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
public class UserLogic
    {
        public UserDAO userDAO;
        public DataSet1.TabUserDataTable tabUserDataTable;

        public UserLogic() {
              UserDAO userDAO = new UserDAO();
            DataSet1.TabUserDataTable tabUserDataTable;
            tabUserDataTable = new DataSet1.TabUserDataTable();
        }

        public List<UserModel> GetListOfUsers()
        {
            // Create a new list called "users"
            List<UserModel> users = new List<UserModel>();

            // Store data returned from GetUserDataTable() into userTable row by row
            tabUserDataTable = userDAO.GetUserDataTable();

            foreach (DataSet1.TabUserRow userRow in tabUserDataTable.Rows)
            {
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users;
        }
        public List<UserModel> GetListOfUsersByLogin(string userName, string password)
        {
            // Create a new list of UserModel
            List<UserModel> users = new List<UserModel>();

            tabUserDataTable = userDAO.GetUserByUserNamePassword(userName, password);

            foreach (DataSet1.TabUserRow userRow in tabUserDataTable.Rows)
            {
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users;
        }
        public bool ValidateUser(string sUsername, string sPassword)
        {
            UserDAO userDAO = new UserDAO();
            bool bloginStatus = userDAO.ValidateUser(sUsername, sPassword);
       

            return bloginStatus;

           


        }
    }

}
