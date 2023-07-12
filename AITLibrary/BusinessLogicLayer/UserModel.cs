using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserModel
    {
        // Attributes, getters and setters of UserModel
        #region attributes

        private int userId;
        private string userName;
        private string userPassword;
        private int userLevel;
        private string userEmail;

        #endregion

        public int UserID
        {
            set { userId = value; }
            get { return userId; }
        }

        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }

        public string UserPassword
        {
            set { userPassword = value; }
            get { return userPassword; }
        }

        public int UserLevel
        {
            set
            {
                if (value > -1)
                    userLevel = value;
            }
            get
            {
                return userLevel;
            }
        }

        public string UserEmail
        {
            set { userEmail = value; }
            get { return userEmail; }
        }

        // Method to store a row of data from the user tables into a UserModel variable
        public static UserModel Parse(DataSet1.TabUserRow userRow)
        {
            if (userRow == null)
                return null;

            UserModel userModel = new UserModel();
            userModel.UserID = userRow.UID;
            userModel.UserName = userRow.UserName;
            userModel.UserPassword = userRow.Password;
            userModel.UserLevel = userRow.UserLevel;
            userModel.UserEmail = userRow.UserEmail;

            return userModel;
        }
    }
}
