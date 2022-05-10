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
    public partial class ViewLogs : Form
    {
        private int bookid = StudentsReturn.bookid;
        private int idnumber = User_Admission.Login.idnumber;
        private string returndatetime = "";

        public ViewLogs()
        {
            InitializeComponent();
        }

        private void ViewLogs_Load(object sender, EventArgs e)
        {
            getBookInformation();
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
            returndatetime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");

            Connection.DB();
            Function.gen = "UPDATE logs SET returndatetime = '" + returndatetime + "' " +
                "WHERE bookid = '"+ bookid +"' AND idnumber = '"+ idnumber +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();

            Connection.DB();
            Function.gen = "UPDATE books SET availability = '" + "AVAILABLE" + "' " +
                " WHERE bookid = '"+ bookid +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();

            MessageBox.Show("Book returned.", "RETURNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
