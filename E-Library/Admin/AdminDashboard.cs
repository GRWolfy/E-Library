namespace E_Library.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            var account = new AdminAccounts();
            account.Show();
            Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            var books = new AdminBooks();
            books.Show();
            Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            new AdminLogs().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new User_Admission.Login().Show();
            Hide();
        }
    }
}
