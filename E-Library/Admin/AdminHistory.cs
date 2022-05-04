using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Library.Admin
{
    public partial class AdminHistory : Form
    {
        public AdminHistory()
        {
            InitializeComponent();
        }

        private void AdminHistory_Load(object sender, EventArgs e)
        {
            viewHistory();
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

        private void viewHistory()
        {
            Connection.DB();
            Function.gen = "SELECT * FROM history";
            Function.fill(Function.gen, dgvHistory);
        }
    }
}
