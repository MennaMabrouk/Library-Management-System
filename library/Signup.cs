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
using System.Xml.Linq;

namespace library
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM; database=library;integrated security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into  loginTable(username,password,email) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Account created successfully..");
                ClearData();
            }
            catch
            {
                MessageBox.Show("Error occured...");
            }
            finally
            {
                con.Close();
            }
        }
           
        
        //Clear data after submit
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

