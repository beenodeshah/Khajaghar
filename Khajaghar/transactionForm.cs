﻿using System;
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
        public transactionForm()
        {

            InitializeComponent();
            dgvCustomerDetails.DataSource = cc.getcustomerAccount();


        }
    }
}
