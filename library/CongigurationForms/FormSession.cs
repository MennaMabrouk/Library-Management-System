using LibraryManagementSystem_Amal.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    public partial class FormSession : Form
    {
        public FormSession()
        {
            InitializeComponent();
        }
        private void setColumnWidth()
        {
            dgv_programme.Columns[0].Width = 100;
            dgv_programme.Columns[1].Width = 200;
            dgv_programme.Columns[2].Width = 150;
            dgv_programme.Columns[3].Width = 150;
            dgv_programme.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Programme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            epPrograme.Clear();
            if (textBox3.Text.Trim().Length == 0)
            {
                epPrograme.SetError(textBox3, "please enter session name");
                textBox3.Focus();
                return;
            }

            // DataAccessLayer.ControlValidate(textBox3, "please enter session name!", epPrograme);
            string query = string.Format("insert into Session (sess_Name,start_Date,end_Date,description)values('{0}','{1}','{2}','{3}')", textBox3.Text.Trim(), dtpStartdate.Value.ToString("yyyy/MM/dd"), dtpenddate.Value.ToString("yyyy/MM/dd"), textBox4.Text.Trim());
            DataAccessLayer.Excute(query);
            MessageBox.Show("session is Added :) ");
            FillGrid();
        }
        private void FillGrid()
        {
            dgv_programme.Rows.Clear();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive("select * from Session");
            if (dt.Rows.Count >= 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow programme_row = new DataGridViewRow();
                    programme_row.CreateCells(dgv_programme);
                    programme_row.Cells[0].Value = Convert.ToString(row[0]);
                    programme_row.Cells[1].Value = Convert.ToString(row[1]);
                    programme_row.Cells[2].Value = Convert.ToDateTime(row[2]).ToString("dd MMMM,yyyy");
                    programme_row.Cells[3].Value = Convert.ToDateTime(row[3]).ToString("dd MMMM,yyyy");
                    programme_row.Cells[4].Value = Convert.ToString(row[4]);
                    dgv_programme.Rows.Add(programme_row);
                }
            }
        }
        private void FormSession_Load(object sender, EventArgs e)
        {
            setColumnWidth();
            FillGrid();


        }

        private void EnableComponent()
        {
            buttonADD.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
           
            dgv_programme.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonCancel.Enabled = true;
        }



        private void DisableComponent()
        {
            buttonADD.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
            
            dgv_programme.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonCancel.Enabled = false;
        }












        private void buttonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgv_programme.Rows.Count > 0)
                {
                    if (dgv_programme.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to delete this session!", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            DataAccessLayer.Excute(string.Format("Delete from Session where sess_Id='{0}'", Convert.ToString(dgv_programme.CurrentRow.Cells[0].Value)));
                            MessageBox.Show("Record Successfully Deleted");
                            FillGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("some records depend on selected record");
            }
        }








        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FillGrid();
            DisableComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FillGrid();

        }

        private void ClearForm()
        {
            epPrograme.Clear();
           
            textBox3.Text = "";
            textBox4.Text = "";
            dtpStartdate.Value = DateTime.Now;
            dtpenddate.Value = DateTime.Now;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (dgv_programme.Rows.Count > 0)
            {
                if (dgv_programme.SelectedRows.Count == 1)
                {
                    textBox3.Text = Convert.ToString(dgv_programme.CurrentRow.Cells[1].Value);
                    dtpStartdate.Value = Convert.ToDateTime(dgv_programme.CurrentRow.Cells[2].Value);
                    dtpenddate.Value = Convert.ToDateTime(dgv_programme.CurrentRow.Cells[3].Value);
                    textBox4.Text = Convert.ToString(dgv_programme.CurrentRow.Cells[4].Value);
                    EnableComponent();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            epPrograme.Clear();
            if (textBox3.Text.Trim().Length == 0)
            {
                epPrograme.SetError(textBox3, "please enter session name");
                textBox3.Focus();
                return;
            }
            string query = string.Format("update Session set sess_Name='{0}',start_Date='{1}',end_Date='{2}',description='{3}' where sess_Id='{4}'", textBox3.Text.Trim(), dtpStartdate.Value.ToString("yyyy/MM/dd"), dtpenddate.Value.ToString("yyyy/MM/dd"), textBox4.Text.Trim(), Convert.ToString(dgv_programme.CurrentRow.Cells[0].Value));
            DataAccessLayer.Excute(query);
            MessageBox.Show("session is Updated :) ");
            FillGrid();
            ClearForm();
            DisableComponent();

        }

        private void dgv_programme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillGrid();
        }

        private void dateTimePickerStartdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormSession_Load_1(object sender, EventArgs e)
        {
            setColumnWidth();
            FillGrid();

        }
    }
}
