using System.Data;
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    public class AddSizeDAL : DbConnection
    {
        public void AddSize(
            int ProductID,
            int TypeID,
            string Color,
            string Size,
            int Quantity,
            decimal MRP,
            decimal RealPrice)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_AssSize_Insert", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = ProductID;
                cmd.Parameters.Add("@TypeID", System.Data.SqlDbType.Int).Value = TypeID;
                cmd.Parameters.Add("@Color", System.Data.SqlDbType.NVarChar).Value = Color;
                cmd.Parameters.Add("@Size", System.Data.SqlDbType.NVarChar).Value = Size;
                cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = Quantity;
                cmd.Parameters.Add("@MRP", System.Data.SqlDbType.Decimal).Value = MRP;
                cmd.Parameters.Add("@RealPrice", System.Data.SqlDbType.Decimal).Value = RealPrice;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetProduct()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TypeID, TypeName FROM dbo.Product", con);
                SqlDataAdapter pa = new SqlDataAdapter("SELECT ProductID, ProductName FROM dbo.Product", con);

                da.Fill(dt);
                pa.Fill(dt);
            }

            return dt;
        }
    }
}
