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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
            dgvUserDetails.DataSource = uc.getAllUsers();
        }
        userClass uc = new userClass();
        int userId;
       
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = uc.manageUsers(0,
                    txtUserName.Text,
                    txtPassword.Text,
                    cmbRole.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("User Successfully Created");
                    dgvUserDetails.DataSource = uc.getAllUsers();
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = uc.manageUsers(userId,
                    txtUserName.Text,
                    txtPassword.Text,
                    cmbRole.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("User Successfully Updated");
                    dgvUserDetails.DataSource = uc.getAllUsers();
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

        private void dgvUserDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = int.Parse(dgvUserDetails.SelectedRows[0].Cells["userId"].Value.ToString());
            txtUserName.Text = dgvUserDetails.SelectedRows[0].Cells["userName"].Value.ToString();
            txtPassword.Text = dgvUserDetails.SelectedRows[0].Cells["password"].Value.ToString();
            txtConfirmPassword.Text = txtPassword.Text;
            cmbRole.Text = dgvUserDetails.SelectedRows[0].Cells["role"].Value.ToString();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = uc.manageUsers(userId,
                    txtUserName.Text,
                    txtPassword.Text,
                    cmbRole.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("User Successfully Deleted");
                    dgvUserDetails.DataSource = uc.getAllUsers();
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
