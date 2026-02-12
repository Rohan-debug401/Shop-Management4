using System;
using System.Data;
using Shop_Management4.DAL;

namespace Shop_Management4.BLL
{
    public class TypeService
    {
        TypeDAL dal = new TypeDAL();

        public void AddType(string TypeName)
        {
            if (string.IsNullOrWhiteSpace(TypeName))
                throw new Exception("Type name is required");

            dal.AddType(TypeName);
        }

        public DataTable GetTypes()
        {
            return dal.GetTypes();
        }
    }
}
