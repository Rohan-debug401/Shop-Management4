using System.Data;
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    public class TypeDAL : DbConnection
    {
        public void AddType(string TypeName)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Type_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TypeName", TypeName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetTypes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT TypeID, TypeName FROM dbo.AddType", con
                );
                da.Fill(dt);
            }
            return dt;
        }
    }
}
