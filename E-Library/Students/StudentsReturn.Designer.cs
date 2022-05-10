namespace E_Library.Students
{
    partial class StudentsReturn
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
            this.btnHistory = new Krypton.Toolkit.KryptonButton();
            this.btnBooks = new Krypton.Toolkit.KryptonButton();
            this.btnAccounts = new Krypton.Toolkit.KryptonButton();
            this.btnLogout = new Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new Krypton.Toolkit.KryptonButton();
            this.dgvLogs = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnHistory);
            this.kryptonPanel1.Controls.Add(this.btnBooks);
            this.kryptonPanel1.Controls.Add(this.btnAccounts);
            this.kryptonPanel1.Controls.Add(this.btnLogout);
            this.kryptonPanel1.Controls.Add(this.btnDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(30, 34);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(167, 561);
            this.kryptonPanel1.TabIndex = 14;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(20, 395);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(120, 52);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Values.Text = "History";
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
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToResizeColumns = false;
            this.dgvLogs.AllowUserToResizeRows = false;
            this.dgvLogs.Location = new System.Drawing.Point(238, 93);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(720, 450);
            this.dgvLogs.TabIndex = 15;
            this.dgvLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellClick);
            // 
            // StudentsReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "StudentsReturn";
            this.Text = "StudentsReturn";
            this.Load += new System.EventHandler(this.StudentsReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnHistory;
        private Krypton.Toolkit.KryptonButton btnBooks;
        private Krypton.Toolkit.KryptonButton btnAccounts;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonDataGridView dgvLogs;
    }
}