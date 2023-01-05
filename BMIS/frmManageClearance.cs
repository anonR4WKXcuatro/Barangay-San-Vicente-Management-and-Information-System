using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmManageClearance : Form
    {
        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        PrintPreviewForm frm1 = new PrintPreviewForm();
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
        public frmManageClearance()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public string ResidentID
        {
            get
            {
                return txtResidentID.Text;
            }
            set
            {
                txtResidentID.Text = value;
            }
        }
        public string ResidentFullName
        {
            get
            {
                return txtFullName.Text;
            }
            set
            {
                txtFullName.Text = value;
            }

        }
        public string ResidentAddress
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }

        }
        public string ResidentAge
        {
            get
            {
                return txtAge.Text;
            }
            set
            {
                txtAge.Text = value;
            }

        }
        public string ResidentCivilStatus
        {
            get
            {
                return txtCivilStatus.Text;
            }
            set
            {
                txtCivilStatus.Text = value;
            }

        }
        public string ResidentNationality
        {
            get
            {
                return txtResidentNationality.Text;
            }
            set
            {
                txtResidentNationality.Text = value;
            }

        }

        public string CertificationType
        {
            get
            {
                return this.txtCertificateType.Text;
            }
            set
            {
                this.txtCertificateType.Text = value;
            }
        }

        private void BarangayClearanceRPT()
        {
            BarangayClearance brgyClearanceRPT = new BarangayClearance();
            TextObject officialReceiptNo, residentID, residentName, residentCivilStatus, residentNationality, purpose, my;
            string d = DateTime.Now.Day.ToString();
            string m = DateTime.Now.ToString("MMMM");
            string y = DateTime.Now.Year.ToString();
            string monthYear = "Issued this " + d + " day of " + m + ", " + y + " at San Vicente, Sto. Tomas City, Batangas.";
            officialReceiptNo = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section2"].ReportObjects["officialReceiptNo"];
            residentID = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section2"].ReportObjects["resIDNo"];
            residentName = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentName"];
            residentCivilStatus = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentCivilStatus"];
            residentNationality = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentNationality"];
            purpose = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["purpose"];
            my = (TextObject)brgyClearanceRPT.ReportDefinition.Sections["Section3"].ReportObjects["my"];
            officialReceiptNo.Text = txtOfficialReceiptNo.Text;
            residentID.Text = txtResidentID.Text;
            residentName.Text = txtFullName.Text + ",   " + txtAge.Text;
            residentCivilStatus.Text = txtCivilStatus.Text;
            residentNationality.Text = txtResidentNationality.Text;
            purpose.Text = txtPurpose.Text;
            my.Text = monthYear;
            frm1.crystalReportViewer1.ReportSource = brgyClearanceRPT;
            frm1.ShowDialog();
            Hide();
        }
        private void CertificateOfResidencyRPT()
        {
            BarangayCertificate barangayCertificateRPT = new BarangayCertificate();
            TextObject officialReceiptNo, residentID, residentName, residentCivilStatus, residentNationality, residentAddress, purpose, my;
            string d = DateTime.Now.Day.ToString();
            string m = DateTime.Now.ToString("MMMM");
            string y = DateTime.Now.Year.ToString();
            string monthYear = "Issued this " + d + " day of " + m + ", " + y + " at San Vicente, Sto. Tomas City, Batangas.";
            officialReceiptNo = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section2"].ReportObjects["officialReceiptNo"];
            residentID = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section2"].ReportObjects["resIDNo"];
            residentName = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentName"];
            residentCivilStatus = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentCivilStatus"];
            residentNationality = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentNationality"];
            residentAddress = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentAddress"];
            purpose = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section3"].ReportObjects["purpose"];
            my = (TextObject)barangayCertificateRPT.ReportDefinition.Sections["Section3"].ReportObjects["my"];
            officialReceiptNo.Text = txtOfficialReceiptNo.Text;
            residentID.Text = txtResidentID.Text;
            residentName.Text = txtFullName.Text + ",   " + txtAge.Text;
            residentCivilStatus.Text = txtCivilStatus.Text;
            residentNationality.Text = txtResidentNationality.Text;
            residentAddress.Text = txtAddress.Text;
            purpose.Text = txtPurpose.Text;
            my.Text = monthYear;
            frm1.crystalReportViewer1.ReportSource = barangayCertificateRPT;
            frm1.ShowDialog();
            Hide();
        }
        private void IndigencyRPT()
        {
            Indigency indigencyRPT = new Indigency();
            TextObject officialReceiptNo, residentID, residentName, residentCivilStatus, residentNationality, purpose, my;
            string d = DateTime.Now.Day.ToString();
            string m = DateTime.Now.ToString("MMMM");
            string y = DateTime.Now.Year.ToString();
            string monthYear = "Issued this " + d + " day of " + m + ", " + y + " at San Vicente, Sto. Tomas City, Batangas.";
            officialReceiptNo = (TextObject)indigencyRPT.ReportDefinition.Sections["Section2"].ReportObjects["officialReceiptNo"];
            residentID = (TextObject)indigencyRPT.ReportDefinition.Sections["Section2"].ReportObjects["resIDNo"];
            residentName = (TextObject)indigencyRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentName"];
            residentCivilStatus = (TextObject)indigencyRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentCivilStatus"];
            residentNationality = (TextObject)indigencyRPT.ReportDefinition.Sections["Section3"].ReportObjects["residentNationality"];
            purpose = (TextObject)indigencyRPT.ReportDefinition.Sections["Section3"].ReportObjects["purpose"];
            my = (TextObject)indigencyRPT.ReportDefinition.Sections["Section3"].ReportObjects["my"];
            officialReceiptNo.Text = txtOfficialReceiptNo.Text;
            residentID.Text = txtResidentID.Text;
            residentName.Text = txtFullName.Text + ",   " + txtAge.Text;
            residentCivilStatus.Text = txtCivilStatus.Text;
            residentNationality.Text = txtResidentNationality.Text;
            purpose.Text = txtPurpose.Text;
            my.Text = monthYear;

            frm1.crystalReportViewer1.ReportSource = indigencyRPT;
            frm1.ShowDialog();
            Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateAndTime = DateTime.Now;
            string getCurrentDate = dateAndTime.ToString("MM/dd/yyyy");
            DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var insertQuery = new MySqlCommand("INSERT INTO tbl_clearance(orNumber,fullname,clearance_type,clearance_purpose,date)VALUES(@ORNumber,@FullName,@clearanceType,@clearancePurpose,@date)", connection))
                {
                    try
                    {
                        insertQuery.Parameters.AddWithValue("@ORNumber", txtOfficialReceiptNo.Text);
                        insertQuery.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        insertQuery.Parameters.AddWithValue("@clearanceType", txtCertificateType.Text);
                        insertQuery.Parameters.AddWithValue("@clearancePurpose", txtPurpose.Text);
                        insertQuery.Parameters.AddWithValue("@date", getCurrentDate);
                        connection.Open();
                        if (string.IsNullOrEmpty(txtOfficialReceiptNo.Text) || string.IsNullOrEmpty(txtFullName.Text) ||
                            string.IsNullOrEmpty(txtCertificateType.Text) || string.IsNullOrEmpty(txtPurpose.Text))
                        {
                            MessageBox.Show("Please fill up the remaining fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (txtCertificateType.Text == "BARANGAY CLEARANCE")
                        {
                            insertQuery.ExecuteNonQuery();
                            BarangayClearanceRPT();
                        }
                        else if (txtCertificateType.Text == "CERTIFICATE OF RESIDENCY")
                        {
                            insertQuery.ExecuteNonQuery();
                            CertificateOfResidencyRPT();
                        }
                        else if (txtCertificateType.Text == "INDIGENCY")
                        {
                            insertQuery.ExecuteNonQuery();
                            IndigencyRPT();
                        }
                        else
                        {
                            Console.WriteLine("Do nothing");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please try another official receipt number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    connection.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                Console.Write("Do Nothing");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            txtOfficialReceiptNo.Text = null;
            txtPurpose.Text = null;
            Close();
        }

        private void frmManageClearance_Load(object sender, EventArgs e)
        {
        }
    }
}
