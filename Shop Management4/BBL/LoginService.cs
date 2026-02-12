using System.Data;
using Shop_Management4.DAL;

namespace Shop_Management4.BLL
{
    public class LoginService
    {
        LoginDAL dal = new LoginDAL();

        // ✅ EXISTING LOGIN METHOD
        public bool Login(
            string userType,
            string loginValue,
            string password,
            out string userName
        )
        {
            userName = null;

            DataTable dt = dal.LoginUser(userType, loginValue, password);

            if (dt.Rows.Count > 0)
            {
                userName = dt.Rows[0]["Name"].ToString();
                return true;
            }
            return false;
        }

        // ✅ ADD THIS METHOD FOR COMBOBOX
        public DataTable GetUserTypes()
        {
            return dal.GetUserTypes();
        }
    }
}
