using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Library.Students
{
    public partial class ViewBook : Form
    {
        public static string directory = "";
        private int bookid;
        private int idnumber = User_Admission.Login.idnumber;

        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewLogs_Load(object sender, EventArgs e)
        {
            selectDirectory();
            getBookInformation();
        }

        private void selectDirectory() 
        {
            if (directory.Equals("RETURN"))
            {
                bookid = StudentsReturn.bookid;
                btnReturn.Visible = true;
                btnAddtocart.Visible = false;
            }
            else if (directory.Equals("CART"))
            {
                bookid = StudentsBooks.bookid;
                btnReturn.Visible = false;
                btnAddtocart.Visible = true;
            }
        }

        private void getBookInformation()
        {
            Connection.DB();
            Function.gen = "SELECT * FROM books WHERE bookid = '" + bookid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
                Function.reader.Read();
                lblTitle.Text = Function.reader["bookname"].ToString();
                lblAuthor.Text = Function.reader["bookauthor"].ToString();
                byte[] img = (byte[])(Function.reader[5]);

                if (img == null)
                {
                    pbBook.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pbBook.Image = Image.FromStream(ms);
                }
            }

            pbBook.BackgroundImageLayout = ImageLayout.Stretch;
            Connection.con.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "UPDATE logs SET returndatetime = '" + "NEED CONFIRMATION" + "' " +
                "WHERE bookid = '"+ bookid +"' AND idnumber = '"+ idnumber +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();
            MessageBox.Show("Wait for the confirmation.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new StudentsReturn().Show();
            Hide();
        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "SELECT * FROM cart WHERE bookid = '" + bookid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
                MessageBox.Show("Book already added in cart.");
            }
            else
            {
                Function.reader.Read();
                Connection.DB();
                Function.gen = "INSERT INTO cart(idnumber, bookid)" +
                    "VALUES('" + idnumber + "'," +
                    "'" + bookid + "') ";
                Function.command = new SqlCommand(Function.gen, Connection.con);
                Function.command.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("Book added to cart.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
        }
    }
}
