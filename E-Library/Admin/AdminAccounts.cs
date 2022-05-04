using System.Data.SqlClient;

namespace E_Library.Admin
{
    public partial class AdminAccounts : Form
    {
        public AdminAccounts()
        {
            InitializeComponent();
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            viewUserinformation();
        }

        private void viewUserinformation()
        {
            Connection.DB();
            Function.gen = "SELECT picture, password, role AS ROLE, idnumber AS [ID NUMBER], firstname AS [FIRST NAME], lastname AS [LAST NAME], gender AS GENDER, yearlevel AS [YEAR LEVEL], course AS COURSE, contactnumber as [CONTACT NUMBER], email as EMAIL, address as ADDRESS FROM users";
            Function.fill(Function.gen, dgvAccounts);
            dgvAccounts.Columns["picture"].Visible = false;
            dgvAccounts.Columns["password"].Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "INSERT INTO users(idnumber, role, firstname, lastname, gender, yearlevel, course, email, address, contactnumber, password) " +
                "VALUES('" + txtIdnumber.Text + "', " +
                "'" + cmbRole.Text + "', " +
                "'" + txtFirstname.Text + "', " +
                "'" + txtLastname.Text + "', " +
                "'" + cmbGender.Text + "', " +
                "'" + cmbYearlevel.Text + "', " +
                "'" + cmbCourse.Text + "', " +
                "'" + txtEmail.Text + "', " +
                "'" + txtAddress.Text + "', " +
                "'" + txtContactnumber.Text + "', " +
                "'" + txtPassword.Text + "')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "UPDATE users SET role = '" + cmbRole.Text + "', " +
                "firstname = '" + txtFirstname.Text + "', " +
                "lastname = '" + txtLastname.Text + "', " +
                "gender = '" + cmbGender.Text + "', " +
                "yearlevel = '" + cmbYearlevel.Text + "', " +
                "course = '" + cmbCourse.Text + "', " +
                "contactnumber = '" + txtContactnumber.Text + "', " +
                "email = '" + txtEmail.Text + "', " +
                "address = '" + txtAddress.Text + "', " +
                "password = '" + txtPassword.Text + "' " +
                "WHERE idnumber = '" + txtIdnumber.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
                Function.gen = "DELETE FROM users WHERE idnumber = '" + txtIdnumber.Text + "' ";
                Function.command = new SqlCommand(Function.gen, Connection.con);
                Function.command.ExecuteNonQuery();
                Connection.con.Close();
            }
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvAccounts.Rows[e.RowIndex].Cells["id"].Value);
            cmbRole.Text = dgvAccounts.Rows[e.RowIndex].Cells["ROLE"].Value.ToString();
            txtIdnumber.Text = dgvAccounts.Rows[e.RowIndex].Cells["ID NUMBER"].Value.ToString();
            txtFirstname.Text = dgvAccounts.Rows[e.RowIndex].Cells["FIRST NAME"].Value.ToString();
            txtLastname.Text = dgvAccounts.Rows[e.RowIndex].Cells["LAST NAME"].Value.ToString();
            cmbGender.Text = dgvAccounts.Rows[e.RowIndex].Cells["GENDER"].Value.ToString();
            cmbYearlevel.Text = dgvAccounts.Rows[e.RowIndex].Cells["YEAR"].Value.ToString();
            cmbCourse.Text = dgvAccounts.Rows[e.RowIndex].Cells["COURSE"].Value.ToString();
            txtContactnumber.Text = dgvAccounts.Rows[e.RowIndex].Cells["CONTACT NUMBER"].Value.ToString();
            txtEmail.Text = dgvAccounts.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString();
            txtAddress.Text = dgvAccounts.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString();

        }

        private void doResetFields()
        {
            Hide();
            Show();
            tcAccounts.SelectedIndex = 0;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            var books = new AdminBooks();
            books.Show();
            Hide();
        }
    }
}

/*
 id
 role
 idnumber
 firstname
 lastname
 gender 
 year
 course
 contactnumber
 email
 address
 */
