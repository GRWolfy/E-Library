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

namespace E_Library.Admin
{
    public partial class AdminBooks : Form
    {
        private int bookid;

        public AdminBooks()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new AdminAccounts().Show();
            Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            Hide();
        }

        private void AdminBooks_Load(object sender, EventArgs e)
        {
            viewBooks();
        }

        private void viewBooks()
        {
            Connection.DB();
            Function.gen = "SELECT bookid, bookname AS [BOOK NAME], bookauthor AS [BOOK AUTHOR], availability AS AVAILABILITY FROM books";
            Function.fill(Function.gen, dgvBooks);
            dgvBooks.Columns["bookid"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
                Function.gen = "DELETE FROM books WHERE bookid = '" + bookid + "' ";
                Function.command = new SqlCommand(Function.gen, Connection.con);
                Function.command.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("DELETED", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["bookid"].Value);
            txtBookname.Text = dgvBooks.Rows[e.RowIndex].Cells["BOOK NAME"].Value.ToString();
            txtBookauthor.Text = dgvBooks.Rows[e.RowIndex].Cells["BOOK AUTHOR"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "INSERT INTO books(bookname, bookauthor, availability)" +
                "VALUES('" + txtBookname.Text + "', " +
                "'" + txtBookauthor.Text + "', " +
                "'" + "AVAILABLE" + "') ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Book Added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "UPDATE books SET bookname = '" + txtBookname.Text + "', " +
                "bookauthor = '" + txtBookauthor.Text + "' " +
                "WHERE bookid = '" + bookid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
        }
    }
}
