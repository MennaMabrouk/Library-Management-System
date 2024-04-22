using LibraryManagementSystem_Amal.Forms.CongigurationForms;
using LibraryManagementSystem_Amal.Forms.staffForms;
using LibraryManagementSystem_Amal.Forms.userform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFormsApp3.Form1 k = new WinFormsApp3.Form1();
            k.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want Exit ?!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }


        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFormsApp1.Form1 abc = new WinFormsApp1.Form1();
            abc.Show();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent.Form1 d = new AddStudent.Form1();
            d.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent.Form1 a = new ViewStudent.Form1();
            a.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFormsApp1.Properties.viewbook s = new WinFormsApp1.Properties.viewbook();
            s.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebookframe.issueBookForm l = new issuebookframe.issueBookForm();
            l.Show();
        }

        private void completeBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetail.CompleteBookDetail c = new CompleteBookDetail.CompleteBookDetail();
            c.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want Exit ?!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment frmDepartment = new FormDepartment();
            frmDepartment.Show();
        }

        private void programmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProgramme frmprogramme = new FormProgramme();
            frmprogramme.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesignation frmDesignation = new FormDesignation();
            frmDesignation.Show();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSession frmsession = new FormSession();
            frmsession.Show();
        }

        private void libraryStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddStaff frmAddStaff = new FormAddStaff();
            frmAddStaff.Show();
        }

        private void userPreviligeisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser frmuser = new FormUser();
            frmuser.Show();

        }
    }
}