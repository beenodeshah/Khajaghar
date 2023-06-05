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
        }

        private void tmDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
