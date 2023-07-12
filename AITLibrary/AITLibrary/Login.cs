
using BusinessLogic;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String sUserName = usernameTxtBx.Text;
            String sPassword = passwordTxtBx.Text;

            if (String.IsNullOrEmpty(usernameTxtBx.Text) || String.IsNullOrEmpty(passwordTxtBx.Text))
            {
                MessageBox.Show("The username or password cannot be empty.");
            }
            UserLogic userLogic = new UserLogic();
            List<UserModel> users = userLogic.GetListOfUsersByLogin(sUserName, sPassword);


            // If there is a user with the right username and password
            if (users.Count > 0)
            {
                

                if (currentUser.UserLevel == 3)
                {

                }
                else
                {
                    StudentHome studentHome = new StudentHome();
                    studentHome.Show();
                    this.Hide();
                }
               


                /*  // If user is an admin (ie userLevel 3) open AdminForm
                  if (currentUser.UserLevel == 3)
                  {
                      // Thread to open AdminForm
                     // System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminHomeForm));

                     // t.Start();
                  }
                  else
                  {
                      // Otherwise open StudentForm
                     // System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenStudentHomeForm));

                     // t.Start();
                  }
                  this.Hide();    // Close LoginForm once logged in */
            }
            else
            {
                // Show an error label if credentials are incorrect
                MessageBox.Show("Invalid login. Please retry.");
            }
        }
    }



}


