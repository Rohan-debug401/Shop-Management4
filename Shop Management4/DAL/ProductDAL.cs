using System;
using System.Data;
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    public class ProductDAL : DbConnection
    {
        // ===========================
        // INSERT PRODUCT
        // ===========================
        public void AddProduct(string productName, int typeId)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_Product_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.NVarChar, 20).Value = "INSERT";
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 70).Value = productName;
                cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = typeId;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ===========================
        // GET PRODUCTS BY TYPE
        // ===========================
        public DataTable GetProductsByType(int? typeId = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_Product_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Action", SqlDbType.NVarChar, 20).Value = "SELECT";

                if (typeId == null)
                    cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = typeId;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
