namespace E_Library.Students
{
    public partial class StudentsDashboard : Form
    {
        public StudentsDashboard()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new StudentsProfile().Show();
            Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new StudentsReturn().Show();
            Hide();
        }
    }
}
