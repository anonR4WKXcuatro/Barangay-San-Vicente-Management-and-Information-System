using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BMIS
{
    public partial class frmDashboard : Form
    {
        string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void dashboardStatistics()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string uv = "NOT REGISTERED";
            string snr = "SENIOR";
            string pwd = "PWD";
            byte alive = 1;
            using (var connection = new MySqlConnection(connectionString))
            using (var blotterCounts = new MySqlCommand("SELECT COUNT(blotterID) AS NumberOfBlotters FROM tbl_blotter", connection))
            using (var unregisteredVoter = new MySqlCommand("SELECT COUNT(*) AS NumberOfUnregisteredVoters FROM tbl_resident WHERE voter_status LIKE @noUV", connection))
            using (var issuedClearances = new MySqlCommand("SELECT COUNT(*) AS NumberOfIssuedClearances FROM tbl_clearance WHERE date LIKE @date", connection))
            using (var totalSeniors = new MySqlCommand("SELECT COUNT(*) AS NumberOfSeniors FROM tbl_resident WHERE category LIKE @senior", connection))
            using (var totalPWD = new MySqlCommand("SELECT COUNT(*) AS NumberOfPWD FROM tbl_resident WHERE category LIKE @pwd", connection))
            using (var totalResidents = new MySqlCommand("SELECT COUNT(isDead) AS NumberOfResidents FROM tbl_resident WHERE isDead LIKE @isDead", connection))
            {
                unregisteredVoter.Parameters.AddWithValue("@noUV", uv);
                issuedClearances.Parameters.AddWithValue("@date", currentDate);
                totalSeniors.Parameters.AddWithValue("@senior", snr);
                totalPWD.Parameters.AddWithValue("@pwd", pwd);
                totalResidents.Parameters.AddWithValue("@isDead", alive);
                connection.Open();
                int count2 = Convert.ToInt32(totalPWD.ExecuteScalar());
                int count3 = Convert.ToInt32(blotterCounts.ExecuteScalar());
                int count4 = Convert.ToInt32(issuedClearances.ExecuteScalar());
                int count5 = Convert.ToInt32(unregisteredVoter.ExecuteScalar());
                int count7 = Convert.ToInt32(totalSeniors.ExecuteScalar());
                int count9 = Convert.ToInt32(totalResidents.ExecuteScalar());
                label2.Text = count2.ToString();
                label3.Text = count3.ToString();
                label4.Text = count4.ToString();
                label5.Text = count5.ToString();
                label7.Text = count7.ToString();
                label9.Text = count9.ToString();
            }
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            dashboardStatistics();


            label11.Text = DateTime.Now.ToString("hh:mm tt");

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }


    }
}