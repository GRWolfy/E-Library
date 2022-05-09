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
    public partial class ViewCart : Form
    {
        private int cartid;
        private int idnumber = User_Admission.Login.idnumber;

        public ViewCart()
        {
            InitializeComponent();
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            viewCart();
        }

        private void viewCart()
        {
            Connection.DB();
            Function.gen = "SELECT cart.cartid, books.bookname AS [NAME], books.bookauthor AS [AUTHOR], books.booklocation AS [LOCATION] FROM cart INNER JOIN books ON cart.bookid = books.bookid WHERE cart.idnumber = '"+ idnumber +"' ";
            Function.fill(Function.gen, dgvCart);
            dgvCart.Columns["cartid"].Visible = false;
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cartid = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["cartid"].Value);
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this book from cart?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
                Function.gen = "DELETE FROM cart WHERE cartid = '" + cartid + "' ";
                Function.command = new SqlCommand(Function.gen, Connection.con);
                Function.command.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("DELETED", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }

        private void btnProceedBorrow_Click(object sender, EventArgs e)
        {
            new BorrowMessage().Show();
            Hide();
        }
    }
}
