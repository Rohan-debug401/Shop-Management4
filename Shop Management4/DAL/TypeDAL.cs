using System.Data;
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    
    public class TypeDAL : DbConnection
    {
        // This method adds a new type to the database by calling the stored procedure "dbo.sp_Type_Insert" with the provided type name as a parameter.
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

        // This method retrieves all types from the database by executing a SQL query that selects the TypeID
        // and TypeName columns from the dbo.AddType table, and returns the results in a DataTable.
        public DataTable GetTypes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(  "SELECT TypeID, TypeName FROM dbo.AddType", con
                );
                da.Fill(dt);
            }
            return dt;
        }
    }
}
