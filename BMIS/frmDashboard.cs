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
            string unregisteredVoters, senior, pwd, lgbt, soloParent;
            byte isAlive, isDead;
            isAlive = 1;
            isDead = 0;

            unregisteredVoters = "NOT REGISTERED";
            senior = "SENIOR";
            pwd = "PWD";
            lgbt = "LGBT";
            soloParent = "SOLO PARENT";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var totalBlotters = new MySqlCommand("SELECT COUNT(blotterID) AS NumberOfBlotters FROM tbl_blotter", connection))
                {
                    using (var totalClearances = new MySqlCommand("SELECT COUNT(*) AS NumberOfIssuedClearances FROM tbl_clearance WHERE date LIKE @date", connection))
                    {
                        using (var totalResidents = new MySqlCommand("SELECT COUNT(isDead) AS NumberOfResidents FROM tbl_resident WHERE isDead LIKE @isAlive", connection))
                        {
                            using (var totalPWD = new MySqlCommand("SELECT COUNT(IF(isDead = '1',1,null)) AS NumberofPWDs FROM tbl_resident WHERE category LIKE @pwd", connection))
                            {
                                using (var totalSeniors = new MySqlCommand("SELECT COUNT(IF(isDead = '1',1,null)) AS NumberofSeniors FROM tbl_resident WHERE category LIKE @senior", connection))
                                {
                                    using (var totalUnregisteredVoters = new MySqlCommand("SELECT COUNT(IF(isDead = '1',1,null)) AS Dead FROM tbl_resident WHERE voter_status LIKE @noUV", connection))
                                    {
                                        using (var totalLGBT = new MySqlCommand("SELECT COUNT(IF(isDead = '1',1,null)) AS NumberofLGBTs FROM tbl_resident WHERE category LIKE @lgbt", connection))
                                        {
                                            using (var totalSoloParents = new MySqlCommand("SELECT COUNT(IF(isDead = '1',1,null)) AS NumberofSoloParents FROM tbl_resident WHERE category LIKE @soloParent", connection))
                                            {
                                                using (var totalDeceasedResidents = new MySqlCommand("SELECT COUNT(isDead) AS NumberOfDeceasedResidents FROM tbl_resident WHERE isDead LIKE @isDead", connection))
                                                {
                                                    totalClearances.Parameters.AddWithValue("@date", currentDate);
                                                    totalResidents.Parameters.AddWithValue("@isAlive", isAlive);
                                                    totalPWD.Parameters.AddWithValue("@pwd", pwd);
                                                    totalSeniors.Parameters.AddWithValue("@senior", senior);
                                                    totalUnregisteredVoters.Parameters.AddWithValue("@noUV", unregisteredVoters);
                                                    totalLGBT.Parameters.AddWithValue("@lgbt", lgbt);
                                                    totalSoloParents.Parameters.AddWithValue("@soloParent", soloParent);
                                                    totalDeceasedResidents.Parameters.AddWithValue("@isDead", isDead);

                                                    int blottersCounts = Convert.ToInt32(totalBlotters.ExecuteScalar());
                                                    int issuedClearanceCounts = Convert.ToInt32(totalClearances.ExecuteScalar());
                                                    int residentCounts = Convert.ToInt32(totalResidents.ExecuteScalar());
                                                    int pwdCounts = Convert.ToInt32(totalPWD.ExecuteScalar());
                                                    int seniorCounts = Convert.ToInt32(totalSeniors.ExecuteScalar());
                                                    int unregisteredVoterCounts = Convert.ToInt32(totalUnregisteredVoters.ExecuteScalar());
                                                    int lgbtCounts = Convert.ToInt32(totalLGBT.ExecuteScalar());
                                                    int soloParentCounts = Convert.ToInt32(totalSoloParents.ExecuteScalar());
                                                    int deceasedResidentsCounts = Convert.ToInt32(totalDeceasedResidents.ExecuteScalar());

                                                    label3.Text = blottersCounts.ToString();
                                                    label4.Text = issuedClearanceCounts.ToString();
                                                    label9.Text = residentCounts.ToString();
                                                    label2.Text = pwdCounts.ToString();
                                                    label7.Text = seniorCounts.ToString();
                                                    label5.Text = unregisteredVoterCounts.ToString();
                                                    label13.Text = lgbtCounts.ToString();
                                                    label16.Text = soloParentCounts.ToString();
                                                    label18.Text = deceasedResidentsCounts.ToString();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            dashboardStatistics();
            label11.Text = DateTime.Now.ToString("hh:mm tt");
        }


    }
}