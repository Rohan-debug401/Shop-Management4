using Shop_Management4.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Shop_Management4.UI
{
    public partial class AddSize : Form
    {
        private AddSizeService sizeService = new AddSizeService();
        private TypeService typeService = new TypeService();
        private ProductService productService = new ProductService();

        public AddSize()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void AddSize_Load(object sender, EventArgs e)
        {
            LoadTypes();
            cmbbxproductname.DataSource = null; // Start me product empty
        }


        // ================= LOAD TYPES =================
        private void LoadTypes()
        {

            DataTable dt = typeService.GetTypes();
            cmbbxtype.DataSource = dt;
            cmbbxtype.DisplayMember = "TypeName";
            cmbbxtype.ValueMember = "TypeID";
            cmbbxtype.SelectedIndex = -1;
        }

        //================= LOAD PRODUCTS BY TYPE =================
        private void LoadProducts(int typeId)
        {
            DataTable dt = productService.GetProductsByType(typeId);
            cmbbxproductname.DataSource = dt;
            cmbbxproductname.DisplayMember = "ProductName";
            cmbbxproductname.ValueMember = "ProductID";
            cmbbxproductname.SelectedIndex = -1;
        }

        // ================= TYPE CHANGED EVENT =================
        private void cmbbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxtype.SelectedValue != null && int.TryParse(cmbbxtype.SelectedValue.ToString(), out int typeId))
            {
                LoadProducts(typeId);
            }
        }


        // ================= REGISTER BUTTON =================
        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbbxtype.SelectedValue == null || cmbbxproductname.SelectedValue == null)
                {
                    MessageBox.Show("Please select Type and Product");
                    return;
                }

                sizeService.AddSize(
                    Convert.ToInt32(cmbbxtype.SelectedValue),
                    Convert.ToInt32(cmbbxproductname.SelectedValue),
                    txtbxcolor.Text.Trim(),
                    txtbxsize.Text.Trim(),
                    Convert.ToInt32(txtbxquantity.Text),
                    Convert.ToDecimal(txtbxmrp.Text),
                    Convert.ToDecimal(txtbxrealprice.Text)
                );

                MessageBox.Show("Size added successfully ✔️");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= CLEAR BUTTON =================
        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ================= CLEAR FORM =================
        private void ClearForm()
        {
            cmbbxtype.SelectedIndex = -1;
            cmbbxproductname.DataSource = null;
            txtbxcolor.Clear();
            txtbxsize.Clear();
            txtbxquantity.Clear();
            txtbxmrp.Clear();
            txtbxrealprice.Clear();
            cmbbxtype.Focus();
        }
    }
}
