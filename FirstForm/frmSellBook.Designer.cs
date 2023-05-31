namespace FirstForm
{
    partial class frmSellBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txSBillNo = new System.Windows.Forms.TextBox();
            this.txDueAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txIName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbICode = new System.Windows.Forms.ComboBox();
            this.lstIName = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optCredit = new System.Windows.Forms.RadioButton();
            this.optCash = new System.Windows.Forms.RadioButton();
            this.txTotalBill = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txDiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lstAmount = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txNet = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lstICode = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txSBillNo);
            this.groupBox1.Controls.Add(this.txDueAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txMobileNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txCity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txCustName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCustNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // txSBillNo
            // 
            this.txSBillNo.Location = new System.Drawing.Point(835, 63);
            this.txSBillNo.Name = "txSBillNo";
            this.txSBillNo.Size = new System.Drawing.Size(147, 20);
            this.txSBillNo.TabIndex = 15;
            this.txSBillNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSBillNo_KeyPress);
            // 
            // txDueAmount
            // 
            this.txDueAmount.Location = new System.Drawing.Point(617, 63);
            this.txDueAmount.Name = "txDueAmount";
            this.txDueAmount.Size = new System.Drawing.Size(147, 20);
            this.txDueAmount.TabIndex = 13;
            this.txDueAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDueAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Due Amount";
            // 
            // txMobileNo
            // 
            this.txMobileNo.Location = new System.Drawing.Point(101, 63);
            this.txMobileNo.Name = "txMobileNo";
            this.txMobileNo.Size = new System.Drawing.Size(147, 20);
            this.txMobileNo.TabIndex = 11;
            this.txMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txMobileNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mobile No.";
            // 
            // txCity
            // 
            this.txCity.Location = new System.Drawing.Point(369, 63);
            this.txCity.Name = "txCity";
            this.txCity.Size = new System.Drawing.Size(147, 20);
            this.txCity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "City";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(617, 25);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(147, 20);
            this.txAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // txCustName
            // 
            this.txCustName.Location = new System.Drawing.Point(369, 24);
            this.txCustName.Name = "txCustName";
            this.txCustName.Size = new System.Drawing.Size(147, 20);
            this.txCustName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(835, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(147, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer No.";
            // 
            // cmbCustNo
            // 
            this.cmbCustNo.FormattingEnabled = true;
            this.cmbCustNo.Location = new System.Drawing.Point(101, 24);
            this.cmbCustNo.Name = "cmbCustNo";
            this.cmbCustNo.Size = new System.Drawing.Size(147, 21);
            this.cmbCustNo.TabIndex = 0;
            this.cmbCustNo.SelectedIndexChanged += new System.EventHandler(this.cmbCustNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sell Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txAmount);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txQty);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txIName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbICode);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items Info";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(667, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Amount";
            // 
            // txAmount
            // 
            this.txAmount.Location = new System.Drawing.Point(638, 51);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(147, 20);
            this.txAmount.TabIndex = 24;
            this.txAmount.Text = "0";
            this.txAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txAmount_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(812, 52);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 26);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(812, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 26);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Quantity";
            // 
            // txQty
            // 
            this.txQty.Location = new System.Drawing.Point(481, 52);
            this.txQty.Name = "txQty";
            this.txQty.Size = new System.Drawing.Size(147, 20);
            this.txQty.TabIndex = 18;
            this.txQty.Text = "0";
            this.txQty.Leave += new System.EventHandler(this.txQty_Leave);
            this.txQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQty_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Price";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(328, 52);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(147, 20);
            this.txPrice.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Item Name";
            // 
            // txIName
            // 
            this.txIName.Location = new System.Drawing.Point(175, 52);
            this.txIName.Name = "txIName";
            this.txIName.Size = new System.Drawing.Size(147, 20);
            this.txIName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Item Code";
            // 
            // cmbICode
            // 
            this.cmbICode.FormattingEnabled = true;
            this.cmbICode.Location = new System.Drawing.Point(22, 51);
            this.cmbICode.Name = "cmbICode";
            this.cmbICode.Size = new System.Drawing.Size(147, 21);
            this.cmbICode.TabIndex = 2;
            this.cmbICode.SelectedIndexChanged += new System.EventHandler(this.cmbICode_SelectedIndexChanged);
            // 
            // lstIName
            // 
            this.lstIName.FormattingEnabled = true;
            this.lstIName.Location = new System.Drawing.Point(188, 239);
            this.lstIName.Name = "lstIName";
            this.lstIName.Size = new System.Drawing.Size(146, 82);
            this.lstIName.TabIndex = 4;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(341, 239);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(146, 82);
            this.lstPrice.TabIndex = 5;
            // 
            // lstQty
            // 
            this.lstQty.FormattingEnabled = true;
            this.lstQty.Location = new System.Drawing.Point(494, 239);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(146, 82);
            this.lstQty.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optCredit);
            this.groupBox3.Controls.Add(this.optCash);
            this.groupBox3.Location = new System.Drawing.Point(34, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 69);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Mode";
            // 
            // optCredit
            // 
            this.optCredit.AutoSize = true;
            this.optCredit.Location = new System.Drawing.Point(21, 42);
            this.optCredit.Name = "optCredit";
            this.optCredit.Size = new System.Drawing.Size(57, 17);
            this.optCredit.TabIndex = 1;
            this.optCredit.TabStop = true;
            this.optCredit.Text = "Credits";
            this.optCredit.UseVisualStyleBackColor = true;
            this.optCredit.CheckedChanged += new System.EventHandler(this.optCredit_CheckedChanged);
            // 
            // optCash
            // 
            this.optCash.AutoSize = true;
            this.optCash.Location = new System.Drawing.Point(21, 19);
            this.optCash.Name = "optCash";
            this.optCash.Size = new System.Drawing.Size(49, 17);
            this.optCash.TabIndex = 0;
            this.optCash.TabStop = true;
            this.optCash.Text = "Cash";
            this.optCash.UseVisualStyleBackColor = true;
            this.optCash.CheckedChanged += new System.EventHandler(this.optCash_CheckedChanged);
            // 
            // txTotalBill
            // 
            this.txTotalBill.Location = new System.Drawing.Point(650, 327);
            this.txTotalBill.Name = "txTotalBill";
            this.txTotalBill.Size = new System.Drawing.Size(147, 20);
            this.txTotalBill.TabIndex = 11;
            this.txTotalBill.Text = "0";
            this.txTotalBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTotalBill_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(599, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total Bill";
            // 
            // txDiscount
            // 
            this.txDiscount.Location = new System.Drawing.Point(649, 353);
            this.txDiscount.Name = "txDiscount";
            this.txDiscount.Size = new System.Drawing.Size(147, 20);
            this.txDiscount.TabIndex = 13;
            this.txDiscount.Text = "0";
            this.txDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDiscount_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(598, 356);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Discount";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(824, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 26);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(392, 430);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 26);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstAmount
            // 
            this.lstAmount.FormattingEnabled = true;
            this.lstAmount.Location = new System.Drawing.Point(651, 239);
            this.lstAmount.Name = "lstAmount";
            this.lstAmount.Size = new System.Drawing.Size(146, 82);
            this.lstAmount.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(603, 386);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Net Bill";
            // 
            // txNet
            // 
            this.txNet.Location = new System.Drawing.Point(649, 383);
            this.txNet.Name = "txNet";
            this.txNet.Size = new System.Drawing.Size(148, 20);
            this.txNet.TabIndex = 28;
            this.txNet.Text = "0";
            this.txNet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNet_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(802, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Bill No";
            // 
            // lstICode
            // 
            this.lstICode.FormattingEnabled = true;
            this.lstICode.Location = new System.Drawing.Point(34, 239);
            this.lstICode.Name = "lstICode";
            this.lstICode.Size = new System.Drawing.Size(146, 82);
            this.lstICode.TabIndex = 29;
            // 
            // frmSellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 478);
            this.Controls.Add(this.lstICode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txNet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lstAmount);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txDiscount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txTotalBill);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstQty);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstIName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSellBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellBook";
            this.Load += new System.EventHandler(this.frmSellBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCustName;
        private System.Windows.Forms.TextBox txMobileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDueAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txIName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbICode;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstIName;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstQty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optCredit;
        private System.Windows.Forms.RadioButton optCash;
        private System.Windows.Forms.TextBox txTotalBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.ListBox lstAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txNet;
        private System.Windows.Forms.TextBox txSBillNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstICode;
    }
}