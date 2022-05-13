namespace E_Library.Students
{
    partial class ViewCart
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
            this.dgvCart = new Krypton.Toolkit.KryptonDataGridView();
            this.btnProceedBorrow = new Krypton.Toolkit.KryptonButton();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.Location = new System.Drawing.Point(112, 38);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 25;
            this.dgvCart.Size = new System.Drawing.Size(757, 432);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // btnProceedBorrow
            // 
            this.btnProceedBorrow.Location = new System.Drawing.Point(649, 528);
            this.btnProceedBorrow.Name = "btnProceedBorrow";
            this.btnProceedBorrow.Size = new System.Drawing.Size(90, 25);
            this.btnProceedBorrow.TabIndex = 1;
            this.btnProceedBorrow.Values.Text = "Borrow books";
            this.btnProceedBorrow.Click += new System.EventHandler(this.btnProceedBorrow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Values.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProceedBorrow);
            this.Controls.Add(this.dgvCart);
            this.Name = "ViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCart";
            this.Load += new System.EventHandler(this.ViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvCart;
        private Krypton.Toolkit.KryptonButton btnProceedBorrow;
        private Krypton.Toolkit.KryptonButton btnBack;
    }
}