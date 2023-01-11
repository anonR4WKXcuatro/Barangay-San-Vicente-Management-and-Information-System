using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmManageSchedule : Form
    {
        PrintPreviewForm frm1 = new PrintPreviewForm();
        string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //To round border.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public frmManageSchedule()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public string BlotterNo
        {
            get
            {
                return this.txtBlotterNo.Text;
            }
            set
            {
                this.txtBlotterNo.Text = value;
            }
        }
        public string FullName
        {
            get
            {
                return this.txtFullName.Text;
            }
            set
            {
                this.txtFullName.Text = value;
            }

        }
        public string ComplainantName
        {
            get
            {
                return this.txtComplainantName.Text;
            }
            set
            {
                this.txtComplainantName.Text = value;
            }
        }

        public string CaptainName
        {
            get
            {
                return this.txtBrgyCaptain.Text;
            }
            set
            {
                this.txtBrgyCaptain.Text = value;
            }
        }

        private void controlsOn()
        {
            btnUpdate.FillColor = Color.FromArgb(53, 59, 72);
            btnUpdate.Enabled = true;
            txtComplainantName.FillColor = Color.LightYellow;
            txtComplainantName.ReadOnly = true;
            txtFullName.FillColor = Color.LightYellow;
            txtFullName.ReadOnly = true;
            txtBlotterNo.FillColor = Color.LightYellow;
            dtpSettlementDate.Enabled = true;

        }
        private void controlsOff()
        {
            //Buttons
            btnSave.FillColor = Color.FromArgb(53, 59, 72);
            btnSave.Enabled = false;
            btnUpdate.FillColor = Color.FromArgb(53, 59, 72);
            btnUpdate.Enabled = false;
            //textboxes
            txtBlotterNo.FillColor = Color.LightGray;
            txtBlotterNo.ReadOnly = true;
            txtFullName.FillColor = Color.LightGray;
            txtFullName.ReadOnly = true;
            txtComplainantName.FillColor = Color.LightGray;
            txtComplainantName.ReadOnly = true;

            dtpSettlementDate.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            dtpSettlementDate.Value = DateTime.Now;
        }
        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertQuery = connection.CreateCommand();
            MySqlCommand selectQuery = connection.CreateCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(selectQuery);
            BindingSource bSource = new BindingSource();
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                //Command for inserting data blotters in tbl_settlementsched
                
                insertQuery.Parameters.AddWithValue("@blotterNo", txtBlotterNo.Text);
                insertQuery.Parameters.AddWithValue("@fullName", txtFullName.Text);
                insertQuery.Parameters.AddWithValue("@complainantName", txtComplainantName.Text);
                insertQuery.Parameters.AddWithValue("@schedule", dtpSettlementDate.Text);
                insertQuery.Parameters.AddWithValue("@time", dtpSettlementTime.Text);

                insertQuery.CommandText = "INSERT INTO tbl_settlementsched(blotterNo,fullname,complainant_name,settlement_date,settlement_time)" +
                "VALUES(@blotterNo,@fullName,@complainantName,@schedule,@time)";
                //Validations
                if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtComplainantName.Text))
                {
                    MessageBox.Show("Please fill up the remaining fields!");
                }
                else if (insertQuery.ExecuteNonQuery() > 0) // INSERT DATA WHEN ALL FIELDS IS NOT NULL
                {
                    MessageBox.Show("Settlement Successfully Scheduled!", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    selectQuery.CommandText = "SELECT * FROM tbl_settlementsched";
                    sqlDA.Fill(table);
                    bSource.DataSource = table;
                    dgvSched.DataSource = bSource;
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("This Settlement is Already Scheduled!", "Notice", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void frmManageSchedule_Load(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int num = rnd.Next(0000000, 9999999);
            //txtSettlementID.Text = num.ToString();
            dtpSettlementDate.Text = DateTime.Now.ToString("dd/MMMM/yyyy");

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand selectQuery = connection.CreateCommand();
            connection.Open();
            selectQuery.CommandText = "SELECT * FROM tbl_settlementsched";
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(selectQuery);
            {
                dgvSched.DataSource = null;
                dgvSched.AutoGenerateColumns = false;
                dgvSched.ColumnCount = 6;
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                //dgvSched.Columns[0].DataPropertyName = "settlementID";
                dgvSched.Columns[0].DataPropertyName = "blotterNo";
                dgvSched.Columns[1].DataPropertyName = "fullname";
                dgvSched.Columns[2].DataPropertyName = "complainant_name";
                dgvSched.Columns[3].DataPropertyName = "settlement_date";
                dgvSched.Columns[4].DataPropertyName = "settlement_time";

                dgvSched.DataSource = dt;
                dgvSched.Refresh();
            }
            connection.Close();
        }
        private void dgvSched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controlsOn();

            CrystalReport1 cyrprt1 = new CrystalReport1();
            if (e.RowIndex >= 0)
            {
                //DGV VALUES TO TEXTBOX
                DataGridViewRow row = this.dgvSched.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                txtBlotterNo.Text = id.ToString();
                txtBlotterNo.Text = row.Cells[0].Value.ToString();
                txtFullName.Text = row.Cells[1].Value.ToString();
                txtComplainantName.Text = row.Cells[2].Value.ToString();
                dtpSettlementDate.Value = Convert.ToDateTime(row.Cells[3].Value);
                dtpSettlementTime.Value = Convert.ToDateTime(row.Cells[4].Value);

                if (id == txtBlotterNo.Text)
                {
                    btnSave.Enabled = false;
                }
                /*---------------------CRYSTAL REPORT-----------------------------------*/
                TextObject blotterNo, complainant, defendant, Todefendant2, date, time, my, captainName;
                string d = DateTime.Now.Day.ToString();
                string m = DateTime.Now.ToString("MMMM");
                string y = DateTime.Now.Year.ToString();
                string monthYear = "Issued this " + d + " day of " + m + ", " + y + " at San Vicente, Sto. Tomas City, Batangas.";

                blotterNo = (TextObject)cyrprt1.ReportDefinition.Sections["Section1"].ReportObjects["bbenNo"];
                complainant = (TextObject)cyrprt1.ReportDefinition.Sections["Section1"].ReportObjects["complainantName"];
                defendant = (TextObject)cyrprt1.ReportDefinition.Sections["Section1"].ReportObjects["defendantName"];
                Todefendant2 = (TextObject)cyrprt1.ReportDefinition.Sections["Section1"].ReportObjects["defendantName2"];
                date = (TextObject)cyrprt1.ReportDefinition.Sections["Section3"].ReportObjects["date"];
                time = (TextObject)cyrprt1.ReportDefinition.Sections["Section3"].ReportObjects["time"];
                my = (TextObject)cyrprt1.ReportDefinition.Sections["Section3"].ReportObjects["my"];
                captainName = (TextObject)cyrprt1.ReportDefinition.Sections["Section3"].ReportObjects["captainName"];

                blotterNo.Text = txtBlotterNo.Text;
                complainant.Text = txtComplainantName.Text;
                defendant.Text = txtFullName.Text;
                Todefendant2.Text = txtFullName.Text;
                date.Text = row.Cells[3].Value.ToString();
                time.Text = row.Cells[4].Value.ToString();
                my.Text = monthYear;
                captainName.Text = txtBrgyCaptain.Text;
                /*-----------------------------------------------------------------------*/

            }
            if (dgvSched.Columns[e.ColumnIndex].Name == "SUMMON")
            {
                frm1.crystalReportViewer1.ReportSource = cyrprt1;
                frm1.ShowDialog();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateQuery = connection.CreateCommand();
            MySqlCommand selectQuery = connection.CreateCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(selectQuery);
            BindingSource bSource = new BindingSource();
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                //Command for inserting data blotters in tbl_blotter
                
                updateQuery.Parameters.AddWithValue("@blotterNo", txtBlotterNo.Text);
                updateQuery.Parameters.AddWithValue("@fullName", txtFullName.Text);
                updateQuery.Parameters.AddWithValue("@complainantName", txtComplainantName.Text);
                updateQuery.Parameters.AddWithValue("@schedule", dtpSettlementDate.Text);
                updateQuery.Parameters.AddWithValue("@time", dtpSettlementTime.Text);

                updateQuery.CommandText = "UPDATE tbl_settlementsched SET fullname = @fullName, complainant_name = @complainantName, settlement_date = @schedule, settlement_time = @time WHERE blotterNo = @blotterNo";

                //Controls validation
                if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtComplainantName.Text))
                {
                    MessageBox.Show("Please fill up the remaining fields!");
                }
                else if (updateQuery.ExecuteNonQuery() > 0) // INSERT DATA WHEN ALL FIELDS IS NOT NULL
                {
                    MessageBox.Show("Settlement Successfully Updated!", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    selectQuery.CommandText = "SELECT * FROM tbl_settlementsched";
                    sqlDA.Fill(table);
                    bSource.DataSource = table;
                    dgvSched.DataSource = bSource;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught", ex);
            }
        }
    }
}
