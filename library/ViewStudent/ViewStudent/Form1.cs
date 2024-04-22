using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace ViewStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM;database=library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent WHERE enroll LIKE '" + txtSearchEnrollment.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM;database=library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM;database=library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM;database=library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent WHERE stuid = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollmentNo.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
            txtStudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
            txtStudentContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtStudentEmail.Text = ds.Tables[0].Rows[0][6].ToString();





        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String sname = txtStudentName.Text;
            String enroll = txtEnrollmentNo.Text;
            String dep = txtDepartment.Text;
            String sem = txtStudentSemester.Text;
            Int64 mobile = Int64.Parse(txtStudentContact.Text);
            String email = txtStudentEmail.Text;

            if (MessageBox.Show("Are you sure you want to update data?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM;database=library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname='" + sname + "',enroll= '" + enroll + "',dep='" + dep + "',sem='" + sem + "',contact=" + mobile + ",email='" + email + "'where stuid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Form1_Load(this, null);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);
            txtSearchEnrollment.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete data?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM;database=library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where stuid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Form1_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved data will be lost", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}