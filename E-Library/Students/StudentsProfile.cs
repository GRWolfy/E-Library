using System.Data.SqlClient;

namespace E_Library.Students
{
    public partial class StudentsProfile : Form
    {
        private int idnumber = User_Admission.Login.idnumber;

        public StudentsProfile()
        {
            InitializeComponent();
        }

        private void StudentsProfile_Load(object sender, EventArgs e)
        {
            getUserinformation();
        }

        private void getUserinformation()
        {
            Connection.DB();
            Function.gen = "SELECT * FROM users WHERE idnumber = '" + idnumber + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
                Function.reader.Read();
                txtFirstname.Text = Function.reader["firstname"].ToString();
                txtLastname.Text = Function.reader["lastname"].ToString();
                cmbGender.Text = Function.reader["gender"].ToString();
                cmbYearlevel.Text = Function.reader["yearlevel"].ToString();
                cmbCourse.Text = Function.reader["course"].ToString();
                txtEmail.Text = Function.reader["email"].ToString();
                txtContactnumber.Text = Function.reader["contactnumber"].ToString();
                txtPassword.Text = txtConfirmpassword.Text = Function.reader["password"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "UPDATE users SET password = '" + txtPassword.Text + "', " +
                "firstname = '" + txtFirstname.Text + "', " +
                "lastname = '" + txtLastname.Text + "', " +
                "gender = '" + cmbGender.Text + "', " +
                "yearlevel = '" + cmbYearlevel.Text + "', " +
                "course = '" + cmbCourse.Text + "', " +
                "contactnumber = '" + txtContactnumber.Text + "', " +
                "email = '" + txtEmail.Text + "', " +
                "address = '" + txtAddress.Text + "', " +
                "password = '" + txtPassword.Text + "' " +
                "WHERE idnumber = '" + idnumber + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new StudentsDashboard().Show();
            Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }
    }
}
