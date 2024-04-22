using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace issuebookframe
{
    public partial class issueBookForm : Form
    {
        public issueBookForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-GN8IOPM; database=library1; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand("select bname from newbook", conn);
            SqlDataReader datareader;
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                for (int i = 0; i < datareader.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(datareader.GetString(i));
                }
            }
            datareader.Close();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEnrNum.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEnrNum.Text != "")
            {
                String eid = txtEnrNum.Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=DESKTOP-GN8IOPM; database=library1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from NewStudent where enroll='" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "select count (std_enroll) from IRBook where std_enroll = '" + eid + "' and Book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter();
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());


                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtdept.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtStSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtStname.Clear();
                    txtdept.Clear();
                    txtStSemester.Clear();
                    txtContact.Clear();

                    txtEmail.Clear();
                    MessageBox.Show("Invalid Enrollment number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStname.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count < 3)
                {
                    String enroll_num = txtEnrNum.Text;
                    String St_name = txtStname.Text;
                    String dept = txtdept.Text;
                    String semester = txtStSemester.Text;
                    String contact = txtContact.Text;
                    String email = txtEmail.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker1.Text;

                    String eid = txtEnrNum.Text;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Server=DESKTOP-GN8IOPM; database=library1; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,Book_issue_date) values('" + enroll_num + "','" + St_name + "','" + dept + "','" + semester + "','" + contact + "','" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Book Has Been Issued Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEnrNum.Clear();
                }
                else
                {
                    MessageBox.Show("Select one ( AT LEAST ) or two ( AT MOST ) books ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEnrNum.Clear();
                }

            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrNum_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrNum.Text == "")
            {
                txtStname.Clear();
                txtdept.Clear();
                txtStSemester.Clear();
                txtContact.Clear();
                txtEmail.Clear();
                comboBoxBooks.ResetText();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure,You Want To Exit ?", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
