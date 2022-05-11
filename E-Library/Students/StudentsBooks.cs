using System.Data.SqlClient;

namespace E_Library.Students
{
    public partial class StudentsBooks : Form
    {
        private PictureBox pic = new PictureBox();
        private int idnumber = User_Admission.Login.idnumber;
        public static int bookid;

        public StudentsBooks()
        {
            InitializeComponent();
        }

        private void StudentsBooks_Load(object sender, EventArgs e)
        {
            viewBooks();
        }
        private void viewBooks()
        {
            Connection.DB();
            Function.gen = "SELECT bookid, bookname AS [NAME]," +
                "bookauthor AS [AUTHOR]," +
                "booklocation AS [LOCATION] FROM books WHERE availability = 'available' ";
            Function.fill(Function.gen, dgvBooks);
            dgvBooks.Columns["bookid"].Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new StudentsProfile().Show();
            Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            new ViewCart().Show();
            Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            new StudentsReturn().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new User_Admission.Login().Show();
            Hide();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["bookid"].Value.ToString());
            ViewBook.directory = "VIEW";
            new ViewBook().Show();
        }
    }
}
