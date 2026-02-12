namespace Shop_Management4.UI
{
    partial class UserLoginForm
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.cmbbxtype = new System.Windows.Forms.ComboBox();
            this.txtbxemailusername = new System.Windows.Forms.TextBox();
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemailusername = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(463, 313);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(322, 314);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 16;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // cmbbxtype
            // 
            this.cmbbxtype.FormattingEnabled = true;
            this.cmbbxtype.Location = new System.Drawing.Point(373, 116);
            this.cmbbxtype.Name = "cmbbxtype";
            this.cmbbxtype.Size = new System.Drawing.Size(266, 24);
            this.cmbbxtype.TabIndex = 15;
            // 
            // txtbxemailusername
            // 
            this.txtbxemailusername.Location = new System.Drawing.Point(373, 175);
            this.txtbxemailusername.Name = "txtbxemailusername";
            this.txtbxemailusername.Size = new System.Drawing.Size(266, 22);
            this.txtbxemailusername.TabIndex = 14;
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(373, 233);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.Size = new System.Drawing.Size(266, 22);
            this.txtbxpassword.TabIndex = 13;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(248, 239);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "Password";
            // 
            // lblemailusername
            // 
            this.lblemailusername.AutoSize = true;
            this.lblemailusername.Location = new System.Drawing.Point(248, 178);
            this.lblemailusername.Name = "lblemailusername";
            this.lblemailusername.Size = new System.Drawing.Size(117, 16);
            this.lblemailusername.TabIndex = 11;
            this.lblemailusername.Text = "Email / UserName";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(248, 119);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(39, 16);
            this.lbltype.TabIndex = 10;
            this.lbltype.Text = "Type";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(342, 39);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(40, 16);
            this.lbllogin.TabIndex = 9;
            this.lbllogin.Text = "Login";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.cmbbxtype);
            this.Controls.Add(this.txtbxemailusername);
            this.Controls.Add(this.txtbxpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemailusername);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lbllogin);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ComboBox cmbbxtype;
        private System.Windows.Forms.TextBox txtbxemailusername;
        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemailusername;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lbllogin;
    }
}