using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem_Amal.Code
{
    public class UserPrevialiges
    { public static int staffID { get; set; }

      public static bool Configration { get; set; }
        public static bool staff { get; set; }
        public static bool students { get; set; }
        public static bool book { get; set; }

        public static bool issuebook { get; set; }
        public static bool returnbook { get; set; }
        public static  bool reports { get; set; }

        public static bool gsm { get; set; }
        public static bool email { get; set; }
        public static void createuser()
        {
            string query = String.Format("insert into UserPrevialiges(staffId,configuration,staff,students,book,issuebook,returnbook,reports,gsm,email)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
              staffID, Configration, staff, students, book, issuebook, returnbook, reports, gsm, email);
            DataAccessLayer.Excute(query);
        }

        public static void UpdateUser()
        {
            string query = String.Format("update UserPrevialiges set configuration='{0}',staff='{1}',students='{2}',book='{3}',issuebook='{4}',returnbook='{5}',reports='{6}',gsm='{7}',email='{8}' where staff_Id='{9}')"
              , Configration, staff, students, book, issuebook, returnbook, reports, gsm, email,staffID);
            DataAccessLayer.Excute(query);
        }

    }
}
