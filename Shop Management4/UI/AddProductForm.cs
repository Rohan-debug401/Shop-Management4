using Shop_Management4.BLL;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Shop_Management4.UI
{
    public partial class AddProductForm : Form
    {
        private TypeService typeService = new TypeService();
        private ProductService productService = new ProductService();

        public AddProductForm()
        {
            InitializeComponent();
        }
        //=============================================================================

        // Form Load Event - Loads Type data into ComboBox
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
        }
        // Method to load types into ComboBox
        private void LoadTypes()
        {
            DataTable dt = typeService.GetTypes();

            cmbbxtype.DataSource = dt;
            cmbbxtype.DisplayMember = "TypeName";
            cmbbxtype.ValueMember = "TypeID";
            cmbbxtype.SelectedIndex = -1;
        }
        //==============================================================================
        // Add Product Button Click Event
        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbbxtype.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Type");
                    return;
                }

                string productName = txtbxproductname.Text.Trim();
                int typeId = Convert.ToInt32(cmbbxtype.SelectedValue);

                productService.AddProduct(productName, typeId);

                MessageBox.Show("Product Added Successfully ✅");

                txtbxproductname.Clear();
                cmbbxtype.SelectedIndex = -1;
                txtbxproductname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnaddproduct_Click_1(object sender, EventArgs e)
        {

        }
    }
    //====================================================================================
}
