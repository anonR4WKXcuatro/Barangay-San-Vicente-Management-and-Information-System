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
            frmMainWindow mainWindow = new frmMainWindow();
            var user = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };
            bool verify = user.Login_Verification();
            if (verify)
            {
                int role = user.Role;
                if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    label6.Show(); label7.Show();
                }
                else if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    label6.Show(); label7.Hide();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    label7.Show(); label6.Hide();
                }
                else if (role == 1)
                {
                    Hide();
                    mainWindow.lblPosition.Text = "Brgy. Secretary";
                    mainWindow.Show();
                }
                else if (role == 2)
                {
                    Hide();
                    mainWindow.lblPosition.Text = "Brgy. Captain";
                    mainWindow.Show();
                }
                else
                {
                    label6.Hide(); label7.Hide();
                    MessageBox.Show("Invalid Credentials, Please try again!", "Authentication Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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