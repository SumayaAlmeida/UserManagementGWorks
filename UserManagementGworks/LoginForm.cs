using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserManagementDB;

namespace UserManagementGWorks
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Create database connection
            DBConnection db = new DBConnection("localhost", "usermanagement", "csharp", "password");

            if (db.OpenConnection())
            {
                // Get list of users
                UsersDB usersDB = new UsersDB();

                List<User> userList = usersDB.GetUsers(db);

                bool foundEmail = false;
                bool passwordCorrect = false;

                User loggedInUser = null;

                //check email address formating 

                if (IsValidEmail(this.textBoxEmail.Text))
                {
                    // Check email address and password

                    foreach (User user in userList)
                    {
                        // Check email address exists

                        if (this.textBoxEmail.Text == user.Email)
                        {
                            foundEmail = true;

                            // Check password
                            if (this.textBoxPassword.Text == user.Password)
                            {
                                passwordCorrect = true;
                                loggedInUser = user;
                            }

                            break;
                        }
                    }


                    // foundEmail        passwordCorrect       case
                    //     yes                yes                1. 
                    //     yes                no                 2.
                    //     no                 yes                3.
                    //     no                 no                 3.

                    // Case 1
                    // If email and password are correct - log the user in.

                    if (foundEmail == true && passwordCorrect == true)
                    {
                        this.Visible = false;
                        this.errorLabel.Visible = false;

                        MainForm viewUsersForm = new MainForm(db, loggedInUser);
                        viewUsersForm.ShowDialog();
                        // clear text boxes in case user logs out from Main form it's clear for a different user to Login
                        this.clearTextBoxes();

                        this.Visible = true;
                    }
                    else if (foundEmail == true && passwordCorrect == false)
                    {
                        // Case 2
                        this.errorLabel.Text = "Incorrect password. Please try again";
                        this.errorLabel.Visible = true;
                        //MessageBox.Show("Incorrect password. Please try again.\n\n(Your password can be reset by contacting the I.T. department.)", "Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    }
                    else
                    {
                        // Case 3
                        this.errorLabel.Text = $"The user: {this.textBoxEmail.Text} does not exist. Please try again.";
                        this.errorLabel.Visible = true;
                        //MessageBox.Show($"The user: {this.textBoxEmail.Text} does not exist. Please try again.\n\n(If problems persist, please contact the I.T. department.)", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                } else
                {
                    this.errorLabel.Text = $"The email: {this.textBoxEmail.Text} is not a valid Email format.\n Please enter a valid email address";
                    this.errorLabel.Visible = true;
                }

                

                db.CloseConnection();
            }
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
       

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void clearTextBoxes()
        {
            this.textBoxEmail.Text = "";
            this.textBoxPassword.Text = "";

        }
   
    }
}
