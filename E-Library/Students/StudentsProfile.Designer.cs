namespace E_Library.Students
{
    partial class StudentsProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnReturn = new Krypton.Toolkit.KryptonButton();
            this.btnBooks = new Krypton.Toolkit.KryptonButton();
            this.btnProfile = new Krypton.Toolkit.KryptonButton();
            this.btnLogout = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.cmbCourse = new Krypton.Toolkit.KryptonComboBox();
            this.cmbYearlevel = new Krypton.Toolkit.KryptonComboBox();
            this.cmbGender = new Krypton.Toolkit.KryptonComboBox();
            this.txtLastname = new Krypton.Toolkit.KryptonTextBox();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtContactnumber = new Krypton.Toolkit.KryptonTextBox();
            this.txtFirstname = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtIdnumber = new Krypton.Toolkit.KryptonTextBox();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            this.txtConfirmpassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYearlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnReturn);
            this.kryptonPanel1.Controls.Add(this.btnBooks);
            this.kryptonPanel1.Controls.Add(this.btnProfile);
            this.kryptonPanel1.Controls.Add(this.btnLogout);
            this.kryptonPanel1.Controls.Add(this.btnDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(17, 27);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(167, 561);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(20, 395);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 52);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Values.Text = "Return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(20, 322);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(120, 52);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Values.Text = "Books";
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(20, 249);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 52);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Values.Text = "Profile";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(20, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Values.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(20, 176);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(120, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Values.Text = "Home";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 25);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCourse
            // 
            this.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCourse.DropDownWidth = 121;
            this.cmbCourse.IntegralHeight = false;
            this.cmbCourse.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSED",
            "BEED",
            "BSN"});
            this.cmbCourse.Location = new System.Drawing.Point(743, 189);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbCourse.TabIndex = 64;
            // 
            // cmbYearlevel
            // 
            this.cmbYearlevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbYearlevel.DropDownWidth = 121;
            this.cmbYearlevel.IntegralHeight = false;
            this.cmbYearlevel.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year",
            "4th year"});
            this.cmbYearlevel.Location = new System.Drawing.Point(743, 145);
            this.cmbYearlevel.Name = "cmbYearlevel";
            this.cmbYearlevel.Size = new System.Drawing.Size(121, 21);
            this.cmbYearlevel.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbYearlevel.TabIndex = 63;
            // 
            // cmbGender
            // 
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGender.DropDownWidth = 121;
            this.cmbGender.IntegralHeight = false;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(373, 238);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbGender.TabIndex = 62;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(385, 187);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 23);
            this.txtLastname.TabIndex = 61;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(746, 102);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 23);
            this.txtAddress.TabIndex = 60;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(743, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 23);
            this.txtEmail.TabIndex = 59;
            // 
            // txtContactnumber
            // 
            this.txtContactnumber.Location = new System.Drawing.Point(746, 234);
            this.txtContactnumber.Name = "txtContactnumber";
            this.txtContactnumber.Size = new System.Drawing.Size(131, 23);
            this.txtContactnumber.TabIndex = 58;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(394, 143);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 23);
            this.txtFirstname.TabIndex = 57;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(643, 105);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel6.TabIndex = 56;
            this.kryptonLabel6.Values.Text = "Address";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(652, 292);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel7.TabIndex = 55;
            this.kryptonLabel7.Values.Text = "Email";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(652, 240);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel8.TabIndex = 54;
            this.kryptonLabel8.Values.Text = "Contact no.";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(652, 196);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel9.TabIndex = 53;
            this.kryptonLabel9.Values.Text = "Course";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(652, 151);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel10.TabIndex = 52;
            this.kryptonLabel10.Values.Text = "Year level";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(228, 242);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel5.TabIndex = 51;
            this.kryptonLabel5.Values.Text = "Gender";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(238, 198);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel4.TabIndex = 50;
            this.kryptonLabel4.Values.Text = "Last name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(238, 146);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel3.TabIndex = 49;
            this.kryptonLabel3.Values.Text = "First name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(238, 102);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel2.TabIndex = 48;
            this.kryptonLabel2.Values.Text = "Id number";
            // 
            // txtIdnumber
            // 
            this.txtIdnumber.Location = new System.Drawing.Point(404, 99);
            this.txtIdnumber.Name = "txtIdnumber";
            this.txtIdnumber.Size = new System.Drawing.Size(100, 23);
            this.txtIdnumber.TabIndex = 47;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(385, 402);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 25);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Values.Text = "Edit";
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.Location = new System.Drawing.Point(394, 334);
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(100, 23);
            this.txtConfirmpassword.TabIndex = 72;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(235, 334);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel11.TabIndex = 71;
            this.kryptonLabel11.Values.Text = "Confirm password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(394, 287);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 70;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(235, 287);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel1.TabIndex = 69;
            this.kryptonLabel1.Values.Text = "Password";
            // 
            // StudentsProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.txtConfirmpassword);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.cmbYearlevel);
            this.Controls.Add(this.txtIdnumber);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.txtContactnumber);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Name = "StudentsProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsProfile";
            this.Load += new System.EventHandler(this.StudentsProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYearlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnReturn;
        private Krypton.Toolkit.KryptonButton btnBooks;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonComboBox cmbCourse;
        private Krypton.Toolkit.KryptonComboBox cmbYearlevel;
        private Krypton.Toolkit.KryptonComboBox cmbGender;
        private Krypton.Toolkit.KryptonTextBox txtLastname;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonTextBox txtContactnumber;
        private Krypton.Toolkit.KryptonTextBox txtFirstname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtIdnumber;
        private Krypton.Toolkit.KryptonButton btnEdit;
        private Krypton.Toolkit.KryptonTextBox txtConfirmpassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}