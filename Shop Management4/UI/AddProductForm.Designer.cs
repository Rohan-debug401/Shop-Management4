namespace Shop_Management4.UI
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.cmbbxtype = new System.Windows.Forms.ComboBox();
            this.txtbxproductname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(231, 113);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(39, 16);
            this.lbltype.TabIndex = 1;
            this.lbltype.Text = "Type";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(177, 213);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(93, 16);
            this.lblproductname.TabIndex = 2;
            this.lblproductname.Text = "Product Name";
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(312, 316);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(124, 23);
            this.btnaddproduct.TabIndex = 3;
            this.btnaddproduct.Text = "Add Product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click_1);
            // 
            // cmbbxtype
            // 
            this.cmbbxtype.FormattingEnabled = true;
            this.cmbbxtype.Location = new System.Drawing.Point(333, 113);
            this.cmbbxtype.Name = "cmbbxtype";
            this.cmbbxtype.Size = new System.Drawing.Size(345, 24);
            this.cmbbxtype.TabIndex = 4;
            // 
            // txtbxproductname
            // 
            this.txtbxproductname.Location = new System.Drawing.Point(333, 213);
            this.txtbxproductname.Name = "txtbxproductname";
            this.txtbxproductname.Size = new System.Drawing.Size(345, 22);
            this.txtbxproductname.TabIndex = 5;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxproductname);
            this.Controls.Add(this.cmbbxtype);
            this.Controls.Add(this.btnaddproduct);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.ComboBox cmbbxtype;
        private System.Windows.Forms.TextBox txtbxproductname;
    }
}