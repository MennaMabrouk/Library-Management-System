using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPrice.Text != "" && txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtQuantity.Text != "")
            {
                string bname = txtBookName.Text;
                string bauthor = txtAuthor.Text;
                string publication = txtPublication.Text;
                string bdate = dateTimePicker1.Text;
                Int64 price = int.Parse(txtPrice.Text);
                Int64 quantity = int.Parse(txtQuantity.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-GN8IOPM ; database= library1 ; integrated security = True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bname + "', '" + bauthor + "','" + publication + "' ,'" + bdate + "', " + price + ", " + quantity + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved", "sucess", MessageBoxButtons.OK);


                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
            else
                MessageBox.Show("Empty field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "Are You Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


















        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtPublication_TextChanged(object sender, EventArgs e)
        {

        }
    }
}