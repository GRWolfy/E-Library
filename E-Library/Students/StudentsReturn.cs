using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Library.Students
{
    public partial class StudentsReturn : Form
    {
        private int idnumber = User_Admission.Login.idnumber;
        public static int bookid;

        public StudentsReturn()
        {
            InitializeComponent();
        }

        private void StudentsReturn_Load(object sender, EventArgs e)
        {
            viewLogs();
        }

        private void viewLogs()
        {
            Connection.DB();
            Function.gen = "SELECT logs.bookid, books.bookname AS [NAME], books.bookauthor AS [AUTHOR], logs.borrowdatetime AS [BORROW TIME], logs.returndatetime AS [RETURN TIME] FROM logs INNER JOIN books ON logs.bookid = books.bookid WHERE logs.idnumber = '"+ idnumber +"' ";
            Function.fill(Function.gen, dgvLogs);
            dgvLogs.Columns["bookid"].Visible = false;
        }

        private void dgvLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dgvLogs.Rows[e.RowIndex].Cells["bookid"].Value.ToString());
            ViewBook.directory = "RETURN";
            new ViewBook().Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new User_Admission.Login().Show();
            Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new StudentsProfile().Show();
            Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new StudentsDashboard().Show();
            Hide();
        }
    }
}
