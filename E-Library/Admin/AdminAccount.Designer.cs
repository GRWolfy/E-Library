namespace E_Library.Admin
{
    partial class AdminAccount
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
            this.dgvUserinformation = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserinformation
            // 
            this.dgvUserinformation.Location = new System.Drawing.Point(87, 67);
            this.dgvUserinformation.Name = "dgvUserinformation";
            this.dgvUserinformation.RowTemplate.Height = 25;
            this.dgvUserinformation.Size = new System.Drawing.Size(570, 263);
            this.dgvUserinformation.TabIndex = 0;
            // 
            // AdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUserinformation);
            this.Name = "AdminAccount";
            this.Text = "AdminAccount";
            this.Load += new System.EventHandler(this.AdminAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserinformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvUserinformation;
    }
}