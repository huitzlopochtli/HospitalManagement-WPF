using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalManagement.DAL
{
    public class Connection
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EL85OT8\SQLEXPRESS;Initial Catalog=HospitalManagement;Integrated Security=True");
        public SqlConnection getConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return con;
        }
    }
}
