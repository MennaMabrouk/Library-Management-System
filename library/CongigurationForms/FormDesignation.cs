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
    public partial class FormDesignation : Form
    {
        public FormDesignation()
        {
            InitializeComponent();
        }
        private void FillGrid()
        {

            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreive("select deg_id as [ID],designation as [Designation] from Designation");

            dgvDesignation.DataSource = dt;
        }

            private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textDesignation.Text.Trim().Length == 0)
            {
                MessageBox.Show("please Enter Designation");
                return;
            }
            DataAccessLayer.Excute(String.Format("insert into Designation (designation) values ('{0}')",textDesignation.Text.Trim()));
            MessageBox.Show("Record Added Successfully");
            FillGrid();
        }

        private void FormDesignation_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
