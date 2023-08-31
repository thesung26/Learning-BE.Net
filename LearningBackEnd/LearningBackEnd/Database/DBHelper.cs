using LearningBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBackEnd.Database
{
    public class DBHelper
    {
        /*
         * Servername:
         * Catalog
         * User name
         * Password
        */
        static string db_address = "Data Source";
        public static List<Product> ProductGetList()
        {
            var list = new List<Product>();

            var sql = new SqlConnection(db_address);
            if (sql.State == System.Data.ConnectionState.Closed)
            {
                sql.Open();
            }

            var cmd = new SqlCommand();            

            return list;
        }
    }
}
