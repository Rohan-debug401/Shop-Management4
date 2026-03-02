using Shop_Management4.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Shop_Management4.BLL
{
    public class ProductService
    {
        private ProductDAL dal = new ProductDAL();

        // ===========================
        // ADD PRODUCT
        // ===========================
        public void AddProduct(string productName, int typeId)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(productName))
                throw new Exception("Product name is required");

            if (typeId <= 0)
                throw new Exception("Please select a valid Type");

            dal.AddProduct(productName.Trim(), typeId);
        }

        // Get product info by ID (you can expand this method to include more details as needed)
        public DataTable GetProductDetails(int productId)
        {
            return dal.GetProductDetails(productId);
        }


        // ===========================
        // GET PRODUCTS BY TYPE
        // ===========================
        public DataTable GetProductsByType(int? typeId = null )
        {
            return dal.GetProductsByType(typeId);
        }
    }
}
