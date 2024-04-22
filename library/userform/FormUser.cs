using LibraryManagementSystem_Amal.Code;
using System.Data;
using System.Windows.Forms;
using System;
using LibraryManagementSystem_Amal.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem_Amal.Forms.userform
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        private string staffID = "";
        private void RetriveAllStaff()
        {


            DataTable dt = new DataTable();

            combo_select_user.Items.Clear();

            combo_select_user.Items.Add("select user");

            dt = DataAccessLayer.Retreive("select * from Library_Staff");

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow item in dt.Rows)
                {
                    combo_select_user.Items.Add(item[2]);
                }
            }
            else
            {
                MessageBox.Show("Please First Add Library Staff!");

                return;
            }

            combo_select_user.SelectedIndex = 0;
        }
        private void RetriveContactNO()
        {


            DataTable dt = new DataTable();

            comb_contactno.Items.Clear();

            comb_contactno.Items.Add("select contact no");
            dt = DataAccessLayer.Retreive("select contactno from Library_Staff where name '" + combo_select_user.Text.Trim() + "'");

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow item in dt.Rows)
                {
                    comb_contactno.Items.Add(item[0]);
                }
            }
            else
            {
                MessageBox.Show("Please First Add contact no!");

                return;
            }

            comb_contactno.SelectedIndex = 0;
        }
        private void RetriveDesignation()
        {

            DataTable dt = new DataTable();

            dt = DataAccessLayer.Retreive("select deg_Id ,staff_Id from Library_Staff where name '" + combo_select_user.Text.Trim() + "'and contactno = '" + comb_contactno.Text.Trim() + "'");

            if (dt.Rows.Count == 1)
            {

                foreach (DataRow item in dt.Rows)
                {
                    text_Designation.Text = CommonCode.GetDesignationName(Convert.ToString(item[0]));
                    staffID = Convert.ToString(item[1]);
                    break;
                }
            }
            else
            {
                text_Designation.Text = "Not Found";

                return;
            }

        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            RetriveAllStaff();
        }

        private void combo_select_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_select_user.SelectedIndex > 0)
            {
                RetriveContactNO();
            }
            else
            {
                combo_select_user.Items.Clear();
            }

        }

        private void comb_contactno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_contactno.SelectedIndex > 0)
            {
                RetriveDesignation();
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            ep_Error.Clear();

            if (combo_select_user.SelectedIndex == 0)
            {
                ep_Error.SetError(combo_select_user, "Please Select User.");
                combo_select_user.Focus();

                return;
            }

            if (comb_contactno.SelectedIndex == 0)
            {

                ep_Error.SetError(comb_contactno, "Please Select cotact.");
                combo_select_user.Focus();

                return;
            }



            if (txt_UserName.Text.Trim().Length == 0)
            {

                ep_Error.SetError(txt_UserName, "Please enter username.");

                txt_UserName.Focus();


                return;
            }

            if (text_password.Text.Trim().Length == 0)

            {
                ep_Error.SetError(text_password, "Please enter password.");

                text_password.Focus();

                return;
            }

            if (text_confirm_password.Text.Trim().Length == 0)

            {
                ep_Error.SetError(text_confirm_password, "Please enter password again.");

                text_confirm_password.Focus();

                return;
            }


            if (text_password.Text.Trim().Length == 0)

            {
                ep_Error.SetError(text_confirm_password, "Password not match.");

                text_confirm_password.Focus();

                return;
            }
            UserPrevialiges.staffID = int.Parse(staffID);
            if (chk_Configuration.Checked == true)
            {
                UserPrevialiges.Configration = true;
            }
            else
            {
                UserPrevialiges.Configration = false;
            }


        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
