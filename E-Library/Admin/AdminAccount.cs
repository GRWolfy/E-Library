using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Library.Admin
{
    public partial class AdminAccount : Form
    {
        private int id;
        public AdminAccount()
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
            Function.gen = "SELECT id, picture, role AS ROLE, idnumber AS [ID NUMBER], firstname AS [FIRST NAME], lastname AS [LAST NAME], gender AS GENDER, year AS YEAR, course AS COURSE, contactnumber as [CONTACT NUMBER], email as EMAIL, address as ADDRESS FROM userinformation";
            Function.fill(Function.gen, dgvAccounts);
            dgvAccounts.Columns["picture"].Visible = false;
            dgvAccounts.Columns["id"].Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "INSERT INTO userinformation(role, idnumber, firstname, lastname, gender, year, course, contactnumber, email, address) " +
                "VALUES('" + cmbRole.Text + "', " +
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "UPDATE userinformation SET idnumber = '" + txtIdnumber.Text + "', " +
                "firstname = '" + txtFirstname.Text + "', " +
                "lastname = '" + txtLastname.Text + "', " +
                "gender = '" + cmbGender.Text + "', " +
                "year = '" + cmbYearlevel.Text + "', " +
                "course = '" + cmbCourse.Text + "', " +
                "contactnumber = '" + txtContactnumber.Text + "', " +
                "email = '" + txtEmail.Text + "', " +
                "address = '" + txtAddress.Text + "' " +
                "WHERE id = '" + id + "' ";
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
                Function.gen = "DELETE FROM userinformation WHERE id = '" + id + "' ";
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
            cmbYearlevel.Text  = dgvAccounts.Rows[e.RowIndex].Cells["YEAR"].Value.ToString();
            cmbCourse.Text = dgvAccounts.Rows[e.RowIndex].Cells["COURSE"].Value.ToString();
            txtContactnumber.Text = dgvAccounts.Rows[e.RowIndex].Cells["CONTACT NUMBER"].Value.ToString();
            txtEmail.Text = dgvAccounts.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString();
            txtAddress.Text = dgvAccounts.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString();

        }

        private void doResetFields()
        {
            Hide();
            Show();
            tcAccounts.SelectedIndex =  0;
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
