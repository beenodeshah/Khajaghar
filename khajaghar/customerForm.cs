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
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
            dgvCustomerDetails.DataSource = cc.getAllCustomers();
            dgvCustomerDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
        }
        customerClass cc=new customerClass();
        int customerId;
        private void btnAddCustomerDetails_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = cc.manageCustomers(customerId,
                    txtCustomerName.Text,
                    txtAddress.Text,
                    txtMobileNo.Text,
                    txtEmail.Text,
                    txtIdentificationType.Text,
                    txtIdentificationNumber.Text,
                    1);
                if(result==true)
                {
                    MessageBox.Show("Customer Details Successfully Saved!");
                    dgvCustomerDetails.DataSource = cc.getAllCustomers();
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

        private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerId = int.Parse(dgvCustomerDetails.SelectedRows[0].Cells["Id"].Value.ToString());
            txtCustomerName.Text = dgvCustomerDetails.SelectedRows[0].Cells["Name"].Value.ToString();
            txtAddress.Text= dgvCustomerDetails.SelectedRows[0].Cells["Address"].Value.ToString();
            txtMobileNo.Text= dgvCustomerDetails.SelectedRows[0].Cells["Mobile"].Value.ToString();
            txtEmail.Text= dgvCustomerDetails.SelectedRows[0].Cells["Email"].Value.ToString();
            txtIdentificationType.Text= dgvCustomerDetails.SelectedRows[0].Cells["ID Type"].Value.ToString();
            txtIdentificationNumber.Text= dgvCustomerDetails.SelectedRows[0].Cells["ID Number"].Value.ToString();
        }

        private void btnEditCustomerDetails_Click(object sender, EventArgs e)
        {

            try
            {
                bool result = cc.manageCustomers(customerId,
                    txtCustomerName.Text,
                    txtAddress.Text,
                    txtMobileNo.Text,
                    txtEmail.Text,
                    txtIdentificationType.Text,
                    txtIdentificationNumber.Text,
                    2);
                if (result == true)
                {
                    MessageBox.Show("Customer Details Successfully Updated!");
                    dgvCustomerDetails.DataSource = cc.getAllCustomers();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                bool result = cc.manageCustomers(customerId,
                    txtCustomerName.Text,
                    txtAddress.Text,
                    txtMobileNo.Text,
                    txtEmail.Text,
                    txtIdentificationType.Text,
                    txtIdentificationNumber.Text,
                   3);
                if (result == true)
                {
                    MessageBox.Show("Customer Details Successfully Deleted!");
                    dgvCustomerDetails.DataSource = cc.getAllCustomers();
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
