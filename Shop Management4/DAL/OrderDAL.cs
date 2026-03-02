using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management4.DAL
{
    public class OrderDAL : DbConnection
    {
        public void InsertOrder(int userId, string productName, int quantity, decimal price, decimal total)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_Order_Process", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Total", total);

                cmd.Parameters.AddWithValue("@Action", "INSERT");  // 🔥 Important

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
