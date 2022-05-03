namespace E_Library.Admin
{
    partial class AdminDashboard
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn);
            this.kryptonPanel1.Controls.Add(this.btnBooks);
            this.kryptonPanel1.Controls.Add(this.btnAccounts);
            this.kryptonPanel1.Controls.Add(this.btnLogout);
            this.kryptonPanel1.Controls.Add(this.btnDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 21);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(167, 561);
            this.kryptonPanel1.TabIndex = 2;
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
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonButton btnDashboard;
        private Krypton.Toolkit.KryptonButton btnAccounts;
        private Krypton.Toolkit.KryptonButton btn;
        private Krypton.Toolkit.KryptonButton btnBooks;
    }
}