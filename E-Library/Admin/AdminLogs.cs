using System.Data.SqlClient;

namespace E_Library.Admin
{
    public partial class AdminLogs : Form
    {
        private int bookid;
        private int idnumber = User_Admission.Login.idnumber;
        private string returndatetime = "";

        public AdminLogs()
        {
            InitializeComponent();
        }

        private void AdminHistory_Load(object sender, EventArgs e)
        {
            viewLogs();
            viewPendingBooks();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            Hide();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new AdminAccounts().Show();
            Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new AdminBooks().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new User_Admission.Login().Show();
            Hide();
        }

        private void viewLogs()
        {
            Connection.DB();
            Function.gen = "SELECT (users.firstname + ' ' + users.lastname) AS [BORROWER], " +
                "users.yearlevel AS [YEAR LEVEL], " +
                "users.course AS [COURSE], " +
                "books.bookname AS [BOOK NAME], " +
                "logs.borrowdatetime AS [BORROW TIME]," +
                "logs.returndatetime AS [RETURN TIME] " +
                "FROM logs INNER JOIN books ON logs.bookid = books.bookid " +
                "INNER JOIN users ON logs.idnumber = users.idnumber";
            Function.fill(Function.gen, dgvLogs);
        }

        private void viewPendingBooks()
        {
            Connection.DB();
            Function.gen = "SELECT logs.idnumber, logs.bookid, (users.firstname + ' ' + users.lastname) AS [BORROWER], " +
                "users.yearlevel AS [YEAR LEVEL], " +
                "users.course AS [COURSE], " +
                "books.bookname AS [BOOK NAME], " +
                "logs.borrowdatetime AS [BORROW TIME]," +
                "logs.returndatetime AS [RETURN TIME] " +
                "FROM logs INNER JOIN books ON logs.bookid = books.bookid " +
                "INNER JOIN users ON users.idnumber = logs.idnumber " +
                "WHERE logs.returndatetime = 'NEED CONFIRMATION' ";
            Function.fill(Function.gen, dgvPendingBooks);
            dgvPendingBooks.Columns["bookid"].Visible = false;
            dgvPendingBooks.Columns["idnumber"].Visible = false;
        }

        private void dgvPendingBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dgvPendingBooks.Rows[e.RowIndex].Cells["bookid"].Value);
            returndatetime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
            idnumber = Convert.ToInt32(dgvPendingBooks.Rows[e.RowIndex].Cells["idnumber"].Value);

            var gen = MessageBox.Show("Book received?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
                updateLogs();
                updateBookAvailability();

                MessageBox.Show("Book returned.", "RETURNED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var temp = new AdminLogs();
                temp.Show();
                temp.tcLogs.SelectedIndex = 0;
            }
        }

        private void updateLogs()
        {
            Connection.DB();
            Function.gen = "UPDATE logs SET returndatetime = '" + returndatetime + "' " +
                "WHERE bookid = '" + bookid + "' AND idnumber = '" + idnumber + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();
        }

        private void updateBookAvailability()
        {
            Connection.DB();
            Function.gen = "UPDATE books SET availability = '" + "AVAILABLE" + "' " +
                " WHERE bookid = '" + bookid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();
        }
    }
}
