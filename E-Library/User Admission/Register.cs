using System.Data.SqlClient;

namespace E_Library.User_Admission
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "INSERT INTO userinformation(role, idnumber, firstname, lastname, gender, year, course, contactnumber, email, address) " +
                "VALUES('" + "STUDENT" + "', " +
                "'" + txtIdnumber.Text + "', " +
                "'" + txtFirstname.Text + "', " +
                "'" + txtLastname.Text + "', " +
                "'" + cmbGender.Text + "', " +
                "'" + cmbYearlevel.Text + "', " +
                "'" + cmbCourse.Text + "', " +
                "'" + txtContactnumber.Text + "', " +
                "'" + txtEmail.Text + "', " +
                "'" + txtAddress.Text + "')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            var login = new Login();
            login.Show();
            Hide();
        }
    }
}
