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

namespace E_Library.Students
{
    public partial class StudentsBooks : Form
    {
        private PictureBox pic = new PictureBox();
        private Label name;
        private Label author;
        private Label availability;
        private Label location;

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
                if (Convert.ToInt32(Function.reader["quantity"]) > 0)
                {
                    long len = Function.reader.GetBytes(4, 0, null, 0, 0);
                    byte[] array = new byte[Convert.ToInt32(len + 1)];
                    Function.reader.GetBytes(4, 0, array, 0, Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 290;
                    pic.Height = 300;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    pic.Tag = Function.reader["productid"].ToString();

                    name = new Label();
                    author = new Label();
                    availability = new Label();
                    location = new Label();

                    name.Text = Function.reader["productname"].ToString();
                    name.BackColor = Color.FromArgb(46, 134, 222);
                    name.Font = new Font("Arial", 24, FontStyle.Bold);
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    name.Dock = DockStyle.Bottom;
                    name.Height = 40;
                    name.Tag = Function.reader["productname"].ToString();

                    author.Text = "P" + Function.reader["productauthor"].ToString() + ".00";
                    author.ForeColor = Color.White;
                    author.Font = new Font("Arial", 24, FontStyle.Bold);
                    author.BackColor = Color.FromArgb(113, 1, 147);
                    author.Dock = DockStyle.Bottom;
                    author.Width = 70;
                    author.Height = 40;
                    author.Tag = Function.reader["productauthor"].ToString();

                    location.Text = Function.reader["location"].ToString() + " qty.";
                    location.ForeColor = Color.White;
                    location.Font = new Font("Arial", 24);
                    location.BackColor = Color.FromArgb(113, 1, 147);
                    location.Dock = DockStyle.Bottom;
                    location.Width = 70;
                    location.Height = 40;

                    availability.Text = Function.reader["availability"].ToString() + " qty.";
                    availability.ForeColor = Color.White;
                    availability.Font = new Font("Arial", 24);
                    availability.BackColor = Color.FromArgb(113, 1, 147);
                    availability.Dock = DockStyle.Bottom;
                    availability.Width = 70;
                    availability.Height = 40;

                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;
                    pic.Controls.Add(name);
                    pic.Controls.Add(author);
                    pic.Controls.Add(location);
                    pic.Controls.Add(availability);
                    flBooks.Controls.Add(pic);

                    pic.Click += new EventHandler(OnClick);
                }
            }

            flBooks.AutoScroll = true;
            Connection.con.Close();
        }

        public void OnClick(object sender, EventArgs e)
        {
            try
            {
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
