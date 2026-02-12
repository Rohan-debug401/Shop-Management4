using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management4.DAL
{
    public class UserDAL : DbConnection
    {
        public void User(string UserType, string Name, string Email, string Gender, string State, string Password)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "INSERT INTO UserTable (UserType, Name, Email, Gender, State, Password) " +
                               "VALUES (@UserType, @Name, @Email, @Gender, @State, @Password)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
