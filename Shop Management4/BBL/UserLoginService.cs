using Shop_Management4.DAL;

namespace Shop_Management4.BLL
{
    public UserLoginService (string type, string email, string password)
    {
        return loginDAL.Login(type, email, password);
    }
}
