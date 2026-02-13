namespace Shop_Management4.UI
{
    partial class ProfileForm
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
            this.lblprofile = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprofile
            // 
            this.lblprofile.AutoSize = true;
            this.lblprofile.Location = new System.Drawing.Point(374, 43);
            this.lblprofile.Name = "lblprofile";
            this.lblprofile.Size = new System.Drawing.Size(45, 16);
            this.lblprofile.TabIndex = 0;
            this.lblprofile.Text = "Profile";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(283, 144);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(283, 203);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 16);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(283, 256);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(55, 16);
            this.lblnumber.TabIndex = 3;
            this.lblnumber.Text = "Number";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(472, 143);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(41, 16);
            this.txtname.TabIndex = 4;
            this.txtname.Text = "name";
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(472, 203);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(40, 16);
            this.txtemail.TabIndex = 5;
            this.txtemail.Text = "email";
            // 
            // txtnumber
            // 
            this.txtnumber.AutoSize = true;
            this.txtnumber.Location = new System.Drawing.Point(472, 256);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(52, 16);
            this.txtnumber.TabIndex = 6;
            this.txtnumber.Text = "number";
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(358, 350);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 23);
            this.btnchange.TabIndex = 7;
            this.btnchange.Text = "Save Change";
            this.btnchange.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 479);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblprofile);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprofile;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtnumber;
        private System.Windows.Forms.Button btnchange;
    }
}