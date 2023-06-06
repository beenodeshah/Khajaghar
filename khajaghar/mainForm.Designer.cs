namespace Khajaghar
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKOTDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteKOT = new System.Windows.Forms.Button();
            this.btnEditKOT = new System.Windows.Forms.Button();
            this.btnCreateKOT = new System.Windows.Forms.Button();
            this.lblKOTNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKOTBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKOTDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.btnEditOrders = new System.Windows.Forms.Button();
            this.cmbFoodItemName = new System.Windows.Forms.ComboBox();
            this.btnAddOrders = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveBillAndPrint = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tmDateTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKOTDetails);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1375, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage KOTs";
            // 
            // dgvKOTDetails
            // 
            this.dgvKOTDetails.AllowUserToAddRows = false;
            this.dgvKOTDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            this.dgvKOTDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKOTDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKOTDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKOTDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKOTDetails.Location = new System.Drawing.Point(4, 74);
            this.dgvKOTDetails.Name = "dgvKOTDetails";
            this.dgvKOTDetails.ReadOnly = true;
            this.dgvKOTDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKOTDetails.Size = new System.Drawing.Size(1367, 221);
            this.dgvKOTDetails.TabIndex = 1;
            this.dgvKOTDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKOTDetails_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDeleteKOT);
            this.panel1.Controls.Add(this.btnEditKOT);
            this.panel1.Controls.Add(this.btnCreateKOT);
            this.panel1.Controls.Add(this.lblKOTNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtKOTBy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpKOTDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteKOT
            // 
            this.btnDeleteKOT.Location = new System.Drawing.Point(1245, -1);
            this.btnDeleteKOT.Name = "btnDeleteKOT";
            this.btnDeleteKOT.Size = new System.Drawing.Size(106, 50);
            this.btnDeleteKOT.TabIndex = 8;
            this.btnDeleteKOT.Text = "Delete KOT";
            this.btnDeleteKOT.UseVisualStyleBackColor = true;
            // 
            // btnEditKOT
            // 
            this.btnEditKOT.Location = new System.Drawing.Point(1129, -2);
            this.btnEditKOT.Name = "btnEditKOT";
            this.btnEditKOT.Size = new System.Drawing.Size(116, 50);
            this.btnEditKOT.TabIndex = 7;
            this.btnEditKOT.Text = "Edit KOT";
            this.btnEditKOT.UseVisualStyleBackColor = true;
            // 
            // btnCreateKOT
            // 
            this.btnCreateKOT.Location = new System.Drawing.Point(972, -1);
            this.btnCreateKOT.Name = "btnCreateKOT";
            this.btnCreateKOT.Size = new System.Drawing.Size(157, 50);
            this.btnCreateKOT.TabIndex = 6;
            this.btnCreateKOT.Text = "Create KOT";
            this.btnCreateKOT.UseVisualStyleBackColor = true;
            this.btnCreateKOT.Click += new System.EventHandler(this.btnCreateKOT_Click);
            // 
            // lblKOTNumber
            // 
            this.lblKOTNumber.AutoSize = true;
            this.lblKOTNumber.Location = new System.Drawing.Point(825, 18);
            this.lblKOTNumber.Name = "lblKOTNumber";
            this.lblKOTNumber.Size = new System.Drawing.Size(18, 20);
            this.lblKOTNumber.TabIndex = 5;
            this.lblKOTNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "KOT Number:";
            // 
            // txtKOTBy
            // 
            this.txtKOTBy.Location = new System.Drawing.Point(383, 13);
            this.txtKOTBy.Name = "txtKOTBy";
            this.txtKOTBy.Size = new System.Drawing.Size(314, 26);
            this.txtKOTBy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "KOT By:";
            // 
            // dtpKOTDate
            // 
            this.dtpKOTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKOTDate.Location = new System.Drawing.Point(95, 13);
            this.dtpKOTDate.Name = "dtpKOTDate";
            this.dtpKOTDate.Size = new System.Drawing.Size(200, 26);
            this.dtpKOTDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOT Date:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDeleteOrders);
            this.panel2.Controls.Add(this.btnEditOrders);
            this.panel2.Controls.Add(this.cmbFoodItemName);
            this.panel2.Controls.Add(this.btnAddOrders);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 80);
            this.panel2.TabIndex = 0;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(167, 38);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(879, 38);
            this.txtRemarks.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Remarks:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(946, 10);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity:";
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Location = new System.Drawing.Point(1261, -1);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(106, 73);
            this.btnDeleteOrders.TabIndex = 11;
            this.btnDeleteOrders.Text = "Delete Order";
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            // 
            // btnEditOrders
            // 
            this.btnEditOrders.Location = new System.Drawing.Point(1184, -3);
            this.btnEditOrders.Name = "btnEditOrders";
            this.btnEditOrders.Size = new System.Drawing.Size(75, 75);
            this.btnEditOrders.TabIndex = 10;
            this.btnEditOrders.Text = "Edit Order";
            this.btnEditOrders.UseVisualStyleBackColor = true;
            // 
            // cmbFoodItemName
            // 
            this.cmbFoodItemName.FormattingEnabled = true;
            this.cmbFoodItemName.Location = new System.Drawing.Point(520, 8);
            this.cmbFoodItemName.Name = "cmbFoodItemName";
            this.cmbFoodItemName.Size = new System.Drawing.Size(345, 28);
            this.cmbFoodItemName.TabIndex = 3;
            // 
            // btnAddOrders
            // 
            this.btnAddOrders.Location = new System.Drawing.Point(1052, -3);
            this.btnAddOrders.Name = "btnAddOrders";
            this.btnAddOrders.Size = new System.Drawing.Size(131, 75);
            this.btnAddOrders.TabIndex = 9;
            this.btnAddOrders.Text = "Add Items to Order";
            this.btnAddOrders.UseVisualStyleBackColor = true;
            this.btnAddOrders.Click += new System.EventHandler(this.btnAddOrders_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Food Item Name:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(167, 9);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(212, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Food Item Category:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1375, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Orders";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvOrderDetails);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1369, 195);
            this.panel3.TabIndex = 1;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(1369, 195);
            this.dgvOrderDetails.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnSaveBillAndPrint);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtNetTotal);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtGrandTotal);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 600);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1375, 51);
            this.panel4.TabIndex = 4;
            // 
            // btnSaveBillAndPrint
            // 
            this.btnSaveBillAndPrint.Location = new System.Drawing.Point(1133, -2);
            this.btnSaveBillAndPrint.Name = "btnSaveBillAndPrint";
            this.btnSaveBillAndPrint.Size = new System.Drawing.Size(228, 51);
            this.btnSaveBillAndPrint.TabIndex = 12;
            this.btnSaveBillAndPrint.Text = "Save Bill and Print";
            this.btnSaveBillAndPrint.UseVisualStyleBackColor = true;
            this.btnSaveBillAndPrint.Click += new System.EventHandler(this.btnSaveBillAndPrint_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.rdbCredit);
            this.panel5.Controls.Add(this.rdbCash);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(-2, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 51);
            this.panel5.TabIndex = 6;
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.Location = new System.Drawing.Point(207, 17);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(69, 24);
            this.rdbCredit.TabIndex = 9;
            this.rdbCredit.TabStop = true;
            this.rdbCredit.Text = "Credit";
            this.rdbCredit.UseVisualStyleBackColor = true;
            this.rdbCredit.CheckedChanged += new System.EventHandler(this.rdbCredit_CheckedChanged);
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(137, 17);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(64, 24);
            this.rdbCash.TabIndex = 8;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Cash";
            this.rdbCash.UseVisualStyleBackColor = true;
            this.rdbCash.CheckedChanged += new System.EventHandler(this.rdbCash_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Payment Mode:";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Enabled = false;
            this.txtNetTotal.Location = new System.Drawing.Point(866, 12);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(115, 26);
            this.txtNetTotal.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(783, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Net Total:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(666, 12);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(97, 26);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Discount Amount:";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(404, 12);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(114, 26);
            this.txtGrandTotal.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grand Total:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblDateTime);
            this.panel6.Controls.Add(this.lblUser);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(0, 651);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1375, 98);
            this.panel6.TabIndex = 5;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(1129, 12);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(77, 24);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "label13";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(133, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Guest";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "User Name:";
            // 
            // tmDateTime
            // 
            this.tmDateTime.Enabled = true;
            this.tmDateTime.Interval = 1000;
            this.tmDateTime.Tick += new System.EventHandler(this.tmDateTime_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khajaghar Billing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKOTDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKOTNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKOTBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKOTDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteKOT;
        private System.Windows.Forms.Button btnEditKOT;
        private System.Windows.Forms.Button btnCreateKOT;
        private System.Windows.Forms.DataGridView dgvKOTDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnEditOrders;
        private System.Windows.Forms.ComboBox cmbFoodItemName;
        private System.Windows.Forms.Button btnAddOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSaveBillAndPrint;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdbCredit;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer tmDateTime;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label12;
    }
}