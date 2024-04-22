using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem_Amal.Code
{
   public class DataAccessLayer

    {
        private static SqlConnection conn;
        private static SqlConnection ConnOpen()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-GN8IOPM;Initial Catalog=Library1;Integrated Security= True");
            }
            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }

            return conn;
        }

        internal static void Excute(string query)
        {
            SqlCommand cmd = new SqlCommand(query,ConnOpen());
            cmd.ExecuteNonQuery();
        }

        internal static DataTable Retreive(string query)
        {
         DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter(query, ConnOpen());
            da.Fill(dt);
            return dt;
        }
        internal static void ControlValidate(TextBox textBox,string message,ErrorProvider ep)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                ep.SetError(textBox, "" + message + "");
                textBox.Focus();
                textBox.SelectAll();
                return;
            }
        }

    }
}
