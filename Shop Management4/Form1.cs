using Shop_Management4.UI;
using System;
using System.Windows.Forms;

namespace Shop_Management4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(new UserForm());
        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(new AddTypeForm());
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(new AddProductForm());
        }

        private void addSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(new AddSize());
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleChild(new UserLoginForm());
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void OpenSingleChild(Form child)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            child.MdiParent = this;
            child.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
