using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmMainWindow : Form
    {
        private string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        private Color btnOriginalColor = default;
        public frmMainWindow()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get
            {
                return lblPosition.Text;
            }
            set
            {
                lblPosition.Text = value;
            }
        }

        public void loadForm(object Form)
        {
            timer.Start();
            //LOAD ALL FORMS IN SINGLE PANEL
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();


        }
        //HIGHLIGHTS THE BUTTONS WHEN CLICKED !!!
        public void btnDashboardEffect()
        {
            loadForm(new frmDashboard());
            btnDashboard.BackColor = Color.LightSlateGray;
            btnDashboard.Enabled = false;

            btnResidents.BackColor = btnOriginalColor;
            btnResidents.Enabled = true;

            btnCases.BackColor = btnOriginalColor;
            btnCases.Enabled = true;

            btnCertifications.BackColor = btnOriginalColor;
            btnCertifications.Enabled = true;

            btnRecords.BackColor = btnOriginalColor;
            btnRecords.Enabled = true;
        }
        private void btnResidentEffect()
        {

            loadForm(new frmResidentLists());
            btnResidents.BackColor = Color.LightSlateGray;
            btnResidents.Enabled = false;



            btnDashboard.BackColor = btnOriginalColor;
            btnDashboard.Enabled = true;

            btnCases.BackColor = btnOriginalColor;
            btnCases.Enabled = true;

            btnCertifications.BackColor = btnOriginalColor;
            btnCertifications.Enabled = true;

            btnRecords.BackColor = btnOriginalColor;
            btnRecords.Enabled = true;
        }
        private void btnCasesEffect()
        {
            loadForm(new frmCases());
            btnCases.BackColor = Color.LightSlateGray;
            btnCases.Enabled = false;



            btnDashboard.BackColor = btnOriginalColor;
            btnDashboard.Enabled = true;

            btnResidents.BackColor = btnOriginalColor;
            btnResidents.Enabled = true;

            btnCertifications.BackColor = btnOriginalColor;
            btnCertifications.Enabled = true;

            btnRecords.BackColor = btnOriginalColor;
            btnRecords.Enabled = true;
        }
        private void btnCertificationEffect()
        {
            loadForm(new frmCertifications());

            btnCertifications.BackColor = Color.LightSlateGray;
            btnCertifications.Enabled = false;




            btnDashboard.BackColor = btnOriginalColor;
            btnDashboard.Enabled = true;

            btnResidents.BackColor = btnOriginalColor;
            btnResidents.Enabled = true;

            btnCases.BackColor = btnOriginalColor;
            btnCases.Enabled = true;

            btnRecords.BackColor = btnOriginalColor;
            btnRecords.Enabled = true;
        }
        private void btnRecordsEffect()
        {
            loadForm(new frmRecords());


            btnRecords.BackColor = Color.LightSlateGray;
            btnRecords.Enabled = false;




            btnDashboard.BackColor = btnOriginalColor;
            btnDashboard.Enabled = true;

            btnResidents.BackColor = btnOriginalColor;
            btnResidents.Enabled = true;

            btnCases.BackColor = btnOriginalColor;
            btnCases.Enabled = true;

            btnCertifications.BackColor = btnOriginalColor;
            btnCertifications.Enabled = true;
        }
        //
        public void ReadPositionLabel()
        {
            MySqlDataReader dataReader;

            if (lblPosition.Text.Equals("Brgy. Secretary")){
                int id = 1;
                using (var connection = new MySqlConnection(connectionString))
                using (var selectQuery = new MySqlCommand("SELECT * FROM officials WHERE offic_id =" + id + "", connection))
                {
                    connection.Open();
                    try
                    {
                        dataReader = selectQuery.ExecuteReader();
                        while (dataReader.Read())
                        {
                            lblBrgySecretary.Text = dataReader[1].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    connection.Close();
                }
            }
            else if(lblPosition.Text.Equals("Brgy. Captain"))
            {
                int id = 2;
                using (var connection = new MySqlConnection(connectionString))
                using (var selectQuery = new MySqlCommand("SELECT * FROM officials WHERE offic_id =" + id + "", connection))
                {
                    connection.Open();
                    try
                    {
                        dataReader = selectQuery.ExecuteReader();
                        while (dataReader.Read())
                        {
                            lblBrgySecretary.Text = dataReader[1].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    connection.Close();
                }
            }    
        }

        //BUTTON LISTNER
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmResidentProfile residentProfile = new frmResidentProfile();
            residentProfile.Dispose();
            btnDashboardEffect();
        }
        private void btnResidents_Click(object sender, EventArgs e)
        {
            btnResidentEffect();

        }
        private void btnCases_Click(object sender, EventArgs e)
        {
            btnCasesEffect();

        }
        private void btnCertifications_Click(object sender, EventArgs e)
        {
            btnCertificationEffect();

        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            btnRecordsEffect();

        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmAuth auth = new frmAuth();
            auth.btnAccess.Visible = true;
            auth.ShowDialog();
        }
       
        //DIGITAL CLOCK
        private void timer_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm");
            label4.Text = DateTime.Now.ToString("ss");
        }
        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            ReadPositionLabel();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirmation = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitConfirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Console.WriteLine("Do NOthing");
            }
        }
    }
}