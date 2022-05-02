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
            var account = new AdminAccount();
            account.Show();
            Hide();
        }
    }
}
