
namespace E_Library.Admin
{
    partial class AdminBooks
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
            this.btn = new Krypton.Toolkit.KryptonButton();
            this.btnBooks = new Krypton.Toolkit.KryptonButton();
            this.btnAccounts = new Krypton.Toolkit.KryptonButton();
            this.btnLogout = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.tcAccounts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBooks = new Krypton.Toolkit.KryptonDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.txtBookname = new Krypton.Toolkit.KryptonTextBox();
            this.txtBookauthor = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tcAccounts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn);
            this.kryptonPanel1.Controls.Add(this.btnBooks);
            this.kryptonPanel1.Controls.Add(this.btnAccounts);
            this.kryptonPanel1.Controls.Add(this.btnLogout);
            this.kryptonPanel1.Controls.Add(this.btnDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(17, 27);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(167, 561);
            this.kryptonPanel1.TabIndex = 8;
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
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(20, 249);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(120, 52);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Values.Text = "Accounts";
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // tcAccounts
            // 
            this.tcAccounts.Controls.Add(this.tabPage1);
            this.tcAccounts.Controls.Add(this.tabPage2);
            this.tcAccounts.Location = new System.Drawing.Point(219, 53);
            this.tcAccounts.Name = "tcAccounts";
            this.tcAccounts.SelectedIndex = 0;
            this.tcAccounts.Size = new System.Drawing.Size(770, 549);
            this.tcAccounts.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.Location = new System.Drawing.Point(27, 61);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(720, 450);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.txtBookauthor);
            this.tabPage2.Controls.Add(this.kryptonLabel2);
            this.tabPage2.Controls.Add(this.txtBookname);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.kryptonLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(87, 106);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Book name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBookname
            // 
            this.txtBookname.Location = new System.Drawing.Point(231, 103);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(100, 23);
            this.txtBookname.TabIndex = 2;
            // 
            // txtBookauthor
            // 
            this.txtBookauthor.Location = new System.Drawing.Point(231, 177);
            this.txtBookauthor.Name = "txtBookauthor";
            this.txtBookauthor.Size = new System.Drawing.Size(100, 23);
            this.txtBookauthor.TabIndex = 4;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(87, 180);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Book author";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(507, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(241, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AdminBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.tcAccounts);
            this.Name = "AdminBooks";
            this.Text = "AdminBooks";
            this.Load += new System.EventHandler(this.AdminBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tcAccounts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btn;
        private Krypton.Toolkit.KryptonButton btnBooks;
        private Krypton.Toolkit.KryptonButton btnAccounts;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private TabControl tcAccounts;
        private TabPage tabPage1;
        private Krypton.Toolkit.KryptonDataGridView dgvBooks;
        private TabPage tabPage2;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonTextBox txtBookauthor;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtBookname;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}