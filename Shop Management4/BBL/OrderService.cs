using Shop_Management4.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management4.BBL
{
    public class OrderService
    {
        OrderDAL dal = new OrderDAL();

        public void SaveOrder(int userId, string productName, int quantity, decimal price, decimal total)
        {
            dal.InsertOrder(userId, productName, quantity, price, total);
        }
    }
}
