﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace BMIS
{
    public partial class frmResidentLists : Form
    {
        string connectionString = "server=localhost; port=3306; user=root; password=admin123; database=bmis_db";
        frmAddResident frm1 = new frmAddResident();
        public frmResidentLists()
        {
            InitializeComponent();
        }


        private void refreshTable()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident", connection))
                {
                    using (var sqlDA = new MySqlDataAdapter(selectQuery))
                    {
                        DataTable table = new DataTable();
                        sqlDA.Fill(table);
                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = table;
                        dgvResidentTable.DataSource = bSource;
                    }
                }
                connection.Close();

            }
        }
        private void searchData(string valueToSearch)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var searchQuery = new MySqlCommand("SELECT * FROM tbl_resident WHERE CONCAT(residentID,fullname,address,purok)like'%" + valueToSearch + "%'", connection))
            {
                connection.Open();
                using (var sqlDA = new MySqlDataAdapter(searchQuery))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dgvResidentTable.DataSource = table;
                }
                connection.Close();
            }
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            frm1.resetFields();
            frm1.ShowDialog();
        }
        private void frmResidentLists_Load(object sender, EventArgs e)
        {         
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var selectQuery = new MySqlCommand("SELECT * FROM tbl_resident", connection))
                {
                    connection.Open();
                    using (var sqlDA = new MySqlDataAdapter(selectQuery))
                    {
                        DataSet dSet = new DataSet();
                        sqlDA.Fill(dSet);
                        dgvResidentTable.AutoGenerateColumns = false;
                        dgvResidentTable.ColumnCount = 20;
                        dgvResidentTable.Columns[0].DataPropertyName = "residentID";
                        dgvResidentTable.Columns[1].DataPropertyName = "fullname";
                        dgvResidentTable.Columns[2].DataPropertyName = "fathername";
                        dgvResidentTable.Columns[3].DataPropertyName = "mothername";
                        dgvResidentTable.Columns[4].DataPropertyName = "sex";
                        dgvResidentTable.Columns[5].DataPropertyName = "age";
                        dgvResidentTable.Columns[6].DataPropertyName = "civil_status";
                        dgvResidentTable.Columns[7].DataPropertyName = "occupation";
                        dgvResidentTable.Columns[8].DataPropertyName = "address";
                        dgvResidentTable.Columns[9].DataPropertyName = "image";
                        dgvResidentTable.Columns[10].DataPropertyName = "nationality";
                        dgvResidentTable.Columns[11].DataPropertyName = "religion";
                        dgvResidentTable.Columns[12].DataPropertyName = "birthdate";
                        dgvResidentTable.Columns[13].DataPropertyName = "contact_no";
                        dgvResidentTable.Columns[14].DataPropertyName = "category";
                        dgvResidentTable.Columns[15].DataPropertyName = "purok";
                        dgvResidentTable.Columns[16].DataPropertyName = "voter_status";
                        dgvResidentTable.Columns[17].DataPropertyName = "isDead";
                        dgvResidentTable.DataSource = dSet.Tables[0];
                    }
                    searchData("");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        private void txtSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string valueToSearch = txtSearchBar.Text.ToString();
            searchData(valueToSearch);
        }
        private void dgvResidentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmResidentProfile residentProfile = new frmResidentProfile();
            string imagePath = dgvResidentTable.CurrentRow.Cells[9].Value.ToString();

            if (dgvResidentTable.Columns[e.ColumnIndex].Name == "PROFILE")
            {
                if (e.RowIndex == -1) return;
                {
                    DataGridViewRow row = dgvResidentTable.Rows[e.RowIndex];
                    residentProfile.ResidentID = row.Cells[0].Value.ToString();
                    residentProfile.FullName = row.Cells[1].Value.ToString();
                    residentProfile.FatherName = row.Cells[2].Value.ToString();
                    residentProfile.MotherName = row.Cells[3].Value.ToString();
                    residentProfile.Sex = row.Cells[4].Value.ToString();
                    residentProfile.Age = row.Cells[5].Value.ToString();
                    residentProfile.CivilStatus = row.Cells[6].Value.ToString();
                    residentProfile.Occupation = row.Cells[7].Value.ToString();
                    residentProfile.Address = row.Cells[8].Value.ToString();

                    if (string.IsNullOrEmpty(imagePath))
                    {
                        residentProfile.userPicture.Image = Properties.Resources.emptyprofile; //SET DEFAULT IMAGE IF USER HAS NO PROFILE (FROM IMPORTING)
                    }
                    else
                    {
                        residentProfile.txtUserImagePath.Text = imagePath;
                        byte[] imageData = (byte[])dgvResidentTable.CurrentRow.Cells[9].Value;
                        MemoryStream ms = new MemoryStream(imageData);
                        residentProfile.userPicture.Image = Image.FromStream(ms);
                    }

                    residentProfile.Nationality = row.Cells[10].Value.ToString();
                    residentProfile.Religion = row.Cells[11].Value.ToString();
                    residentProfile.Birthdate = row.Cells[12].Value.ToString();
                    residentProfile.ContactNo = row.Cells[13].Value.ToString();
                    residentProfile.Category = row.Cells[14].Value.ToString();
                    residentProfile.Purok = row.Cells[15].Value.ToString();
                    residentProfile.VoterStatus = row.Cells[16].Value.ToString();
                    string isAlive = row.Cells[17].Value.ToString();
                    residentProfile.Status = isAlive;

                    if (isAlive.Equals(0))
                    {
                        residentProfile.lblDead.Visible = true;
                    }
                    else
                    {
                        residentProfile.lblDead.Visible = false;
                    }
                }
                residentProfile.ShowDialog();
            }

            else if (dgvResidentTable.Columns[e.ColumnIndex].Name == "DELETE")
            {
                frmAuthDelete auth = new frmAuthDelete();

                if (e.RowIndex == -1) return;
                {
                    DataGridViewRow row = dgvResidentTable.Rows[e.RowIndex];
                    auth.txtResidentID.Text = row.Cells[0].Value.ToString();
                }
                auth.ShowDialog();

            }
        }
    }
}



