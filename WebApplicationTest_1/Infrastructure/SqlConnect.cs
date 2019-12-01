using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure
{
    public static class SqlConnect
    {
        public static SqlConnection SetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFileName=C:\Users\DZ\source\repos\WebApplicationTest_1\Infrastructure\Users.mdf;Persist Security Info=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;

        }
    }
}
