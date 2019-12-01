using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using System.Data.SqlClient;
using Domain.Interfaces;
using System.IO;

namespace Infrastructures
{
    public class UserInfrastructure : IUserModel
    {
        public IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>();

            SqlConnection connection = Infrastructure.SqlConnect.SetConnection();

            SqlCommand sqlCommand = new SqlCommand("Select * from [User]", connection);
            SqlDataReader sqlReader = null;
            try
            {
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    users.Add(new User { Email = Convert.ToString(sqlReader["Email"]), FirstName = Convert.ToString(sqlReader["FirstName"]), LastName = Convert.ToString(sqlReader["LastName"]) });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return users;
        }
    }
}
