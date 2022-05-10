using System.Collections;
using System.Data.SqlClient;

namespace E_Library.Students
{
    public partial class ViewCart : Form
    {
        private int cartid;
        private int idnumber = User_Admission.Login.idnumber;
        private int maxRows;
        private string borrowdatetime = "";
        private int bookid;

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
            Function.gen = "SELECT cart.bookid, cart.cartid, books.bookname AS [NAME], books.bookauthor AS [AUTHOR], books.booklocation AS [LOCATION] FROM cart INNER JOIN books ON cart.bookid = books.bookid WHERE cart.idnumber = '" + idnumber + "' ";
            Function.fill(Function.gen, dgvCart);
            dgvCart.Columns["cartid"].Visible = false;
            dgvCart.Columns["bookid"].Visible = false;
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
            maxRows = dgvCart.RowCount;
            borrowdatetime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");

            for (int i = 0; i < maxRows; i++)
            {
                bookid = Convert.ToInt32(dgvCart.Rows[i].Cells["bookid"].Value);
                insertToLogs();
            }

            deleteCart();

            new BorrowMessage().Show();
            Hide();
        }

        private void insertToLogs()
        {
            Connection.DB();
            Function.gen = "INSERT INTO logs(idnumber, bookid, borrowdatetime, returndatetime) " +
                "VALUES('" + idnumber + "', " +
                "'" + bookid + "', " +
                "'" + borrowdatetime + "', " +
                "'" + "PENDING" + "')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();

            Connection.DB();
            Function.gen = "UPDATE books SET availability = '"+ "NOT AVAILABLE" +"' " +
                "WHERE bookid = '"+ bookid +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();
        }

        private void deleteCart()
        {
            Connection.DB();
            Function.gen = "DELETE FROM cart WHERE idnumber = '" + idnumber + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            lblTEST.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }
    }
}
