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
    public partial class transactionForm : Form
    {
        customerClass cc = new customerClass();
        transactionClass tc = new transactionClass();
        public transactionForm()
        {

            InitializeComponent();
            dgvCustomerDetails.DataSource = cc.getcustomerAccount();
            dgvAccountDetails.DataSource = tc.getAllTransactions();

        }
        int transactionId = 0;
        private void txtSearchAccountNumber_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerDetails.DataSource = cc.getcustomerAccountByAccountNumber(txtSearchAccountNumber.Text);

        }

        private void dgvCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchAccountNumber.Text = dgvCustomerDetails.SelectedRows[0].Cells["AccountNumber"].Value.ToString();
            dgvAccountDetails.DataSource = tc.getAllTransactionsByAccountNumber(txtSearchAccountNumber.Text);
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = tc.manageTransactions(transactionId,
                    txtSearchAccountNumber.Text,
                    cmbTransactionType.Text,
                    Double.Parse(txtAmount.Text),
                    txtRemarks.Text, 1);
                if (result)
                {
                    MessageBox.Show("Transaction Successfully Recorded");
                    dgvAccountDetails.DataSource = tc.getAllTransactionsByAccountNumber(txtSearchAccountNumber.Text);
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

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = tc.manageTransactions(transactionId,
                    txtSearchAccountNumber.Text,
                    cmbTransactionType.Text,
                    Double.Parse(txtAmount.Text),
                    txtRemarks.Text, 2);
                if (result)
                {
                    MessageBox.Show("Transaction Successfully Updated");
                    dgvAccountDetails.DataSource = tc.getAllTransactionsByAccountNumber(txtSearchAccountNumber.Text);
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

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = tc.manageTransactions(transactionId,
                    txtSearchAccountNumber.Text,
                    cmbTransactionType.Text,
                    Double.Parse(txtAmount.Text),
                    txtRemarks.Text, 3);
                if (result)
                {
                    MessageBox.Show("Transaction Successfully Deleted");
                    dgvAccountDetails.DataSource = tc.getAllTransactionsByAccountNumber(txtSearchAccountNumber.Text);
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

        private void dgvAccountDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            transactionId = int.Parse(dgvAccountDetails.SelectedRows[0].Cells["transactionId"].Value.ToString());
            txtSearchAccountNumber.Text = dgvAccountDetails.SelectedRows[0].Cells["AccountNumber"].Value.ToString();
            cmbTransactionType.Text = dgvAccountDetails.SelectedRows[0].Cells["transactionType"].Value.ToString();
            txtAmount.Text = dgvAccountDetails.SelectedRows[0].Cells["amount"].Value.ToString();
            txtRemarks.Text = dgvAccountDetails.SelectedRows[0].Cells["remarks"].Value.ToString();
        }
    }
}
