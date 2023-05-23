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
        }
userClass uc=new userClass();
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = uc.manageUsers(0, 
                    txtUserName.Text,
                    txtPassword.Text, 
                    cmbRole.Text, 1);
                if(result==true)
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
    }
}
