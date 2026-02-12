using Shop_Management4.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management4.UI
{
    public partial class AddTypeForm : Form
    {
        public AddTypeForm()
        {
            InitializeComponent();
        }
        //===========================================================================================

        // Add Type Button Click - Inserts new Type into database
        private void btninserttype_Click(object sender, EventArgs e)
        {
            try
            {
                string typeName = txtbxtype.Text.Trim();

                TypeService service = new TypeService();
                service.AddType(typeName);

                MessageBox.Show("Type added successfully!");

                txtbxtype.Clear();
                txtbxtype.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //===========================================================================================
    }
}
