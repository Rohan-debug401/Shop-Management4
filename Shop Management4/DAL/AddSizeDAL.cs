using System.Data;
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    public class AddSizeDAL : DbConnection
    {
        // call this method from your service layer, and pass the appropriate parameters
        public void AddSize(
    int TypeID,
    int ProductID,
    string Color,
    string Size,
    int Quantity,
    decimal MRP,
    decimal RealPrice)
        // consider adding validation here as well, or you can do it in the service layer
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_AssSize_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = TypeID;
                cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = Color;
                cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = Size;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity;
                cmd.Parameters.Add("@MRP", SqlDbType.Decimal).Value = MRP;
                cmd.Parameters.Add("@RealPrice", SqlDbType.Decimal).Value = RealPrice;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        // This method retrieves products, you can modify it to retrieve products based on type if needed
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
