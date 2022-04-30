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
    public partial class AdminAccount : Form
    {
        public AdminAccount()
        {
            InitializeComponent();
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            viewUserinformation();
        }

        private void viewUserinformation() {
            Connection.DB();
            Function.gen = "SELECT * FROM userinformation";
            Function.fill(Function.gen, dgvUserinformation);
        }
    }
}
