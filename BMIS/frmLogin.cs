using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        private void Authenticate()
        {
            var i = new Person
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };
            using (var connection = new MySqlConnection("server=localhost; port=3306; user=root; password=admin123; database=bmis_db"))
            {
                Console.WriteLine("Connection Pool Open!");
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM credentials WHERE BINARY username=@username AND BINARY password=@password", connection))
                {
                    MySqlDataReader Reader;
                    try
                    {
                        command.Parameters.AddWithValue("@username", i.Username);
                        command.Parameters.AddWithValue("@password", i.Password);
                        Reader = command.ExecuteReader();
                        if (Reader.Read())
                        {
                            Hide();
                            frmLoadingScreen splashscreen = new frmLoadingScreen();
                            splashscreen.ShowDialog();
                        }
                        else if (string.IsNullOrEmpty(i.Username) && string.IsNullOrEmpty(i.Password))
                        {
                            label6.Show(); label7.Show();
                        }
                        else if (string.IsNullOrEmpty(i.Username))
                        {
                            label6.Show(); label7.Hide();
                        }
                        else if (string.IsNullOrEmpty(i.Password))
                        {
                            label7.Show(); label6.Hide();
                        }
                        else
                        {
                            label6.Hide(); label7.Hide();
                            MessageBox.Show("Invalid Credentials, Please try again!", "Authentication Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //If password field is empty, the eye button will not visible
            btnShowHidePassword.Visible = !string.IsNullOrWhiteSpace(txtPassword.Text);
        }
        private void btnShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide your password field
            if (btnShowHidePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }

}