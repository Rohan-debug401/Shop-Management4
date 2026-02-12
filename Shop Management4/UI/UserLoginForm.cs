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

                    // 🔑 Open new form inside same MDI parent
                    OrderForm df = new OrderForm();
                    df.MdiParent = this.MdiParent;
                    df.Show();

                    // ❌ Close login form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login details");
                }
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
    
