using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khajaghar
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm frm=new userForm();
            frm.ShowDialog();
        }

        private void foodItemCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryForm frm=new categoryForm();
            frm.ShowDialog();
        }

        private void menuItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemsForm frm=new menuItemsForm();  
            frm.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerForm frm=new customerForm();
            frm.ShowDialog();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
