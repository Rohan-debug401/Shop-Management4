using Shop_Management4.BBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shop_Management4.UI
{
    public partial class UserForm : Form
    {
        UserService UserService = new UserService();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            cmbbxstate.Items.Clear();
            cmbbxstate.Items.Add("Select State");
            cmbbxstate.Items.Add("Maharashtra");
            cmbbxstate.Items.Add("Gujarat");
            cmbbxstate.Items.Add("Delhi");
            cmbbxstate.SelectedIndex = 0;
        }

        private void lblregistrationform_Click(object sender, EventArgs e)
        {

        }

        //private void btnregister_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(txtbxname.Text) ||
        //            string.IsNullOrWhiteSpace(txtbxemail.Text) ||
        //            string.IsNullOrWhiteSpace(txtbxpassword.Text))
        //        {
        //            MessageBox.Show("All fields are required");
        //            return;
        //        }
        //        if (cmdbxtype.SelectedIndex == 0)
        //        {
        //            MessageBox.Show("Select User Type");
        //            return;
        //        }

        //        if (cmbbxstate.SelectedIndex == 0)
        //        {
        //            MessageBox.Show("Select State");
        //            return;
        //        }
        //        string Gender = rbbtnmale.Checked ? "Male" :
        //            rbbtnfemale.Checked ? "Female" : "";

        //        if (Gender == "")
        //        {
        //            MessageBox.Show("Select Gender");
        //            return;
        //        }

        //        UserService.RegisterUser(cmdbxtype.Text, txtbxname.Text, txtbxemail.Text, Gender, cmbbxstate.Text, txtbxpassword.Text);

        //        MessageBox.Show("User Registered Successfully ✅");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //}

        private void btnregister_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbxname.Text) ||
                    string.IsNullOrWhiteSpace(txtbxemail.Text) ||
                    string.IsNullOrWhiteSpace(txtbxpassword.Text))
                {
                    MessageBox.Show("All fields are required");
                    return;
                }
                if (cmdbxtype.SelectedIndex == 0)
                {
                    MessageBox.Show("Select User Type");
                    return;
                }

                if (cmbbxstate.SelectedIndex == 0)
                {
                    MessageBox.Show("Select State");
                    return;
                }
                string Gender = rbbtnmale.Checked ? "Male" :
                    rbbtnfemale.Checked ? "Female" : "";

                if (Gender == "")
                {
                    MessageBox.Show("Select Gender");
                    return;
                }

                UserService.RegisterUser(cmdbxtype.Text, txtbxname.Text, txtbxemail.Text, Gender, cmbbxstate.Text, txtbxpassword.Text);

                MessageBox.Show("User Registered Successfully ✅");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
