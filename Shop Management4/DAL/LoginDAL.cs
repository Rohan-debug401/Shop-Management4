using System.Data;
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    public class LoginDAL : DbConnection
    {
        public DataTable LoginUser(string userType, string loginValue, string password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_User_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserType", userType);
                cmd.Parameters.AddWithValue("@LoginValue", loginValue);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetUserTypes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT UserType FROM UserTable", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
