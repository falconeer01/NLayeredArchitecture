using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ADOConnection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2AK7Q68\\SQLEXPRESS;Initial Catalog=Personnels;Integrated Security=True");
    }
}
