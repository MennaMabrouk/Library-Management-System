using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1.Properties
{
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM ; database= library1 ; integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from  NewBook ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            con.ConnectionString = "Server=DESKTOP-GN8IOPM ; database= library1 ; integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewBook where bID= " + bid+" ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
          
            txtBname.Text= ds.Tables[0].Rows[0][1].ToString();
           txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
           txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated.Confirm?", "Sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = txtBname.Text;
                string bauthor = txtAuthor.Text;
                string publication = txtPublication.Text;
                string bdate = txtPDate.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM; database= library1 ; integrated security = True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewBook set bName ='" + bname + "' , bAuthor ='" + bauthor + "' , bPubl='" + publication + "' ,bPDate='" + bdate + "' , bPrice=" + price + " , bQuan=" + quan + " where bid=" + rowid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtBname.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPDate.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();

            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if(txtBookName.Text != null)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM; database= library1 ; integrated security = True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from  NewBook where bName like '" + txtBookName.Text+"%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM; database= library1 ; integrated security = True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from  NewBook ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel2.Visible=false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deletef.Confirm Dialog ?", "Sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string bname = txtBname.Text;
                string bauthor = txtAuthor.Text;
                string publication = txtPublication.Text;
                string bdate = txtPDate.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM ; database= library1 ; integrated security = True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewBook where bID =" + rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                txtBname.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPDate.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
        }
    }
}
