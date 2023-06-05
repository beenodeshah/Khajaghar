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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodItemCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cross = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(110)))), ((int)(((byte)(82)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.foodItemCategoryToolStripMenuItem,
            this.menuItemsToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, -4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 9, 0, 9);
            this.menuStrip1.Size = new System.Drawing.Size(752, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(193, 33);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // foodItemCategoryToolStripMenuItem
            // 
            this.foodItemCategoryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodItemCategoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.foodItemCategoryToolStripMenuItem.Name = "foodItemCategoryToolStripMenuItem";
            this.foodItemCategoryToolStripMenuItem.Size = new System.Drawing.Size(255, 33);
            this.foodItemCategoryToolStripMenuItem.Text = "Food Item Category";
            this.foodItemCategoryToolStripMenuItem.Click += new System.EventHandler(this.foodItemCategoryToolStripMenuItem_Click);
            // 
            // menuItemsToolStripMenuItem
            // 
            this.menuItemsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuItemsToolStripMenuItem.Name = "menuItemsToolStripMenuItem";
            this.menuItemsToolStripMenuItem.Size = new System.Drawing.Size(159, 33);
            this.menuItemsToolStripMenuItem.Text = "Menu Items";
            this.menuItemsToolStripMenuItem.Click += new System.EventHandler(this.menuItemsToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(137, 33);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // cross
            // 
            this.cross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross.ForeColor = System.Drawing.SystemColors.Control;
            this.cross.Location = new System.Drawing.Point(315, 3);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(41, 39);
            this.cross.TabIndex = 7;
            this.cross.Text = "X";
            this.cross.UseVisualStyleBackColor = false;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(110)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.cross);
            this.panel1.Location = new System.Drawing.Point(745, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 51);
            this.panel1.TabIndex = 8;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(219)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khajabhar Billing System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodItemCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.Button cross;
        private System.Windows.Forms.Panel panel1;
    }
}