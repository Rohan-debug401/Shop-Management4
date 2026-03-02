namespace Shop_Management4.UI
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unorderedProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unorderedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.allOrdersToolStripMenuItem,
            this.unorderedProductsToolStripMenuItem,
            this.unorderedUsersToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.allProductsToolStripMenuItem.Text = "All Products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.allOrdersToolStripMenuItem.Text = "All Orders";
            // 
            // unorderedProductsToolStripMenuItem
            // 
            this.unorderedProductsToolStripMenuItem.Name = "unorderedProductsToolStripMenuItem";
            this.unorderedProductsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.unorderedProductsToolStripMenuItem.Text = "Unordered Products ";
            // 
            // unorderedUsersToolStripMenuItem
            // 
            this.unorderedUsersToolStripMenuItem.Name = "unorderedUsersToolStripMenuItem";
            this.unorderedUsersToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.unorderedUsersToolStripMenuItem.Text = "Unordered Users";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 493);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unorderedProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unorderedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}