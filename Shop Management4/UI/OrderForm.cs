using Shop_Management4.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management4.UI
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            TypeService service = new TypeService();
            DataTable dt = service.GetTypes();
           


            cmbbxtype.DisplayMember = "TypeName";
            cmbbxtype.ValueMember = "TypeID";
            cmbbxtype.DataSource = dt;
          
        }

        private void cmbbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            if (cmbbxtype.SelectedValue == null)
                return;

            int typeId = Convert.ToInt32(cmbbxtype.SelectedValue);

            ProductService service = new ProductService();

            DataTable dtProduct = service.GetProductsByType(typeId);  // ✅ yaha declare kiya

            cmbbxproductname.DisplayMember = "ProductName";
            cmbbxproductname.ValueMember = "ProductID";
            cmbbxproductname.DataSource = dtProduct;
        }


        private void lblname_Click(object sender, EventArgs e)
        {

        }
    }
}


























