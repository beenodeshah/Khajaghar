﻿using DataAccessLayer;
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
            cmbCategory.DataSource = cc.getAllCategories();
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
            cmbCategory.SelectedIndex = -1;
            cmbFoodItemName.DataSource = ic.menuItemsDetails();
            cmbFoodItemName.DisplayMember = "itemName";
            cmbFoodItemName.ValueMember = "menuItemId";
            cmbFoodItemName.SelectedIndex = -1;
            dgvKOTDetails.DataSource = kc.getAllKOT();
        }
        categoryClass cc = new categoryClass();
        itemClass ic = new itemClass();
        KOTClass kc = new KOTClass();
        orderClass oc = new orderClass();
        billClass bc=new billClass();
        int KOTId = 0, orderId = 0;
        Double discount,grandTotal,netTotal;
        String paymentType = "";
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
                if (result)
                {
                    MessageBox.Show("KOT : " + kc.getMaxKOT() + "  Successfully Created!!!");
                    dgvKOTDetails.DataSource = kc.getAllKOT();
                    lblKOTNumber.Text = kc.getMaxKOT().ToString();
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

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = oc.manageOrders(orderId,
                    int.Parse(lblKOTNumber.Text),
                    int.Parse(cmbFoodItemName.SelectedValue.ToString()),
                    double.Parse(txtQuantity.Text), txtRemarks.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("Order successfully placed!!!");
                    dgvOrderDetails.DataSource = oc.getAllOrdersByKOT(int.Parse(lblKOTNumber.Text));
                    getTotalAmount();
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

        private void rdbCredit_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Credit";
            transactionForm frm = new transactionForm();
            frm.txtAmount.Text = txtNetTotal.Text;
            frm.ShowDialog();
        }

        private void btnSaveBillAndPrint_Click(object sender, EventArgs e)
        {
            try
            {
                bool result=bc.manageBills(0,
                    int.Parse(lblKOTNumber.Text),
                    paymentType,
                    Double.Parse(txtGrandTotal.Text),
                    Double.Parse(txtDiscount.Text), 1);
                if(result==true) { MessageBox.Show("Bill Successfully Saved!!!");
                    dgvOrderDetails.DataSource=null;
                    lblKOTNumber.Text = "0";
                    dgvKOTDetails.DataSource = kc.getAllKOT();
                    
                }
                else { MessageBox.Show("Error in performing the required operation!!!"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Cash";
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (txtDiscount.Text == "")
                {
                    discount = 0;
                    txtNetTotal.Text = grandTotal.ToString();
                }
                else
                {
                   discount = double.Parse(txtDiscount.Text);
                   
                }
                Double netTotal = grandTotal - discount;
                txtNetTotal.Text = netTotal.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void dgvKOTDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblKOTNumber.Text = dgvKOTDetails.SelectedRows[0].Cells["KOTId"].Value.ToString();
            dgvOrderDetails.DataSource = oc.getAllOrdersByKOT(int.Parse(lblKOTNumber.Text));
            getTotalAmount();
        }

        public void getTotalAmount()
        {
             grandTotal = 0;
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                grandTotal += Double.Parse(dgvOrderDetails.Rows[i].Cells["amount"].Value.ToString());
            }
            txtGrandTotal.Text = grandTotal.ToString();
            txtNetTotal.Text = txtGrandTotal.Text;
        }
    }
}
