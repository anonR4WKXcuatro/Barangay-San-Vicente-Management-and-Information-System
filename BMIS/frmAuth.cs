using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmAuth : Form
    {
        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public frmAuth()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            txtPassword.UseSystemPasswordChar = true;
        }
        private void Authenticate()
        {
            MySqlDataReader Reader;
            frmSettings settings = new frmSettings();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int role = 2;

            Console.WriteLine("Connection Pool Open!");
            using (var connection = new MySqlConnection("server=localhost; port=3306; user=root; password=admin123; database=bmis_db"))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM credentials WHERE BINARY username=@username AND BINARY password=@password AND BINARY role=@role", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@role", role);
                        Reader = command.ExecuteReader();
                        if (Reader.Read())
                        {
                            settings.ShowDialog();
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials, Please try again!", "Authentication Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            Dispose();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    { }
                    connection.Close();
                    Console.WriteLine("Connection Pool Closed!");
                }
            }
        }
       
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }
        private void btnAccess_Click(object sender, EventArgs e)
        {
            Authenticate();
        }     
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
