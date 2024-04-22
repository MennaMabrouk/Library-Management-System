using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEnroll.Clear();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM;database = library1; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from IRbook where  std_enroll='" + txtEnterEnroll.Text + "' and  Book_return_date is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Id or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        String bname;
        String bdate;
        int rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //column zero as it refers to primary key
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


            }
            txtBookName.Text = bname;
            txtBookIssueDate.Text = bdate;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM;database = library1; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date='" + dateTimePicker1.Text + "'  where std_enroll='" + txtEnterEnroll.Text + "' and id=" + rowid + " ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Return Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1_Load(this, null);

        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {

            if (txtEnterEnroll.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}