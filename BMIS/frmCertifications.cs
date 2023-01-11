using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmCertifications : Form
    {
        frmManageClearance frm1 = new frmManageClearance();
        frmManageBusinessClearance frm2 = new frmManageBusinessClearance();
        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        public frmCertifications()
        {
            InitializeComponent();
        }
        private void issueButtonOff()
        {
            btnIssue.Enabled = false;
        }
        public void refreshTable()
        {
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();
            //MySqlCommand command = connection.CreateCommand();
            //command.CommandText = "SELECT * FROM tbl_clearance";
            //MySqlDataAdapter sqlDA = new MySqlDataAdapter(command);
            //DataTable table = new DataTable();
            //sqlDA.Fill(table);
            //BindingSource bSource = new BindingSource();
            //bSource.DataSource = table;
            //dgvClearanceLogs.DataSource = bSource;
            //connection.Close();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_clearance", connection))
                {
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(selectQuery);
                    BindingSource bSource = new BindingSource();
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    bSource.DataSource = table;
                    dgvClearanceLogs.DataSource = bSource;
                }
                connection.Close();
            }
        }
        private void frmCertifications_Load(object sender, EventArgs e)
        {
            issueButtonOff();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (var connection1 = new MySqlConnection(connectionString))
            using (var searchRecord = new MySqlCommand("SELECT * FROM tbl_resident WHERE residentID LIKE (@ResidentID)", connection1))
            {
                searchRecord.Parameters.Add(new MySqlParameter("@ResidentID", "%" + txtResidentID.Text + "%"));
                connection1.Open();
                using (var reader1 = searchRecord.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        coll.Add(reader1.GetString(0));
                    }
                    using (var connection2 = new MySqlConnection(connectionString))
                    using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_clearance", connection2))
                    {
                        connection2.Open();
                        using (var sqlDA = new MySqlDataAdapter(selectQuery))
                        {
                            dgvClearanceLogs.DataSource = null;
                            dgvClearanceLogs.AutoGenerateColumns = false;
                            dgvClearanceLogs.ColumnCount = 7;
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            dgvClearanceLogs.Columns[0].DataPropertyName = "orNumber";
                            dgvClearanceLogs.Columns[1].DataPropertyName = "fullname";
                            dgvClearanceLogs.Columns[2].DataPropertyName = "clearance_type";
                            dgvClearanceLogs.Columns[3].DataPropertyName = "clearance_purpose";
                            dgvClearanceLogs.Columns[4].DataPropertyName = "date";
                            dgvClearanceLogs.DataSource = dt;
                        }
                        connection2.Close();
                    }
                    txtResidentID.AutoCompleteCustomSource = coll;
                    reader1.Close();
                    connection1.Close();
                }
            }
        }
        private void btnCheckRecord_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var checkRecords = new MySqlCommand("SELECT COUNT(*) AS Records FROM tbl_blotter WHERE residentID LIKE @residentID", connection))
            {
                checkRecords.Parameters.AddWithValue("@residentID", txtResidentID.Text);
                connection.Open();
                int count = Convert.ToInt32(checkRecords.ExecuteScalar());
                if (count > 0)
                {
                    issueButtonOff();
                    lblRecordStatus.Visible = true;
                    lblRecordStatus.ForeColor = System.Drawing.Color.Red;
                    lblRecordStatus.Text = "THIS RESIDENT HAS UNSETTLED ISSUE FOUND IN OUR DATABASE!";

                }
                else if (txtResidentID.Text.Equals("") && count == 0)
                {
                    MessageBox.Show("Nothing to check", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else if (count.Equals(0))
                {
                    // ISSUE BUTTON ON
                    btnIssue.Enabled = true;
                    lblRecordStatus.Visible = true;
                    lblRecordStatus.ForeColor = System.Drawing.Color.Green;
                    lblRecordStatus.Text = "THIS RESIDENT HAS A CLEAN RECORD IN OUR DATABASE!";

                }
                connection.Close();
            }
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var cmdGetCaptainName = new MySqlCommand("SELECT * FROM officials WHERE offic_id = 2", connection))
                {
                    using (var cmdGetResidentsInformation = new MySqlCommand("SELECT * FROM tbl_resident WHERE residentID = @ResidentID", connection))
                    {
                        cmdGetResidentsInformation.Parameters.AddWithValue("@ResidentID", txtResidentID.Text);
                        connection.Open();
                        using (var sqlDA2 = new MySqlDataAdapter(cmdGetResidentsInformation))
                        {
                            using (var sqlDACaptain = new MySqlDataAdapter(cmdGetCaptainName))
                            {
                                DataTable table1 = new DataTable();
                                DataTable table2 = new DataTable();
                                
                                sqlDACaptain.Fill(table1);
                                sqlDA2.Fill(table2);
                                
                                try
                                {
                                    string residentID = txtResidentID.Text;
                                    string residentName = table2.Rows[0][1].ToString();
                                    string residentAge = table2.Rows[0][5].ToString();
                                    string residentCivilStatus = table2.Rows[0][7].ToString();
                                    string residentAddress = table2.Rows[0][15].ToString();
                                    string residentNationality = table2.Rows[0][8].ToString();
                                    string clearanceType = cboClearanceType.Text;
                                    string captainName = table1.Rows[0][1].ToString();

                                    switch (cboClearanceType.SelectedIndex)
                                    {
                                        case 0:
                                            MessageBox.Show("Please select type of certificate!", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                            break;
                                        case 1:
                                            frm1.ResidentID = residentID;
                                            frm1.ResidentFullName = residentName;
                                            frm1.ResidentAge = residentAge;
                                            frm1.ResidentCivilStatus = residentCivilStatus;
                                            frm1.ResidentNationality = residentNationality;
                                            frm1.ResidentAddress = residentAddress;
                                            frm1.CertificationType = clearanceType;
                                            frm1.CaptainName = captainName;
                                            frm1.ShowDialog();
                                            break;
                                        case 2:
                                            frm1.ResidentID = txtResidentID.Text;
                                            frm1.ResidentFullName = residentName;
                                            frm1.ResidentAge = residentAge;
                                            frm1.ResidentCivilStatus = residentCivilStatus;
                                            frm1.ResidentNationality = residentNationality;
                                            frm1.ResidentAddress = residentAddress;
                                            frm1.CertificationType = clearanceType;
                                            frm1.CaptainName = captainName;
                                            frm1.ShowDialog();
                                            break;
                                        case 3:
                                            frm1.ResidentID = residentID;
                                            frm1.ResidentFullName = residentName;
                                            frm1.ResidentAge = residentAge;
                                            frm1.ResidentCivilStatus = residentCivilStatus;
                                            frm1.ResidentNationality = residentNationality;
                                            frm1.ResidentAddress = residentAddress;
                                            frm1.CertificationType = clearanceType;
                                            frm1.CaptainName = captainName;
                                            frm1.ShowDialog();
                                            break;
                                        case 4:
                                            frm2.ResidentID = residentID;
                                            frm2.FullName = residentName;
                                            frm2.OwnersAddress = residentAddress;
                                            frm2.CertificationType = clearanceType;
                                            frm2.CaptainName = captainName;
                                            frm2.ShowDialog();
                                            break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    lblRecordStatus.Visible = true;
                                    lblRecordStatus.ForeColor = System.Drawing.Color.Red;
                                    lblRecordStatus.Text = "RESIDENT NOT FOUND IN OUR DATABASE!";
                                }
                            }
                        }
                        connection.Close();
                    }
                }                  
            }
        }
        private void txtResidentName_TextChanged(object sender, EventArgs e)
        {
            lblRecordStatus.Visible = false;
            lblRecordStatus.Visible = false;
            issueButtonOff();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }
        private void cboClearanceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClearanceType.SelectedIndex.Equals(4))
            {
                btnIssue.Enabled = true;
            }
            else
            {
                btnIssue.Enabled = false;
            }
        }
    }
}
