namespace E_Library.Students
{
    public partial class BorrowMessage : Form
    {
        public BorrowMessage()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }
    }
}
