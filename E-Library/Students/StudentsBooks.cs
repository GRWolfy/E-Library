using System.Data.SqlClient;

namespace E_Library.Students
{
    public partial class StudentsBooks : Form
    {
        private PictureBox pic = new PictureBox();
        private Label name;
        private Label author;
        private Label availability;
        private Label location;
        private int idnumber = User_Admission.Login.idnumber;
        private int bookid;

        public StudentsBooks()
        {
            InitializeComponent();
        }

        private void StudentsBooks_Load(object sender, EventArgs e)
        {
            viewBooks();
        }
        private void viewBooks()
        {
            flBooks.Controls.Clear();

            Connection.DB();
            Function.gen = "SELECT * FROM books WHERE bookname LIKE '" + txtSearchbook.Text + "%' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            while (Function.reader.Read())
            {
                if (Function.reader["availability"].ToString().Equals("AVAILABLE"))
                {
                    long len = Function.reader.GetBytes(5, 0, null, 0, 0);
                    byte[] array = new byte[Convert.ToInt32(len + 1)];
                    Function.reader.GetBytes(5, 0, array, 0, Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 300;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    pic.Tag = Function.reader["bookid"].ToString();

                    name = new Label();
                    author = new Label();
                    availability = new Label();
                    location = new Label();

                    name.Text = Function.reader["bookname"].ToString();
                    name.BackColor = Color.FromArgb(46, 134, 222);
                    name.Font = new Font("Arial", 24, FontStyle.Bold);
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    name.Dock = DockStyle.Bottom;
                    name.Height = 40;
                    name.Tag = Function.reader["bookid"].ToString();

                    author.Text = "P" + Function.reader["bookauthor"].ToString();
                    author.ForeColor = Color.White;
                    author.Font = new Font("Arial", 24, FontStyle.Bold);
                    author.BackColor = Color.FromArgb(113, 1, 147);
                    author.Dock = DockStyle.Bottom;
                    author.Width = 70;
                    author.Height = 40;
                    author.Tag = Function.reader["bookid"].ToString();

                    location.Text = Function.reader["booklocation"].ToString();
                    location.ForeColor = Color.White;
                    location.Font = new Font("Arial", 24);
                    location.BackColor = Color.FromArgb(113, 1, 147);
                    location.Dock = DockStyle.Bottom;
                    location.Width = 70;
                    location.Height = 40;
                    location.Tag = Function.reader["bookid"].ToString();

                    availability.Text = Function.reader["availability"].ToString();
                    availability.ForeColor = Color.White;
                    availability.Font = new Font("Arial", 24);
                    availability.BackColor = Color.FromArgb(113, 1, 147);
                    availability.Dock = DockStyle.Right;
                    availability.Width = 70;
                    availability.Height = 40;
                    availability.Tag = Function.reader["bookid"].ToString();

                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;
                    name.Controls.Add(author);
                    name.Controls.Add(location);
                    name.Controls.Add(availability);
                    flBooks.Controls.Add(pic);
                    flBooks.Controls.Add(name);

                    pic.Click += new EventHandler(OnClick);
                }
            }

            flBooks.AutoScroll = true;
            Connection.con.Close();
        }

        public void OnClick(object sender, EventArgs e)
        {
            bookid = Convert.ToInt32(((PictureBox)sender).Tag);
            var gen = MessageBox.Show("Do you want to add this book to cart?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
                Connection.DB();
                Function.gen = "INSERT INTO cart(idnumber, bookid)" +
                    "VALUES('" + idnumber + "'," +
                    "'" + bookid + "') ";
                Function.command = new SqlCommand(Function.gen, Connection.con);
                Function.command.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("Book added to cart.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new StudentsBooks().Show();
            Hide();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new StudentsProfile().Show();
            Hide();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            new ViewCart().Show();
            Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            new StudentsReturn().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new User_Admission.Login().Show();
            Hide();
        }
    }
}
