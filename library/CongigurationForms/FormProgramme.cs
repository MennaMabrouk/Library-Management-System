using LibraryManagementSystem_Amal.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    public partial class FormProgramme : Form
    {
        public FormProgramme()
        {
            InitializeComponent();
        }
        private void setColumnWidth()
        {
            dgvprogramme.Columns[0].Width = 90;
            dgvprogramme.Columns[1].Width = 150;

            dgvprogramme.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormProgramme_Load(object sender, EventArgs e)
        {
            setColumnWidth();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvprogramme.Rows.Clear();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive("select * from Programme");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow createrow = new DataGridViewRow();
                    createrow.CreateCells(dgvprogramme);
                    createrow.Cells[0].Value = Convert.ToString(row[0]);
                    createrow.Cells[1].Value = Convert.ToString(row[1]);
                    createrow.Cells[2].Value = Convert.ToString(row[2]);
                    dgvprogramme.Rows.Add(createrow);
                }
            }
        }








        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textProgramme_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("please enter programme name!!");
                return;
            }
            String query = String.Format("insert into Programme(prog_Name,description)values('{0}','{1}')", textProgramme_name.Text.Trim(), txt_programme_description.Text.Trim());
            DataAccessLayer.Excute(query);
            MessageBox.Show("programme add successfuly");
            FillGrid();
        }

        private void textProgramme_name_TextChanged(object sender, EventArgs e)
        {

        }




        private void clearform()
        {
            txt_programme_description.Text = "";
            textProgramme_name.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearform();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            try
            {

            
            if (dgvprogramme.Rows.Count > 0)
            {
                if (dgvprogramme.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("are you sure you want to delete selected record", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DataAccessLayer.Excute(string.Format("Delete from Programme where prog_Id='{0}'", Convert.ToString(dgvprogramme.CurrentRow.Cells[0].Value)));
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
            catch(Exception ex){
                MessageBox.Show("some records are dependant on selected records ");
                return;
            } 
}
        
        private void EnableComponent()
        {
            dgvprogramme.Enabled = false;
            buttonADD.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            dgvprogramme.Enabled = true;
            buttonADD.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonCancel.Enabled = false;
        }





        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgvprogramme.Rows.Count > 0)
            {
                if (dgvprogramme.SelectedRows.Count == 1)
                {

                    txt_programme_description.Text = Convert.ToString(dgvprogramme.CurrentRow.Cells[2].Value);
                    textProgramme_name.Text = Convert.ToString(dgvprogramme.CurrentRow.Cells[1].Value);
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
            if (textProgramme_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("please enter programme name!!");
                return;
            }
            String query = String.Format("update Programme set prog_Name='{0}',description='{1}' where prog_Id='{2}'", textProgramme_name.Text.Trim(), txt_programme_description.Text.Trim(), Convert.ToString(dgvprogramme.CurrentRow.Cells[0].Value));
            DataAccessLayer.Excute(query);
            MessageBox.Show("programme updated successfuly");
            FillGrid();
            clearform();
            DisableComponent();
        }

        private void dgvprogramme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
