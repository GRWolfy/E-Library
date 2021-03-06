using System.Data.SqlClient;

namespace E_Library.User_Admission
{
    public partial class Login : Form
    {
        public static string role = "";
        public static int idnumber;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "SELECT * FROM users WHERE idnumber = '" + txtIdnumber.Text + "' AND password = '" + txtPassword.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
                Function.reader.Read();
                role = Function.reader["role"].ToString();
                idnumber = Convert.ToInt32(Function.reader["idnumber"]);

                if (role.Equals("ADMIN"))
                {
                    var admin = new Admin.AdminDashboard();
                    admin.Show();
                    Hide();
                }
                else if (role.Equals("STUDENT"))
                {
                    var student = new Students.StudentsDashboard();
                    student.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect idnumber or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void hlToRegister_LinkClicked(object sender, EventArgs e)
        {
            new Register().Show();
            Hide();
        }
    }
}
