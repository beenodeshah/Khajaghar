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
    }
}
