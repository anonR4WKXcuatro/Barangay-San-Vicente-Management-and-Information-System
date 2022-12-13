﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmCases : Form
    {


        frmManageSchedule frm1 = new frmManageSchedule();
        string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        public frmCases()
        {
            InitializeComponent();
        }
        private void controlsOn()
        {
            //textboxes
            txtResidentID.FillColor = Color.White;
            txtResidentID.ReadOnly = false;
            txtBlotterNo.FillColor = Color.LightYellow;
            txtFullName.ReadOnly = false;
            txtFullName.FillColor = Color.White;
            txtPurok.ReadOnly = false;
            txtPurok.FillColor = Color.White;
            txtAge.ReadOnly = false;
            txtAge.FillColor = Color.White;
            txtSex.ReadOnly = false;
            txtSex.FillColor = Color.White;
            txtCivilStatus.ReadOnly = false;
            txtCivilStatus.FillColor = Color.White;
            txtContactNo.ReadOnly = false;
            txtContactNo.FillColor = Color.White;


            txtIncidentPlace.ReadOnly = false;
            txtIncidentPlace.FillColor = Color.White;
            txtComplainant.ReadOnly = false;
            txtComplainant.FillColor = Color.White;
            txtSuspect.ReadOnly = false;
            txtSuspect.FillColor = Color.White;
            txtIncidentNarration.ReadOnly = false;
            txtIncidentNarration.BackColor = Color.White;

            //dtp
            dtpIncidentDate.Enabled = true;
            dtpIncidentTime.Enabled = true;
            cboIncidentType.Enabled = true;
            cboIncidentType.FillColor = Color.White;
        }
        private void controlsOff()
        {
            //buttons
            btnSaveInfo.FillColor = Color.LightGray;
            btnSaveInfo.Enabled = false;
            //textboxes
            txtResidentID.FillColor = Color.LightGray;
            txtResidentID.ReadOnly = true;
            txtBlotterNo.FillColor = Color.LightGray;
            txtFullName.ReadOnly = true;
            txtFullName.FillColor = Color.LightGray;
            txtPurok.ReadOnly = true;
            txtPurok.FillColor = Color.LightGray;
            txtAge.ReadOnly = true;
            txtAge.FillColor = Color.LightGray;
            txtSex.ReadOnly = true;
            txtSex.FillColor = Color.LightGray;
            txtCivilStatus.ReadOnly = true;
            txtCivilStatus.FillColor = Color.LightGray;
            txtContactNo.ReadOnly = true;
            txtContactNo.FillColor = Color.LightGray;


            txtIncidentPlace.ReadOnly = true;
            txtIncidentPlace.FillColor = Color.LightGray;
            txtComplainant.ReadOnly = true;
            txtComplainant.FillColor = Color.LightGray;
            txtSuspect.ReadOnly = true;
            txtSuspect.FillColor = Color.LightGray;
            txtIncidentNarration.ReadOnly = true;
            txtIncidentNarration.BackColor = Color.LightGray;


            //COMBOBOX
            cboIncidentType.Enabled = false;
            cboIncidentType.SelectedIndex = -1;
            cboIncidentType.FillColor = Color.LightGray;


            //DATAGRID
            dgvBlotter.Enabled = true;

            //DATE TIME PICKER
            dtpIncidentDate.Enabled = false;
            dtpIncidentTime.Enabled = false;


        }
        private void resetFields()
        {
            txtResidentID.ResetText();
            txtFullName.ResetText();
            txtPurok.ResetText();
            txtAge.ResetText();
            txtSex.ResetText();
            txtCivilStatus.ResetText();
            txtContactNo.ResetText();

            txtIncidentPlace.ResetText();
            txtComplainant.ResetText();
            txtSuspect.ResetText();
            txtIncidentNarration.ResetText();
        }
        private void txtResidentID_TextChanged(object sender, EventArgs e)
        {
            byte isDead = 1;
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchQuery = connection.CreateCommand();
            connection.Open();
            searchQuery.CommandText = "SELECT purok,age,sex,civil_status,contact_no,fullname FROM tbl_resident WHERE residentID = @residentID AND isDead = @isDead";
            searchQuery.Parameters.AddWithValue("@residentID", txtResidentID.Text);
            searchQuery.Parameters.AddWithValue("@isDead", isDead);
            MySqlDataReader reader = searchQuery.ExecuteReader();
            while (reader.Read())
            {
                txtPurok.Text = reader.GetValue(0).ToString();
                txtAge.Text = reader.GetValue(1).ToString();
                txtSex.Text = reader.GetValue(2).ToString();
                txtCivilStatus.Text = reader.GetValue(3).ToString();
                txtContactNo.Text = reader.GetValue(4).ToString();
                txtFullName.Text = reader.GetValue(5).ToString();
            }
            connection.Close();
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            Random rnd = new Random();
            int num = rnd.Next(1000000, 9999999);
            string settleID = "SETID" + current.Year + current.Month + current.Day + "-" + num.ToString();
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            using (var connection1 = new MySqlConnection(connectionString))
            {
                using (var connection2 = new MySqlConnection(connectionString))
                {
                    using (var insertQuery = new MySqlCommand("INSERT INTO tbl_blotter(blotterID,residentID,fullname,purok,age,sex,civil_status,contact_no,incident_type,incident_date,incident_time,date_filed,incident_place,complainant_name,suspect_identity,incident_narrative)VALUES(@blotterID,@residentID,@FullName,@purok,@age,@sex,@civilStatus,@contactNo,@incidentType,@incidentDate,@incidentTime,@dateFiled,@incidentPlace,@complainantName,@suspectIdentity,@incidentNarrative)", connection1))
                    {
                        using (var insertQuery2 = new MySqlCommand("INSERT INTO tbl_settlement(settleID,blotterNo,fullname,complainant_name,status)VALUES(@settleID,@blotterID,@FullName,@complainantName,@status)", connection2))
                        {
                            try
                            {
                                connection1.Open();
                                connection2.Open();
                                //Command for inserting data blotters in tbl_blotter
                                insertQuery.Parameters.AddWithValue("@blotterID", txtBlotterNo.Text);
                                insertQuery2.Parameters.AddWithValue("@settleID", settleID);
                                insertQuery2.Parameters.AddWithValue("@blotterID", txtBlotterNo.Text);
                                insertQuery.Parameters.AddWithValue("@residentID", txtResidentID.Text);
                                insertQuery.Parameters.AddWithValue("@FullName", txtFullName.Text);
                                insertQuery2.Parameters.AddWithValue("@FullName", txtFullName.Text);
                                insertQuery.Parameters.AddWithValue("@purok", txtPurok.Text);
                                insertQuery.Parameters.AddWithValue("@age", txtAge.Text);
                                insertQuery.Parameters.AddWithValue("@sex", txtSex.Text);
                                insertQuery.Parameters.AddWithValue("@civilStatus", txtCivilStatus.Text);
                                insertQuery.Parameters.AddWithValue("@contactNo", txtContactNo.Text);
                                insertQuery.Parameters.AddWithValue("@incidentType", cboIncidentType.Text);
                                insertQuery.Parameters.AddWithValue("@incidentDate", dtpIncidentDate.Text);
                                insertQuery.Parameters.AddWithValue("@incidentTime", dtpIncidentTime.Text);
                                insertQuery.Parameters.AddWithValue("dateFiled", currentDate);
                                insertQuery.Parameters.AddWithValue("@incidentPlace", txtIncidentPlace.Text);
                                insertQuery.Parameters.AddWithValue("@complainantName", txtComplainant.Text);
                                insertQuery2.Parameters.AddWithValue("@complainantName", txtComplainant.Text);
                                insertQuery.Parameters.AddWithValue("@suspectIdentity", txtSuspect.Text);
                                insertQuery.Parameters.AddWithValue("@incidentNarrative", txtIncidentNarration.Text);
                                insertQuery2.Parameters.AddWithValue("@status", "UNSETTLED");
                                //Controls validation
                                if (string.IsNullOrEmpty(txtResidentID.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtSex.Text) ||
                                string.IsNullOrEmpty(cboIncidentType.Text) || string.IsNullOrEmpty(dtpIncidentDate.Text) ||
                                string.IsNullOrEmpty(txtIncidentPlace.Text) ||
                                string.IsNullOrEmpty(txtComplainant.Text) || string.IsNullOrEmpty(txtSuspect.Text) ||
                                string.IsNullOrEmpty(txtIncidentNarration.Text))
                                {
                                    MessageBox.Show("Please fill up the remaining fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (insertQuery.ExecuteNonQuery() > 0 && insertQuery2.ExecuteNonQuery() > 0) // INSERT DATA WHEN FIELDS ARE NOT NULL
                                {
                                    MessageBox.Show("Blotter Succesfully Recorded!", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                    resetFields();
                                    txtBlotterNo.ResetText();
                                    controlsOff();
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            connection1.Close();
                            connection2.Close();
                        }
                    }
                }
            }
        }
        private void btnAddBlotter_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            Random rnd = new Random();
            int num = rnd.Next(1000000, 9999999);

            txtBlotterNo.Text = "BEN" + current.Year + current.Month + current.Day + "-" + num.ToString();
            //Buttons
            btnSaveInfo.FillColor = Color.FromArgb(53, 59, 72);
            btnSaveInfo.Enabled = true;

            controlsOn();
            resetFields();
        }
        private void frmCases_Load(object sender, EventArgs e)
        {
            dtpIncidentDate.Value = DateTime.Now;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand selectQuery = connection.CreateCommand();
            selectQuery.CommandText = "SELECT * FROM tbl_blotter";
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(selectQuery);
            {
                DataSet dSet = new DataSet();
                sqlDA.Fill(dSet);
                dgvBlotter.AutoGenerateColumns = false;
                dgvBlotter.ColumnCount = 17;
                dgvBlotter.Columns[0].DataPropertyName = "blotterID";
                dgvBlotter.Columns[1].DataPropertyName = "fullname";
                dgvBlotter.Columns[2].DataPropertyName = "purok";
                dgvBlotter.Columns[3].DataPropertyName = "age";
                dgvBlotter.Columns[4].DataPropertyName = "sex";
                dgvBlotter.Columns[5].DataPropertyName = "civil_status";
                dgvBlotter.Columns[6].DataPropertyName = "occupation";
                dgvBlotter.Columns[7].DataPropertyName = "incident_type";
                dgvBlotter.Columns[8].DataPropertyName = "incident_date";
                dgvBlotter.Columns[9].DataPropertyName = "incident_time";
                dgvBlotter.Columns[10].DataPropertyName = "date_filed";
                dgvBlotter.Columns[11].DataPropertyName = "incident_place";
                dgvBlotter.Columns[12].DataPropertyName = "complainant_name";
                dgvBlotter.Columns[13].DataPropertyName = "suspect_identity";
                dgvBlotter.Columns[14].DataPropertyName = "incident_narrative";
                dgvBlotter.DataSource = dSet.Tables[0];
            }
        }
        private void dgvBlotter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBlotter.Columns[e.ColumnIndex].Name == "MANAGE")
            {
                DataGridViewRow row = this.dgvBlotter.Rows[e.RowIndex];
                frm1.BlotterNo = row.Cells[0].Value.ToString();
                frm1.FullName = row.Cells[1].Value.ToString();
                frm1.ComplainantName = row.Cells[12].Value.ToString();
                frm1.ShowDialog();
            }
            else if (dgvBlotter.Columns[e.ColumnIndex].Name == "SETTLE")
            {
                DataGridViewRow row = this.dgvBlotter.Rows[e.RowIndex];

                using (var connection1 = new MySqlConnection(connectionString))
                {
                    connection1.Open();
                    using (var connection2 = new MySqlConnection(connectionString))
                    {
                        connection2.Open();
                        using (var deleteQuery = new MySqlCommand("DELETE FROM tbl_blotter WHERE blotterID = @BlotterID", connection1))
                        {
                            using (var updateQuery = new MySqlCommand("UPDATE tbl_settlement SET status = @status WHERE blotterNo = @BlotterID", connection2))
                            {
                                updateQuery.Parameters.AddWithValue("@status", "SETTLED");
                                updateQuery.Parameters.AddWithValue("@BlotterID", row.Cells[0].Value.ToString());
                                deleteQuery.Parameters.AddWithValue("@BlotterID", row.Cells[0].Value.ToString());
                                if (deleteQuery.ExecuteNonQuery() > 0 && updateQuery.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Case Successfully Settled!", "Notice", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                    resetFields();
                                    txtBlotterNo.ResetText();
                                    controlsOff();
                                }
                            }
                        }
                        connection2.Close();
                    }
                    connection1.Close();
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_blotter", connection))
                {
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(selectQuery);
                    BindingSource bSource = new BindingSource();
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    bSource.DataSource = table;
                    dgvBlotter.DataSource = bSource;
                }
                connection.Close();
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txtIncidentPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtComplainant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtSuspect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtIncidentNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtPurok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtCivilStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
    }
}





