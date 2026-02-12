using Shop_Management4.DAL;
using System.Data;

namespace Shop_Management4.BLL
{
    public class AddSizeService
    {
        AddSizeDAL dal = new AddSizeDAL();

        public void AddSize(
            int productId,
            int typeId,
            string Color,
            string size,
            int quantity,
            decimal mrp,
            decimal realPrice)
        {
            dal.AddSize(productId, typeId, Color, size, quantity, mrp, realPrice);
        }
    }
}
