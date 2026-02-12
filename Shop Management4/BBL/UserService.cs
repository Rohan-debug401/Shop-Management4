using Shop_Management4.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management4.BBL
{
    public class UserService
    {
        UserDAL dal = new UserDAL();

        public void RegisterUser(string UserType, string Name, string Email, string Gender, string State, string Password)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new Exception("Name is Rquired");
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new Exception("Email is required");
            }

            if (string.IsNullOrWhiteSpace(Gender))
            {
                throw new Exception("Gender is required");
            }

            dal.User(UserType, Name, Email, Gender, State, Password);
        }
    }
}
