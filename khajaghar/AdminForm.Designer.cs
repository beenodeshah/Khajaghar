namespace Khajaghar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodItemCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.foodItemCategoryToolStripMenuItem,
            this.menuItemsToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageUsersToolStripMenuItem.Image")));
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(197, 36);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // foodItemCategoryToolStripMenuItem
            // 
            this.foodItemCategoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.foodItemCategoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("foodItemCategoryToolStripMenuItem.Image")));
            this.foodItemCategoryToolStripMenuItem.Name = "foodItemCategoryToolStripMenuItem";
            this.foodItemCategoryToolStripMenuItem.Size = new System.Drawing.Size(260, 36);
            this.foodItemCategoryToolStripMenuItem.Text = "Food Item Category";
            this.foodItemCategoryToolStripMenuItem.Click += new System.EventHandler(this.foodItemCategoryToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // menuItemsToolStripMenuItem
            // 
            this.menuItemsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuItemsToolStripMenuItem.Image")));
            this.menuItemsToolStripMenuItem.Name = "menuItemsToolStripMenuItem";
            this.menuItemsToolStripMenuItem.Size = new System.Drawing.Size(172, 36);
            this.menuItemsToolStripMenuItem.Text = "Menu Items";
            this.menuItemsToolStripMenuItem.Click += new System.EventHandler(this.menuItemsToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 615);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "Khajabhar Billing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodItemCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}