
namespace UserManagementGWorks
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelAppName = new System.Windows.Forms.Label();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelGroupText = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelPhoneText = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmailText = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNameText = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.editIcon = new System.Windows.Forms.PictureBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.labelCurrentUserName = new System.Windows.Forms.Label();
            this.labelCurrentUserEmail = new System.Windows.Forms.Label();
            this.panelLoggedInUser = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.panelLoggedInUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(771, 546);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 37);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(653, 546);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(97, 37);
            this.buttonAddUser.TabIndex = 4;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAppName.Location = new System.Drawing.Point(35, 37);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(400, 44);
            this.labelAppName.TabIndex = 5;
            this.labelAppName.Text = "User Management App";
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Location = new System.Drawing.Point(23, 88);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(155, 151);
            this.pictureBoxUserImage.TabIndex = 6;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdmin);
            this.groupBox1.Controls.Add(this.labelAdmin);
            this.groupBox1.Controls.Add(this.labelGroupText);
            this.groupBox1.Controls.Add(this.labelGroup);
            this.groupBox1.Controls.Add(this.labelPhoneText);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelEmailText);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelNameText);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.editIcon);
            this.groupBox1.Controls.Add(this.pictureBoxUserImage);
            this.groupBox1.Location = new System.Drawing.Point(35, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 343);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(333, 233);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdmin.TabIndex = 17;
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdmin.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAdmin.Location = new System.Drawing.Point(198, 230);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(113, 19);
            this.labelAdmin.TabIndex = 16;
            this.labelAdmin.Text = "Administrator:";
            // 
            // labelGroupText
            // 
            this.labelGroupText.AutoSize = true;
            this.labelGroupText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroupText.Location = new System.Drawing.Point(262, 200);
            this.labelGroupText.Name = "labelGroupText";
            this.labelGroupText.Size = new System.Drawing.Size(126, 19);
            this.labelGroupText.TabIndex = 15;
            this.labelGroupText.Text = "groupPlaceHlder";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelGroup.Location = new System.Drawing.Point(198, 200);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(58, 19);
            this.labelGroup.TabIndex = 14;
            this.labelGroup.Text = "Group:";
            // 
            // labelPhoneText
            // 
            this.labelPhoneText.AutoSize = true;
            this.labelPhoneText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneText.Location = new System.Drawing.Point(263, 163);
            this.labelPhoneText.Name = "labelPhoneText";
            this.labelPhoneText.Size = new System.Drawing.Size(138, 19);
            this.labelPhoneText.TabIndex = 13;
            this.labelPhoneText.Text = "phonePlaceHolder";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPhone.Location = new System.Drawing.Point(200, 163);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(60, 19);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Phone:";
            // 
            // labelEmailText
            // 
            this.labelEmailText.AutoSize = true;
            this.labelEmailText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmailText.Location = new System.Drawing.Point(263, 127);
            this.labelEmailText.Name = "labelEmailText";
            this.labelEmailText.Size = new System.Drawing.Size(133, 19);
            this.labelEmailText.TabIndex = 11;
            this.labelEmailText.Text = "emailPlaceHolder";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelEmail.Location = new System.Drawing.Point(199, 127);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 25);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            this.labelEmail.UseCompatibleTextRendering = true;
            // 
            // labelNameText
            // 
            this.labelNameText.AutoSize = true;
            this.labelNameText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameText.Location = new System.Drawing.Point(262, 88);
            this.labelNameText.Name = "labelNameText";
            this.labelNameText.Size = new System.Drawing.Size(134, 19);
            this.labelNameText.TabIndex = 9;
            this.labelNameText.Text = "namePlaceHolder";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelName.Location = new System.Drawing.Point(198, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 19);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name:";
            // 
            // editIcon
            // 
            this.editIcon.Image = ((System.Drawing.Image)(resources.GetObject("editIcon.Image")));
            this.editIcon.Location = new System.Drawing.Point(458, 22);
            this.editIcon.Name = "editIcon";
            this.editIcon.Size = new System.Drawing.Size(35, 37);
            this.editIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editIcon.TabIndex = 7;
            this.editIcon.TabStop = false;
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 18;
            this.listBoxUsers.Location = new System.Drawing.Point(582, 193);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(339, 328);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(859, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Log Out";
            // 
            // profileIcon
            // 
            this.profileIcon.Image = ((System.Drawing.Image)(resources.GetObject("profileIcon.Image")));
            this.profileIcon.Location = new System.Drawing.Point(24, 15);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(28, 29);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileIcon.TabIndex = 9;
            this.profileIcon.TabStop = false;
            // 
            // labelCurrentUserName
            // 
            this.labelCurrentUserName.AutoSize = true;
            this.labelCurrentUserName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentUserName.Location = new System.Drawing.Point(80, 23);
            this.labelCurrentUserName.Name = "labelCurrentUserName";
            this.labelCurrentUserName.Size = new System.Drawing.Size(48, 18);
            this.labelCurrentUserName.TabIndex = 11;
            this.labelCurrentUserName.Text = "label2";
            // 
            // labelCurrentUserEmail
            // 
            this.labelCurrentUserEmail.AutoSize = true;
            this.labelCurrentUserEmail.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentUserEmail.Location = new System.Drawing.Point(80, 49);
            this.labelCurrentUserEmail.Name = "labelCurrentUserEmail";
            this.labelCurrentUserEmail.Size = new System.Drawing.Size(48, 18);
            this.labelCurrentUserEmail.TabIndex = 12;
            this.labelCurrentUserEmail.Text = "label3";
            // 
            // panelLoggedInUser
            // 
            this.panelLoggedInUser.Controls.Add(this.profileIcon);
            this.panelLoggedInUser.Controls.Add(this.labelCurrentUserEmail);
            this.panelLoggedInUser.Controls.Add(this.labelCurrentUserName);
            this.panelLoggedInUser.Location = new System.Drawing.Point(493, 37);
            this.panelLoggedInUser.Name = "panelLoggedInUser";
            this.panelLoggedInUser.Size = new System.Drawing.Size(346, 100);
            this.panelLoggedInUser.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 622);
            this.Controls.Add(this.panelLoggedInUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "User Management App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.panelLoggedInUser.ResumeLayout(false);
            this.panelLoggedInUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.PictureBox editIcon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameText;
        private System.Windows.Forms.Label labelGroupText;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelPhoneText;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmailText;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Label labelCurrentUserName;
        private System.Windows.Forms.Label labelCurrentUserEmail;
        private System.Windows.Forms.Panel panelLoggedInUser;
    }
}

