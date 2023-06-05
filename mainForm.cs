using DataAccessLayer;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString();
            cmbCategory.DataSource=cc.getAllCategories();
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
            cmbCategory.SelectedIndex = -1;
            cmbFoodItemName.DataSource = ic.menuItemsDetails();
            cmbFoodItemName.DisplayMember = "itemName";
            cmbFoodItemName.ValueMember = "menuItemId";
            cmbFoodItemName.SelectedIndex = -1;
        }
        categoryClass cc=new categoryClass();
        itemClass ic = new itemClass();
        KOTClass kc= new KOTClass();
        int KOTId = 0;
        private void tmDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    cmbFoodItemName.DataSource = ic.getItemsByCategory(int.Parse(cmbCategory.SelectedValue.ToString()));
            //    cmbFoodItemName.DisplayMember = "itemName";
            //    cmbFoodItemName.ValueMember = "menuItemId";
                
            //}
            //catch (Exception)
            //{

              
            //}
        }

        private void btnCreateKOT_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = kc.manageKOTs(KOTId, DateTime.Parse(dtpKOTDate.Text), txtKOTBy.Text, 1);
                if(result) {
                    MessageBox.Show("KOT : " + kc.getMaxKOT() + "  Successfully Created!!!");
                    dgvKOTDetails.DataSource = kc.getAllKOT();
                    lblKOTNumber.Text=kc.getMaxKOT().ToString();
                }
                else
                {
                    MessageBox.Show("Error in performing the required operation!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
