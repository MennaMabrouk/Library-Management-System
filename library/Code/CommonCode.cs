using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_Amal.Code
{
    public class CommonCode
    {
        public static string GetDesignationID(string Designation)

        {

      string query = String.Format("select deg_id from Designation where designation='{0}'",Designation);
          return Convert.ToString(DataAccessLayer.Retreive(query).Rows[0][0]);

}

   public static string GetDesignationName(string DesignationID) { 

string query = String.Format("select designation from Designation where deg_id = '{0}'", DesignationID);


     return Convert.ToString(DataAccessLayer.Retreive(query).Rows[0][0]);
    }
}
}