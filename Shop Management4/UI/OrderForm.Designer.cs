namespace Shop_Management4.UI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.cmbbxtype = new System.Windows.Forms.ComboBox();
            this.cmbbxproductname = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtbxprice = new System.Windows.Forms.TextBox();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.btnremovefromcart = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblemails = new System.Windows.Forms.Label();
            this.lbluserids = new System.Windows.Forms.Label();
            this.lblnames = new System.Windows.Forms.Label();
            this.btntotal = new System.Windows.Forms.Button();
            this.txtbxtotal = new System.Windows.Forms.TextBox();
            this.btnoderconfirm = new System.Windows.Forms.Button();
            this.dgvorder = new System.Windows.Forms.DataGridView();
            this.lvorder = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(152, 428);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(313, 428);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // cmbbxtype
            // 
            this.cmbbxtype.FormattingEnabled = true;
            this.cmbbxtype.Location = new System.Drawing.Point(152, 46);
            this.cmbbxtype.Name = "cmbbxtype";
            this.cmbbxtype.Size = new System.Drawing.Size(236, 24);
            this.cmbbxtype.TabIndex = 2;
            this.cmbbxtype.SelectedIndexChanged += new System.EventHandler(this.cmbbxtype_SelectedIndexChanged);
            // 
            // cmbbxproductname
            // 
            this.cmbbxproductname.FormattingEnabled = true;
            this.cmbbxproductname.Location = new System.Drawing.Point(152, 100);
            this.cmbbxproductname.Name = "cmbbxproductname";
            this.cmbbxproductname.Size = new System.Drawing.Size(236, 24);
            this.cmbbxproductname.TabIndex = 3;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(85, 49);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(39, 16);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Type";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(31, 103);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(93, 16);
            this.lblproductname.TabIndex = 5;
            this.lblproductname.Text = "Product Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(66, 384);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(38, 16);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "Price";
            // 
            // txtbxprice
            // 
            this.txtbxprice.Location = new System.Drawing.Point(152, 381);
            this.txtbxprice.Name = "txtbxprice";
            this.txtbxprice.Size = new System.Drawing.Size(236, 22);
            this.txtbxprice.TabIndex = 7;
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.Location = new System.Drawing.Point(447, 204);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(100, 26);
            this.btnaddtocart.TabIndex = 8;
            this.btnaddtocart.Text = "Add To Cart";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            // 
            // btnremovefromcart
            // 
            this.btnremovefromcart.Location = new System.Drawing.Point(437, 268);
            this.btnremovefromcart.Name = "btnremovefromcart";
            this.btnremovefromcart.Size = new System.Drawing.Size(128, 25);
            this.btnremovefromcart.TabIndex = 9;
            this.btnremovefromcart.Text = "Remove from Cart";
            this.btnremovefromcart.UseVisualStyleBackColor = true;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(602, 34);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(50, 16);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Name :";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(602, 79);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(55, 16);
            this.lbluserid.TabIndex = 11;
            this.lbluserid.Text = "UserID :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(605, 119);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 16);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "Email :";
            // 
            // lblemails
            // 
            this.lblemails.AutoSize = true;
            this.lblemails.Location = new System.Drawing.Point(758, 119);
            this.lblemails.Name = "lblemails";
            this.lblemails.Size = new System.Drawing.Size(48, 16);
            this.lblemails.TabIndex = 15;
            this.lblemails.Text = "Emails";
            // 
            // lbluserids
            // 
            this.lbluserids.AutoSize = true;
            this.lbluserids.Location = new System.Drawing.Point(755, 79);
            this.lbluserids.Name = "lbluserids";
            this.lbluserids.Size = new System.Drawing.Size(49, 16);
            this.lbluserids.TabIndex = 14;
            this.lbluserids.Text = "UserID";
            // 
            // lblnames
            // 
            this.lblnames.AutoSize = true;
            this.lblnames.Location = new System.Drawing.Point(755, 34);
            this.lblnames.Name = "lblnames";
            this.lblnames.Size = new System.Drawing.Size(51, 16);
            this.lblnames.TabIndex = 13;
            this.lblnames.Text = "Names";
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(574, 381);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(75, 23);
            this.btntotal.TabIndex = 16;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = true;
            // 
            // txtbxtotal
            // 
            this.txtbxtotal.Location = new System.Drawing.Point(684, 381);
            this.txtbxtotal.Name = "txtbxtotal";
            this.txtbxtotal.Size = new System.Drawing.Size(203, 22);
            this.txtbxtotal.TabIndex = 17;
            // 
            // btnoderconfirm
            // 
            this.btnoderconfirm.Location = new System.Drawing.Point(789, 428);
            this.btnoderconfirm.Name = "btnoderconfirm";
            this.btnoderconfirm.Size = new System.Drawing.Size(98, 23);
            this.btnoderconfirm.TabIndex = 18;
            this.btnoderconfirm.Text = "Oder Confirm";
            this.btnoderconfirm.UseVisualStyleBackColor = true;
            // 
            // dgvorder
            // 
            this.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorder.Location = new System.Drawing.Point(152, 179);
            this.dgvorder.Name = "dgvorder";
            this.dgvorder.RowHeadersWidth = 51;
            this.dgvorder.RowTemplate.Height = 24;
            this.dgvorder.Size = new System.Drawing.Size(236, 150);
            this.dgvorder.TabIndex = 19;
            // 
            // lvorder
            // 
            this.lvorder.HideSelection = false;
            this.lvorder.Location = new System.Drawing.Point(605, 179);
            this.lvorder.Name = "lvorder";
            this.lvorder.Size = new System.Drawing.Size(282, 150);
            this.lvorder.TabIndex = 20;
            this.lvorder.UseCompatibleStateImageBehavior = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 487);
            this.Controls.Add(this.lvorder);
            this.Controls.Add(this.dgvorder);
            this.Controls.Add(this.btnoderconfirm);
            this.Controls.Add(this.txtbxtotal);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.lblemails);
            this.Controls.Add(this.lbluserids);
            this.Controls.Add(this.lblnames);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnremovefromcart);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.txtbxprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.cmbbxproductname);
            this.Controls.Add(this.cmbbxtype);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnlogout);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox cmbbxtype;
        private System.Windows.Forms.ComboBox cmbbxproductname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtbxprice;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Button btnremovefromcart;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblemails;
        private System.Windows.Forms.Label lbluserids;
        private System.Windows.Forms.Label lblnames;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.TextBox txtbxtotal;
        private System.Windows.Forms.Button btnoderconfirm;
        private System.Windows.Forms.DataGridView dgvorder;
        private System.Windows.Forms.ListView lvorder;
    }
}