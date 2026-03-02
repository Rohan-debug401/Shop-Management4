using Shop_Management4.BBL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Management4.UI
{
    public partial class OrderForm : Form
    {
        public OrderForm(string name, string userId, string email)
        {
            InitializeComponent();

            // Assign values to your labels/textboxes on the OrderForm
            lblnames.Text = name;
            lbluserids.Text = userId;
            lblemails.Text = email;
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadTypes();


            // 🔥 Setup ListView properly
            lvorder.View = View.Details;
            lvorder.FullRowSelect = true;
            lvorder.GridLines = true;
            lvorder.MultiSelect = false;

            lvorder.Columns.Clear();
            lvorder.Columns.Add("Color", 100);
            lvorder.Columns.Add("Size", 100);
            lvorder.Columns.Add("Quantity", 100);
            lvorder.Columns.Add("Real Price", 100);
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

        private void cmbbxproductname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxproductname.SelectedValue == null)
                return;

            // 👇 IMPORTANT FIX
            if (cmbbxproductname.SelectedValue is DataRowView)
                return;

            int productId = Convert.ToInt32(cmbbxproductname.SelectedValue);

            ProductService service = new ProductService();
            DataTable dt = service.GetProductDetails(productId);

            dgvorder.DataSource = dt;
        }


        private void dgvorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (dgvorder.CurrentRow != null)
            {
                string color = dgvorder.CurrentRow.Cells["Color"].Value.ToString();
                string size = dgvorder.CurrentRow.Cells["Size"].Value.ToString();
                string quantity = dgvorder.CurrentRow.Cells["Quantity"].Value.ToString();
                string price = dgvorder.CurrentRow.Cells["RealPrice"].Value.ToString();

                ListViewItem item = new ListViewItem(color);
                item.SubItems.Add(size);
                item.SubItems.Add(quantity);
                item.SubItems.Add(price);

                lvorder.Items.Add(item);

                txtbxprice.Text = price;
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void btnremovefromcart_Click(object sender, EventArgs e)
        {
            if (lvorder.SelectedItems.Count > 0)
            {
                lvorder.Items.Remove(lvorder.SelectedItems[0]);
            }
        }

        private void btntotal_Click(object sender, EventArgs e)

        {
            decimal grandTotal = 0;

            foreach (ListViewItem item in lvorder.Items)
            {
                int quantity = Convert.ToInt32(item.SubItems[2].Text);
                decimal price = Convert.ToDecimal(item.SubItems[3].Text);

                grandTotal += quantity * price;
            }

            txtbxtotal.Text = grandTotal.ToString("0.00");
        }

        private void btnoderconfirm_Click(object sender, EventArgs e)


        {
            OrderService service = new OrderService();

            int userId = Convert.ToInt32(lbluserids.Text);

            foreach (ListViewItem item in lvorder.Items)
            {
                string productName = cmbbxproductname.Text;
                int quantity = Convert.ToInt32(item.SubItems[2].Text);
                decimal price = Convert.ToDecimal(item.SubItems[3].Text);
                decimal total = quantity * price;

                service.SaveOrder(userId, productName, quantity, price, total);
            }

            MessageBox.Show("Order Saved Successfully!");
        }
    }
}




