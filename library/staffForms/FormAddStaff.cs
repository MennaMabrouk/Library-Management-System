using LibraryManagementSystem_Amal.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem_Amal.Forms.staffForms
{
    public partial class FormAddStaff : Form
    {
        public FormAddStaff()
        {
            InitializeComponent();
        }
        private void RetriveDesignations()
        {

            combDesignation.Items.Clear();

            combDesignation.Items.Add("Select Designation");
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive("select designation from Designation");

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow row in dt.Rows)
                {
                    combDesignation.Items.Add(Convert.ToString(row[0]));


                }
              
            }  combDesignation.SelectedIndex = 0;


        }


private void label3_Click(object sender, EventArgs e)
        {

        }

        private void setcolmn()
        {
            dgvstaff.Columns[0].Width = 100;
            dgvstaff.Columns[1].Width = 150;
            dgvstaff.Columns[2].Width = 150;
            dgvstaff.Columns[3].Width = 150;
            dgvstaff.Columns[4].Width = 150;
            dgvstaff.Columns[5].Width = 150;
            dgvstaff.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormAddStaff_Load(object sender, EventArgs e)
        {
            RetriveDesignations();
            combGender.SelectedIndex = 0;
            setcolmn();
            retrievestaffrecord();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            epAddStaff.Clear();
            if (combDesignation.SelectedIndex == 0)
            { epAddStaff.SetError(combDesignation, "Please Select Designations");
                combDesignation.Focus();
                return;
            }
            if (textStaffName.Text.Trim().Length == 0) {

                 epAddStaff.SetError(textStaffName, "Please Enter Name"); 
                textStaffName.Focus();

            return; }
           

            if (textFatherName.Text.Trim().Length == 0){ 

             epAddStaff.SetError(textFatherName, "Please Enter Father Name.");
                textFatherName.Focus();

            return;}
            if (combGender.SelectedIndex == 0)
            {
                epAddStaff.SetError(combGender, "Please Select Gender.");
                combGender.Focus();
                return;
            }
            if (textContactNum.Text.Trim().Length == 0)
            {

                epAddStaff.SetError(textContactNum, "Please Enter Contact Number.");
                textContactNum.Focus();

                return;
            }
            if (textAddress.Text.Trim().Length == 0)
            {

                epAddStaff.SetError(textAddress, "Please Enter address.");
                textAddress.Focus();

                return;
            }

            string query = String.Format("insert into Library_Staff(deg_Id,name,fathername,address,gender,contactno)values('{0}','{1}','{2}','{3}','{4}','{5}')",
                CommonCode.GetDesignationID(combDesignation.Text.Trim()), textStaffName.Text.Trim(), textFatherName.Text.Trim(), textAddress.Text.Trim(), combGender.Text.Trim(),textContactNum.Text.Trim());
            DataAccessLayer.Excute(query);
            MessageBox.Show("Record add successfully");
            clearform();
            retrievestaffrecord();
        }
        public void retrievestaffrecord(string searchvalue)
        {
            dgvstaff.Rows.Clear();
            if (searchvalue.Trim().Length == 0)
            {
                retrievestaffrecord();
                return;
            }


            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive(String.Format("select * from Library_Staff where(name+fathername+address+gender+contactno) like '%{0}%'", searchvalue));

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow addrow = new DataGridViewRow();
                    addrow.CreateCells(dgvstaff);

                    addrow.Cells[0].Value = Convert.ToString(row[0]);
                    addrow.Cells[1].Value = CommonCode.GetDesignationName(Convert.ToString(row[1]));
                    addrow.Cells[2].Value = Convert.ToString(row[2]);
                    addrow.Cells[3].Value = Convert.ToString(row[3]);
                    addrow.Cells[4].Value = Convert.ToString(row[5]);
                    addrow.Cells[5].Value = Convert.ToString(row[6]);
                    addrow.Cells[6].Value = Convert.ToString(row[4]);
                    dgvstaff.Rows.Add(addrow);
                }

            }


        }
        public void retrievestaffrecord()
        {
            dgvstaff.Rows.Clear();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive("select * from Library_Staff");

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow addrow = new DataGridViewRow();
                    addrow.CreateCells(dgvstaff);

                    addrow.Cells[0].Value = Convert.ToString(row[0]);
                    addrow.Cells[1].Value = CommonCode.GetDesignationName(Convert.ToString(row[1]));
                    addrow.Cells[2].Value = Convert.ToString(row[2]);
                    addrow.Cells[3].Value = Convert.ToString(row[3]); 
                    addrow.Cells[4].Value = Convert.ToString(row[5]);
                    addrow.Cells[5].Value = Convert.ToString(row[6]);
                    addrow.Cells[6].Value = Convert.ToString(row[4]);
                    dgvstaff.Rows.Add(addrow);
                }

            }
          

        }

        private void clearform() {
            epAddStaff.Clear();
            combDesignation.SelectedIndex = 0;
            combGender.SelectedIndex = 0;
            textAddress.Text = "";
            textContactNum.Text = "";
            textFatherName.Text = "";
            textStaffName.Text = "";
            textSearch.Text = "";



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgvstaff.Rows.Count > 0)
            {
                if (dgvstaff.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("are you sure you want to delete selected record", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DataAccessLayer.Excute(string.Format("Delete from Library_Staff where staff_id='{0}'", Convert.ToString(dgvstaff.CurrentRow.Cells[0].Value)));
                        MessageBox.Show("Record deleted successfully.");
                        retrievestaffrecord();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("list is empty");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearform();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            retrievestaffrecord(textSearch.Text.Trim());
        }
        private void EnableComponent()
        {
          textSearch.Enabled = false;
            buttonADD.Enabled = false;
            buttonDelete.Enabled = false;
            dgvstaff.Enabled = false;
            buttonEdit.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            epAddStaff.Clear();
            textSearch.Enabled = true;
            buttonADD.Enabled = true;
            buttonDelete.Enabled = true;
            dgvstaff.Enabled = true;
            buttonEdit.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonCancel.Enabled = false;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgvstaff.Rows.Count > 0)
            {
                if (dgvstaff.SelectedRows.Count == 1)
                {

                    combDesignation.Text = Convert.ToString(dgvstaff.CurrentRow.Cells[1].Value);
                  textStaffName.Text = Convert.ToString(dgvstaff.CurrentRow.Cells[2].Value);
                   textFatherName.Text = Convert.ToString(dgvstaff.CurrentRow.Cells[3].Value);
                 combGender.Text = Convert.ToString(dgvstaff.CurrentRow.Cells[4].Value);
                 textContactNum.Text = Convert.ToString(dgvstaff.CurrentRow.Cells[5].Value);
                   textAddress.Text = Convert.ToString(dgvstaff.CurrentRow.Cells[6].Value);




                    EnableComponent();
                }
                else
                {
                    MessageBox.Show("please select one record");
                }
            }
            else
            {
                MessageBox.Show("list is empty");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            epAddStaff.Clear();
            if (combDesignation.SelectedIndex == 0)
            {
                epAddStaff.SetError(combDesignation, "Please Select Designations");
                combDesignation.Focus();
                return;
            }
            if (textStaffName.Text.Trim().Length == 0)
            {

                epAddStaff.SetError(textStaffName, "Please Enter Name");
                textStaffName.Focus();

                return;
            }


            if (textFatherName.Text.Trim().Length == 0)
            {

                epAddStaff.SetError(textFatherName, "Please Enter Father Name.");
                textFatherName.Focus();

                return;
            }
            if (combGender.SelectedIndex == 0)
            {
                epAddStaff.SetError(combGender, "Please Select Gender.");
                combGender.Focus();
                return;
            }
            if (textContactNum.Text.Trim().Length == 0)
            {

                epAddStaff.SetError(textContactNum, "Please Enter Contact Number.");
                textContactNum.Focus();

                return;
            }
            if (textAddress.Text.Trim().Length == 0)
            {

                epAddStaff.SetError(textAddress, "Please Enter address.");
                textAddress.Focus();

                return;
            }

            string query = String.Format("update Library_Staff  set  deg_Id='{0}',name='{1}',fathername='{2}',address='{3}',gender='{4}',contactno='{5}' where staff_Id ='{6}'",
                CommonCode.GetDesignationID(combDesignation.Text.Trim()), textStaffName.Text.Trim(), textFatherName.Text.Trim(), textAddress.Text.Trim(), combGender.Text.Trim(), textContactNum.Text.Trim(), Convert.ToString(dgvstaff.CurrentRow.Cells[0].Value));
            DataAccessLayer.Excute(query);
            MessageBox.Show("Record updated successfully");
            DisableComponent();
            retrievestaffrecord();
        }
    }
}
