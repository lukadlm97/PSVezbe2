using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageUsers
{
    public class StorageDatabase
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Luka\Documents\UsersDB.mdf;Integrated Security=True;Connect Timeout=30";

        public List<User> AllUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connection_string))
                {
                conn.Open();
                

                SqlCommand command = conn.CreateCommand();

                string upit = $"SELECT* FROM dbo.Korisnici";
                command.CommandText = upit;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    {
                        User newUser = new User();
                        newUser.Name = reader["Name"].ToString();
                        newUser.Username = reader["Username"].ToString();
                        newUser.Password = reader["Password"].ToString();
                        newUser.Email = reader["Email"].ToString();
                    users.Add(newUser);
                    }
                
                }
            return users;
            }
    }
}
