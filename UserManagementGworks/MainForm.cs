using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using UserManagementDB;


namespace UserManagementGWorks
{
    public partial class MainForm : Form
    {

        User currentUser = null; 
        DBConnection db = null;
        

        public MainForm(DBConnection db, User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.db = db;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            // Select the currently logged in user
            this.listBoxUsers.SelectedIndex = IndexOfUser(this.currentUser);

            User user = this.listBoxUsers.SelectedItem as User;
            Console.WriteLine(user.Email);

            RefreshUserDetails(user);
            RefreshControls(this.listBoxUsers.SelectedItem as User);
            RefreshLoggedInUserDetails();
        }

        private void editIcon_Click(object sender, EventArgs e)
        {
            User user = this.listBoxUsers.SelectedItem as User;

            AddEditUserForm editUserForm = new AddEditUserForm(this.db, user, "edit");
            editUserForm.ShowDialog();

            RefreshList();

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddEditUserForm editUserForm = new AddEditUserForm(this.db, "add");
            editUserForm.ShowDialog();

            RefreshList();
        }

        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            User user = this.listBoxUsers.SelectedItem as User;

            DialogResult result = MessageBox.Show($"You are about to delete the user:\n\n{user.Name}\n{user.Email}\n\nAre you sure?",
                                                   "Email address exists",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UsersDB usersDB = new UsersDB();
                usersDB.Delete(this.db, user.Email);

                RefreshList();

                if (this.listBoxUsers.Items.Count > 0)
                {
                    this.listBoxUsers.SelectedIndex = 0;
                }
            }
        }
 
        private int IndexOfUser(User user)
        {
            bool emailMatches = false;
            int index = this.listBoxUsers.FindString(user.Name);

            while (emailMatches == false)
            {
                if (index >= 0)
                {
                    User candidate = this.listBoxUsers.Items[index] as User;
                    if (user.Email == candidate.Email)
                    {
                        emailMatches = true;
                    }
                    else
                    {
                        index = this.listBoxUsers.FindString(user.Name, index);
                    }
                }
                else
                {
                    return -1;
                }
            }

            return index;

        }

        private void RefreshList()
        {
            // Get list of users
            UsersDB usersDB = new UsersDB();

            List<User> userList = usersDB.GetUsers(db);

            this.listBoxUsers.Items.Clear();
            this.listBoxUsers.Items.AddRange(userList.ToArray());
        }

        // Populate the User Details fields given a User object.

        private void RefreshUserDetails(User user)
        {
            // Update fields on form with data from user
            this.labelEmailText.Text = user.Email;
            this.labelNameText.Text = user.Name;
            this.labelPhoneText.Text = user.Phone;
            this.labelGroupText.Text = user.Group;
            this.checkBoxAdmin.Checked = user.IsAdmin;

            // get the root for the project profile images folder + the name of the image  on database image field
            Image userImage = null;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string profileDirectory = $"{projectDirectory}\\images\\profile\\";

            if (File.Exists(profileDirectory+user.Image))
            {
                userImage = Image.FromFile(profileDirectory+user.Image);
            }
            else
            {
                userImage = Image.FromFile(@"C:\Users\Sumaya\source\repos\UserManagementGWorks\UserManagementGworks\images\profile\user1-01.jpg");
            }

            this.pictureBoxUserImage.Image = userImage;

            // If user image is larger than PictureBox, then Zoom out,
            // otherwise, center the image in the frame
            if (userImage.Width > pictureBoxUserImage.ClientSize.Width ||
                userImage.Height > pictureBoxUserImage.ClientSize.Height)
            {
                this.pictureBoxUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                this.pictureBoxUserImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            
        }

        private void RefreshControls(User selectedUser)
        {
            if (this.currentUser.IsAdmin)
            {
                this.buttonAddUser.Enabled = true;
                this.buttonDelete.Enabled = true;
                this.editIcon.Enabled = true;
            }
            else
            {
                this.buttonAddUser.Enabled = false;
                this.buttonDelete.Enabled = false;
                this.editIcon.Enabled = false;
            }

            // User can always edit their own details, but not delete their own profile

            if (selectedUser.Email == this.currentUser.Email)
            {
                this.editIcon.Enabled = true;
                this.buttonDelete.Enabled = false;
            }
        }

        private void RefreshLoggedInUserDetails()
        {
            string admin = String.Empty;
            if (this.currentUser.IsAdmin)
            {
                admin = " (Admin)";
            }

            this.labelCurrentUserName.Text = $"{this.currentUser.Name}{admin}";
            this.labelCurrentUserEmail.Text = this.currentUser.Email;
        }
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = this.listBoxUsers.SelectedItem as User;

            RefreshUserDetails(selectedUser);
            RefreshControls(selectedUser);
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }



        //addcomment
    }
}


