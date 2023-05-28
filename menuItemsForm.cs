using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
namespace Khajaghar
{
    public partial class menuItemsForm : Form
    {
        public menuItemsForm()
        {
            InitializeComponent();
            dgvItemDetails.DataSource = ic.menuItemsDetails();
            cmbCategory.DataSource = cc.getAllCategories();
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
            cmbCategory.SelectedIndex = -1;
        }
        itemClass ic = new itemClass();
        categoryClass cc = new categoryClass();
        int itemId;
        
        private void btnCreateMenuItems_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = ic.manageItems(itemId,
                    int.Parse(cmbCategory.SelectedValue.ToString()), 
                    txtItemName.Text,
                    double.Parse(txtRate.Text), 
                    txtRemarks.Text,    
                    1);
                if(rs==true)
                {
                    MessageBox.Show("Menu Item Successfully Created");
                    dgvItemDetails.DataSource = ic.menuItemsDetails();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvItemDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemId = int.Parse(dgvItemDetails.SelectedRows[0].Cells["menuItemId"].Value.ToString());
            cmbCategory.Text = dgvItemDetails.SelectedRows[0].Cells["categoryName"].Value.ToString();
            txtItemName.Text = dgvItemDetails.SelectedRows[0].Cells["itemName"].Value.ToString();
            txtRate.Text = dgvItemDetails.SelectedRows[0].Cells["rate"].Value.ToString();
            txtRemarks.Text = dgvItemDetails.SelectedRows[0].Cells["remarks"].Value.ToString();
        }

        private void btnEditMenuItems_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = ic.manageItems(itemId,
                    int.Parse(cmbCategory.SelectedValue.ToString()),
                    txtItemName.Text,
                    double.Parse(txtRate.Text),
                    txtRemarks.Text,
                    2);
                if (rs == true)
                {
                    MessageBox.Show("Menu Item Successfully Updated");
                    dgvItemDetails.DataSource = ic.menuItemsDetails();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteMenuItems_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = ic.manageItems(itemId,
                    int.Parse(cmbCategory.SelectedValue.ToString()),
                    txtItemName.Text,
                    double.Parse(txtRate.Text),
                    txtRemarks.Text,
                    3);
                if (rs == true)
                {
                    MessageBox.Show("Menu Item Successfully Deleted");
                    dgvItemDetails.DataSource = ic.menuItemsDetails();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
