namespace E_Library.Students
{
    partial class ViewBook
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
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.btnReturn = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.lblAuthor = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.btnAddtocart = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBook
            // 
            this.pbBook.Location = new System.Drawing.Point(38, 56);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(192, 262);
            this.pbBook.TabIndex = 0;
            this.pbBook.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(447, 357);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 25);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Values.Text = "Return";
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(308, 118);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Title: ";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(412, 118);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(6, 2);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Values.Text = "";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(412, 171);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(6, 2);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Values.Text = "";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(308, 171);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Author: ";
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Location = new System.Drawing.Point(328, 357);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(90, 25);
            this.btnAddtocart.TabIndex = 6;
            this.btnAddtocart.Values.Text = "Add to cart";
            this.btnAddtocart.Visible = false;
            this.btnAddtocart.Click += new System.EventHandler(this.btnAddtocart_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pbBook);
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLogs";
            this.Load += new System.EventHandler(this.ViewLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbBook;
        private Krypton.Toolkit.KryptonButton btnReturn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonLabel lblAuthor;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton btnAddtocart;
    }
}