namespace E_Library.Admin
{
    partial class AdminAccounts
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
            this.dgvAccounts = new Krypton.Toolkit.KryptonDataGridView();
            this.tcAccounts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnRegister = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btn = new Krypton.Toolkit.KryptonButton();
            this.btnBooks = new Krypton.Toolkit.KryptonButton();
            this.btnAccounts = new Krypton.Toolkit.KryptonButton();
            this.btnLogout = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cmbRole = new Krypton.Toolkit.KryptonComboBox();
            this.txtConfirmpassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
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
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.txtIdnumber = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.tcAccounts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYearlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.Location = new System.Drawing.Point(27, 61);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Size = new System.Drawing.Size(720, 450);
            this.dgvAccounts.TabIndex = 2;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            // 
            // tcAccounts
            // 
            this.tcAccounts.Controls.Add(this.tabPage1);
            this.tcAccounts.Controls.Add(this.tabPage2);
            this.tcAccounts.Location = new System.Drawing.Point(225, 52);
            this.tcAccounts.Name = "tcAccounts";
            this.tcAccounts.SelectedIndex = 0;
            this.tcAccounts.Size = new System.Drawing.Size(770, 549);
            this.tcAccounts.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtConfirmpassword);
            this.tabPage2.Controls.Add(this.cmbRole);
            this.tabPage2.Controls.Add(this.kryptonLabel11);
            this.tabPage2.Controls.Add(this.kryptonLabel1);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.kryptonLabel2);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.cmbCourse);
            this.tabPage2.Controls.Add(this.btnRegister);
            this.tabPage2.Controls.Add(this.cmbYearlevel);
            this.tabPage2.Controls.Add(this.kryptonLabel12);
            this.tabPage2.Controls.Add(this.cmbGender);
            this.tabPage2.Controls.Add(this.txtIdnumber);
            this.tabPage2.Controls.Add(this.txtLastname);
            this.tabPage2.Controls.Add(this.kryptonLabel3);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.kryptonLabel4);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.kryptonLabel5);
            this.tabPage2.Controls.Add(this.txtContactnumber);
            this.tabPage2.Controls.Add(this.kryptonLabel10);
            this.tabPage2.Controls.Add(this.txtFirstname);
            this.tabPage2.Controls.Add(this.kryptonLabel9);
            this.tabPage2.Controls.Add(this.kryptonLabel6);
            this.tabPage2.Controls.Add(this.kryptonLabel8);
            this.tabPage2.Controls.Add(this.kryptonLabel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(324, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 25);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(427, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(207, 397);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 25);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.Values.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn);
            this.kryptonPanel1.Controls.Add(this.btnBooks);
            this.kryptonPanel1.Controls.Add(this.btnAccounts);
            this.kryptonPanel1.Controls.Add(this.btnLogout);
            this.kryptonPanel1.Controls.Add(this.btnDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(23, 26);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(167, 561);
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(20, 395);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 52);
            this.btn.TabIndex = 4;
            this.btn.Values.Text = "Books";
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
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(20, 249);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(120, 52);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Values.Text = "Accounts";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(20, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Values.Text = "Logout";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(20, 176);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(120, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Values.Text = "Home";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(57, 54);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel1.TabIndex = 47;
            this.kryptonLabel1.Values.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRole.DropDownWidth = 121;
            this.cmbRole.IntegralHeight = false;
            this.cmbRole.Items.AddRange(new object[] {
            "ADMIN",
            "STUDENT"});
            this.cmbRole.Location = new System.Drawing.Point(207, 53);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRole.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbRole.TabIndex = 48;
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.Location = new System.Drawing.Point(206, 338);
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(100, 23);
            this.txtConfirmpassword.TabIndex = 51;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(47, 338);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel11.TabIndex = 50;
            this.kryptonLabel11.Values.Text = "Confirm password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 291);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 49;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(47, 291);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel2.TabIndex = 48;
            this.kryptonLabel2.Values.Text = "Password";
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
            this.cmbCourse.Location = new System.Drawing.Point(562, 191);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbCourse.TabIndex = 47;
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
            this.cmbYearlevel.Location = new System.Drawing.Point(562, 147);
            this.cmbYearlevel.Name = "cmbYearlevel";
            this.cmbYearlevel.Size = new System.Drawing.Size(121, 21);
            this.cmbYearlevel.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbYearlevel.TabIndex = 46;
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
            this.cmbGender.Location = new System.Drawing.Point(195, 236);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbGender.TabIndex = 45;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(207, 185);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 23);
            this.txtLastname.TabIndex = 44;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(623, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 23);
            this.txtAddress.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(562, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 23);
            this.txtEmail.TabIndex = 42;
            // 
            // txtContactnumber
            // 
            this.txtContactnumber.Location = new System.Drawing.Point(565, 236);
            this.txtContactnumber.Name = "txtContactnumber";
            this.txtContactnumber.Size = new System.Drawing.Size(131, 23);
            this.txtContactnumber.TabIndex = 41;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(216, 141);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 23);
            this.txtFirstname.TabIndex = 40;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(517, 103);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel6.TabIndex = 39;
            this.kryptonLabel6.Values.Text = "Address";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(468, 291);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel7.TabIndex = 38;
            this.kryptonLabel7.Values.Text = "Email";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(468, 239);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel8.TabIndex = 37;
            this.kryptonLabel8.Values.Text = "Contact no.";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(468, 195);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel9.TabIndex = 36;
            this.kryptonLabel9.Values.Text = "Course";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(468, 150);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel10.TabIndex = 35;
            this.kryptonLabel10.Values.Text = "Year level";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(47, 237);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel5.TabIndex = 34;
            this.kryptonLabel5.Values.Text = "Gender";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(57, 193);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel4.TabIndex = 33;
            this.kryptonLabel4.Values.Text = "Last name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(57, 141);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel3.TabIndex = 32;
            this.kryptonLabel3.Values.Text = "First name";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(57, 97);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel12.TabIndex = 31;
            this.kryptonLabel12.Values.Text = "Id number";
            // 
            // txtIdnumber
            // 
            this.txtIdnumber.Location = new System.Drawing.Point(226, 97);
            this.txtIdnumber.Name = "txtIdnumber";
            this.txtIdnumber.Size = new System.Drawing.Size(100, 23);
            this.txtIdnumber.TabIndex = 30;
            // 
            // AdminAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.tcAccounts);
            this.Name = "AdminAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAccount";
            this.Load += new System.EventHandler(this.AdminAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.tcAccounts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYearlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dgvAccounts;
        private TabControl tcAccounts;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btn;
        private Krypton.Toolkit.KryptonButton btnBooks;
        private Krypton.Toolkit.KryptonButton btnAccounts;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnRegister;
        private Krypton.Toolkit.KryptonTextBox txtConfirmpassword;
        private Krypton.Toolkit.KryptonComboBox cmbRole;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox cmbCourse;
        private Krypton.Toolkit.KryptonComboBox cmbYearlevel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonComboBox cmbGender;
        private Krypton.Toolkit.KryptonTextBox txtIdnumber;
        private Krypton.Toolkit.KryptonTextBox txtLastname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtContactnumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox txtFirstname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
    }
}