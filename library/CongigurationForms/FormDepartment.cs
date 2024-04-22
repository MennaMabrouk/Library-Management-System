using LibraryManagementSystem_Amal.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }
        private void setColumnWidth()
        {
            dgvDepartment.Columns[0].Width = 90;
            dgvDepartment.Columns[1].Width = 150;
            dgvDepartment.Columns[2].Width = 150;
            dgvDepartment.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            setColumnWidth();
            FillGrid();
        }
        private void clearform()
        {
            textDepartment_name.Text = "";
            txt_Department_description.Text = "";
            dtp_establishdate.Value = DateTime.Now;
        }
        private void FillGrid()
        {
            dgvDepartment.Rows.Clear();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive("select * from Department");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow createrow = new DataGridViewRow();
                    createrow.CreateCells(dgvDepartment);
                    createrow.Cells[0].Value = Convert.ToString(row[0]);
                    createrow.Cells[1].Value = Convert.ToString(row[1]);
                    createrow.Cells[2].Value = Convert.ToDateTime(row[2]).ToString("dd MMMM,yyyy");
                    createrow.Cells[3].Value = Convert.ToString(row[3]);
                    dgvDepartment.Rows.Add(createrow);
                }
            }
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textDepartment_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("please enter Department Name!!");
                return;
            }
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive(String.Format("select * from Department where dpt_Name='{0}'", textDepartment_name.Text.Trim()));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("department name is elready exist");
                return;
            }
            String query = String.Format("insert into Department(dpt_Name,establish_Date,description)values('{0}','{1}','{2}')", textProgramme_name.Text.Trim(), dtp_establishdate.Value.ToString("yyyy/MM/dd"), txt_Department_description.Text.Trim());
            DataAccessLayer.Excute(query);
            MessageBox.Show("department add successfuly");
            FillGrid();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearform();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (dgvDepartment.Rows.Count > 0)
                {
                    if (dgvDepartment.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("are you sure you want to delete selected record", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            DataAccessLayer.Excute(string.Format("Delete from Department where dpt_Id='{0}'", Convert.ToString(dgvDepartment.CurrentRow.Cells[0].Value)));
                            MessageBox.Show("Record deleted successfully.");
                            FillGrid();
                        }
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
            catch (Exception ex)
            {
                MessageBox.Show("some records are dependant on selected records ");
                return;
            }
        }

        private void EnableComponent()
        {
            dgvDepartment.Enabled = false;
            buttonADD.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            dgvDepartment.Enabled = true;
            buttonADD.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonCancel.Enabled = false;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.Rows.Count > 0)
            {
                if (dgvDepartment.SelectedRows.Count == 1)
                {

                    dtp_establishdate.Value = Convert.ToDateTime(dgvDepartment.CurrentRow.Cells[2].Value);
                    txt_Department_description.Text = Convert.ToString(dgvDepartment.CurrentRow.Cells[3].Value);
                    textDepartment_name.Text = Convert.ToString(dgvDepartment.CurrentRow.Cells[1].Value);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearform();
            DisableComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textDepartment_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("please enter programme name!!");
                return;
            }
            String query = String.Format("update Department set dpt_Name='{0}',establish_Date='{1}',description='{2}' where dpt_Id='{3}'", textDepartment_name.Text.Trim(), dtp_establishdate.Value.ToString("yyyy/MM/dd"), txt_Department_description.Text.Trim(), Convert.ToString(dgvDepartment.CurrentRow.Cells[0].Value));
            DataAccessLayer.Excute(query);
            MessageBox.Show("department updated successfuly");
            FillGrid();
            clearform();
            DisableComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
