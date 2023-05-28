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
    public partial class categoryForm : Form
    {
        public categoryForm()
        {
            InitializeComponent();
            dgvCategoryDetails.DataSource=cc.getAllCategories();
        }
        categoryClass cc= new categoryClass();
        int categoryId;
        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = cc.manageCategories(categoryId, 
                    txtCategoryName.Text, 
                    txtDescription.Text, 1);
                if(rs==true)
                {
                    MessageBox.Show("Category Successfully Created!");
                    dgvCategoryDetails.DataSource = cc.getAllCategories();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCategoryDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryId = int.Parse(dgvCategoryDetails.SelectedRows[0].Cells["categoryId"].Value.ToString());
            txtCategoryName.Text = dgvCategoryDetails.SelectedRows[0].Cells["categoryName"].Value.ToString();
            txtDescription.Text = dgvCategoryDetails.SelectedRows[0].Cells["description"].Value.ToString();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = cc.manageCategories(categoryId,
                    txtCategoryName.Text,
                    txtDescription.Text, 2);
                if (rs == true)
                {
                    MessageBox.Show("Category Successfully Updated!");
                    dgvCategoryDetails.DataSource = cc.getAllCategories();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = cc.manageCategories(categoryId,
                    txtCategoryName.Text,
                    txtDescription.Text, 3);
                if (rs == true)
                {
                    MessageBox.Show("Category Successfully Deleted!");
                    dgvCategoryDetails.DataSource = cc.getAllCategories();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
