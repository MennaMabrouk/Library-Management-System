using System.Data;
using System.Data.SqlClient;

namespace CompleteBookDetail
{
    public partial class CompleteBookDetail : Form
    {
        public CompleteBookDetail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-GN8IOPM;database = library1; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from IRBook where Book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "Select * from IRBook where book_return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}