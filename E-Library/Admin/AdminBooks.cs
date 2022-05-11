using System.Data.SqlClient;

namespace E_Library.Admin
{
    public partial class AdminBooks : Form
    {
        private int bookid;
        private string imagelocation = "";

        public AdminBooks()
        {
            InitializeComponent();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new AdminAccounts().Show();
            Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            Hide();
        }

        private void AdminBooks_Load(object sender, EventArgs e)
        {
            viewBooks();
            showManageButtons(false);
        }

        private void viewBooks()
        {
            Connection.DB();
            Function.gen = "SELECT picture, bookid, bookname AS [NAME], bookauthor AS [AUTHOR], booklocation as [LOCATION], availability AS AVAILABILITY FROM books";
            Function.fill(Function.gen, dgvBooks);
            dgvBooks.Columns["bookid"].Visible = false;
            dgvBooks.Columns["picture"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
                Function.gen = "DELETE FROM books WHERE bookid = '" + bookid + "' ";
                Function.command = new SqlCommand(Function.gen, Connection.con);
                Function.command.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("DELETED", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                showManageButtons(false);
                doResetFields();
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["bookid"].Value);
            txtBookname.Text = dgvBooks.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            txtBookauthor.Text = dgvBooks.Rows[e.RowIndex].Cells["AUTHOR"].Value.ToString();
            txtBooklocation.Text = dgvBooks.Rows[e.RowIndex].Cells["LOCATION"].Value.ToString();
            byte[] img = (byte[])(dgvBooks.Rows[e.RowIndex].Cells["picture"].Value);

            if (img == null)
            {
                pbBook.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pbBook.Image = Image.FromStream(ms);
            }

            tcBooks.SelectedIndex = 1;
            showManageButtons(true);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "INSERT INTO books(bookname, bookauthor, booklocation, availability, picture)" +
                "VALUES('" + txtBookname.Text + "', " +
                "'" + txtBookauthor.Text + "', " +
                "'" + txtBooklocation.Text + "', " +
                "'" + "AVAILABLE" + "'," +
                " @img ) ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Book Added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            showManageButtons(false);
            doResetFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Connection.DB();
            Function.gen = "UPDATE books SET bookname = '" + txtBookname.Text + "', " +
                "bookauthor = '" + txtBookauthor.Text + "' " +
                "WHERE bookid = '" + bookid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            showManageButtons(false);
            doResetFields();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dlg.FileName.ToString();
                pbBook.ImageLocation = imagelocation;
            }
        }

        private void btnUpdatepic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dlg.FileName.ToString();
                pbBook.ImageLocation = imagelocation;
            }

            byte[] img = null;
            FileStream fs = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "UPDATE books SET picture = @img WHERE bookid = '" + bookid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            new AdminLogs().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new User_Admission.Login().Show();
            Hide();
        }

        private void showManageButtons(bool value)
        {
            btnBrowse.Visible = value ? false : true;
            btnSave.Visible = value ? false : true;
            btnUpdate.Visible = value;
            btnUpdatepic.Visible = value;
            btnDelete.Visible = value;
        }

        private void doResetFields()
        {
            var temp = new AdminBooks();
            temp.Show();
            temp.tcBooks.SelectedIndex = 0;
            Hide();

        }
    }
}
