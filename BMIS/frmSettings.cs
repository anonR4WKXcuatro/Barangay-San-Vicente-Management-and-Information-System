using MySql.Data.MySqlClient;
using System;

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmSettings : Form
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
        public frmSettings()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void UpdateCaptainName()
        {
            int id = 2;
            string name = txtCaptainName.Text;

            using (var connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine("Connection Pool Open!");
                connection.Open();
                using (var command = new MySqlCommand("UPDATE officials SET offic_name = @captName WHERE offic_id = @captID", connection))
                {
                    command.Parameters.AddWithValue("@captID", id);
                    command.Parameters.AddWithValue("@captName", name);
                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {

                        }
                        else
                        {

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
        private void UpdateSecretaryName()
        {
            int id = 1;
            string name = txtSecretaryName.Text;

            using (var connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine("Connection Pool Open!");
                connection.Open();
                using (var command = new MySqlCommand("UPDATE officials SET offic_name = @secName WHERE offic_id = @secID", connection))
                {
                    command.Parameters.AddWithValue("@secID", id);
                    command.Parameters.AddWithValue("@secName", name);
                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {

                        }
                        else
                        {

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
        private void UpdateCaptainPassword()
        {
            int captainID = 2;
            string password = txtCaptainPassword.Text;

            using (var connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine("Connection Pool Open!");
                connection.Open();
                using (var command = new MySqlCommand("UPDATE credentials SET password = @captainPassword WHERE id = @captainID", connection))
                {
                    command.Parameters.AddWithValue("@captainID", captainID);
                    command.Parameters.AddWithValue("@captainPassword", password);
                    try
                    {


                        if (command.ExecuteNonQuery() > 0)
                        {

                        }

                        else
                        {

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
        private void UpdateSecretaryPassword()
        {
            int secretaryID = 1;
            string password = txtSecretaryPassword.Text;

            using (var connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine("Connection Pool Open!");
                connection.Open();
                using (var command = new MySqlCommand("UPDATE credentials SET password = @secretaryPassword WHERE id = @secretaryID", connection))
                {
                    command.Parameters.AddWithValue("@secretaryID", secretaryID);
                    command.Parameters.AddWithValue("@secretaryPassword", password);
                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {

                        }

                        else
                        {

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

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCaptainName.Text) || string.IsNullOrEmpty(txtSecretaryName.Text)
                || string.IsNullOrEmpty(txtCaptainPassword.Text) || string.IsNullOrEmpty(txtSecretaryPassword.Text))
                {
                    MessageBox.Show("Please fill up the remaining fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateCaptainName();
                    UpdateSecretaryName();
                    UpdateSecretaryPassword();
                    UpdateCaptainPassword();
                    MessageBox.Show("Success!, Please restart the application to apply changes.", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
