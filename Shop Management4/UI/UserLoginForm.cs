using Shop_Management4.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Shop_Management4.UI
{
    public partial class UserLoginForm : Form
    {
        LoginService service = new LoginService();

        public UserLoginForm()
        {
            InitializeComponent();
        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string userName;

            bool success = service.Login(
                cmbbxtype.Text,
                txtbxemailusername.Text,
                txtbxpassword.Text,
                out userName
            );

            if (success)
            {
                MessageBox.Show("Welcome " + userName);
                string userType = cmbbxtype.Text;

                Form parent = this.MdiParent;   // get Form1 (MDI container)

                if (userType == "Admin")
                {
                    AdminForm adminform = new AdminForm(userName);
                    adminform.MdiParent = parent;   // OPEN INSIDE FORM1
                    adminform.Show();
                }
                else if (userType == "Customer")
                {
                    OrderForm of = new OrderForm(userName, "101", txtbxemailusername.Text);
                    of.MdiParent = parent;          // OPEN INSIDE FORM1
                    of.Show();
                }

                this.Close(); // close login form (better than Hide in MDI)
            }
        }



        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            LoadUserTypes();
        }

        private void LoadUserTypes()
        {
            DataTable dt = service.GetUserTypes();

            cmbbxtype.DataSource = dt;
            cmbbxtype.DisplayMember = "UserType";
        }
    }
}
    
