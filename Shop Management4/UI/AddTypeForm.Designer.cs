namespace Shop_Management4.UI
{
    partial class AddTypeForm
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
            this.btninserttype = new System.Windows.Forms.Button();
            this.txtbxtype = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Type";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(211, 203);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(39, 16);
            this.lbltype.TabIndex = 1;
            this.lbltype.Text = "Type";
            // 
            // btninserttype
            // 
            this.btninserttype.Location = new System.Drawing.Point(348, 372);
            this.btninserttype.Name = "btninserttype";
            this.btninserttype.Size = new System.Drawing.Size(75, 23);
            this.btninserttype.TabIndex = 2;
            this.btninserttype.Text = "Insert Type";
            this.btninserttype.UseVisualStyleBackColor = true;
            this.btninserttype.Click += new System.EventHandler(this.btninserttype_Click);
            // 
            // txtbxtype
            // 
            this.txtbxtype.Location = new System.Drawing.Point(290, 203);
            this.txtbxtype.Name = "txtbxtype";
            this.txtbxtype.Size = new System.Drawing.Size(292, 22);
            this.txtbxtype.TabIndex = 3;
            // 
            // AddTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxtype);
            this.Controls.Add(this.btninserttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label1);
            this.Name = "AddTypeForm";
            this.Text = "AddTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button btninserttype;
        private System.Windows.Forms.TextBox txtbxtype;
    }
}