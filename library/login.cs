using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace library
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM; database=library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Admin where username='" + txtusername.Text + "'and password='" + txtpassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("LOGIN SUCCESSFULL!!", "Login Success", MessageBoxButtons.OK);
                this.Hide();
                DashBoard dsa = new DashBoard();
                dsa.Show();
                // MessageBox.Show("LOGIN SUCCESSFULL!!", "Login Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      /*  private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM; database=library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where sname='" + txtusername.Text + "'and password='" + txtpassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("LOGIN SUCCESSFULL!!", "Login Success", MessageBoxButtons.OK);
                this.Hide();
                dashboard_student dsa = new dashboard_student();
                dsa.Show();
                // MessageBox.Show("LOGIN SUCCESSFULL!!", "Login Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      */
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Clear();
            }
        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '.';
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://instagram.com/amal_eltelbany?igshid=ZDdkNTZiNTM=", UseShellExecute = true });
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.facebook.com/profile.php?id=100086180097539&mibextid=ZbWKwL", UseShellExecute = true });
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/channel/UCPM5UNkuiTSpoQXKdJl6PdQ", UseShellExecute = true });
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://twitter.com/Amal_eltelbany?s=09", UseShellExecute = true });
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://discord.com/channels/@me", UseShellExecute = true });
        }
    }
}