using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmAuthDelete : Form
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
        public frmAuthDelete()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            txtPassword.UseSystemPasswordChar = true;
        }
        private void frmAuthDelete_Load(object sender, EventArgs e)
        {

        }
        public void DeleteConfirmation()
        {
            frmResidentProfile rp = new frmResidentProfile();
            frmResidentLists rl = new frmResidentLists();
            var user = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            bool verify = user.Login_Verification();
            if (verify)
            {
                int role = user.Role;
                if (role == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    try
                    {
                        switch (dialogResult)
                        {
                            case DialogResult.Yes:
                                using (var connection = new MySqlConnection(connectionString))
                                {
                                    connection.Open();
                                    using (var deleteQuery = new MySqlCommand("DELETE FROM tbl_resident WHERE residentID = @residentID", connection))
                                    {
                                        string residentID = txtResidentID.Text;
                                        deleteQuery.Parameters.AddWithValue("@residentID", residentID);
                                        deleteQuery.ExecuteNonQuery();

                                    }
                                    connection.Close();
                                }
                                MessageBox.Show("Data Successfully Deleted!", "Notice", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                Dispose();
                                break;
                            default:
                                Console.WriteLine("Do nothing");
                                break;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please try again!", "Authentication Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteConfirmation();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DeleteConfirmation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
