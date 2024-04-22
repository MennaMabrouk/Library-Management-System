
using System.Data.Common;
using System.Data.SqlClient;

namespace AddStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection myconn = new SqlConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtContact.Clear();
            txtDepartment.Clear();
            txtEmail.Clear();
            txtEnrollment.Clear();
            txtSemester.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtDepartment.Text != "" && txtEmail.Text != "" && txtEnrollment.Text != "" && txtSemester.Text != "")
            {


                String name = txtName.Text;
                String enroll = txtEnrollment.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;
      

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server = DESKTOP-GN8IOPM; database = library1;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into NewStudent (sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields!", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}