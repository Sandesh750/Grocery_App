namespace FirstForm
{
    partial class frmPurchase
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optCredit = new System.Windows.Forms.RadioButton();
            this.optCash = new System.Windows.Forms.RadioButton();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstIName = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txPBillNo = new System.Windows.Forms.TextBox();
            this.txDueAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txSuppName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSuppNo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txNet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lstAmount = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txDiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txTotalBill = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txQty = new System.Windows.Forms.TextBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txIName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbICode = new System.Windows.Forms.ComboBox();
            this.lstICode = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optCredit);
            this.groupBox3.Controls.Add(this.optCash);
            this.groupBox3.Location = new System.Drawing.Point(34, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 69);
            this.groupBox3.TabIndex = 37;
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
            // lstQty
            // 
            this.lstQty.FormattingEnabled = true;
            this.lstQty.Location = new System.Drawing.Point(494, 244);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(146, 82);
            this.lstQty.TabIndex = 35;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(341, 244);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(146, 82);
            this.lstPrice.TabIndex = 34;
            // 
            // lstIName
            // 
            this.lstIName.FormattingEnabled = true;
            this.lstIName.Location = new System.Drawing.Point(188, 244);
            this.lstIName.Name = "lstIName";
            this.lstIName.Size = new System.Drawing.Size(146, 82);
            this.lstIName.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txPBillNo);
            this.groupBox1.Controls.Add(this.txDueAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txMobileNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txCity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txSuppName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSuppNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 101);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(797, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Bill No";
            // 
            // txPBillNo
            // 
            this.txPBillNo.Location = new System.Drawing.Point(835, 63);
            this.txPBillNo.Name = "txPBillNo";
            this.txPBillNo.Size = new System.Drawing.Size(147, 20);
            this.txPBillNo.TabIndex = 15;
            // 
            // txDueAmount
            // 
            this.txDueAmount.Location = new System.Drawing.Point(617, 63);
            this.txDueAmount.Name = "txDueAmount";
            this.txDueAmount.Size = new System.Drawing.Size(147, 20);
            this.txDueAmount.TabIndex = 13;
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
            // txSuppName
            // 
            this.txSuppName.Location = new System.Drawing.Point(369, 24);
            this.txSuppName.Name = "txSuppName";
            this.txSuppName.Size = new System.Drawing.Size(147, 20);
            this.txSuppName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier Name";
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
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier No.";
            // 
            // cmbSuppNo
            // 
            this.cmbSuppNo.FormattingEnabled = true;
            this.cmbSuppNo.Location = new System.Drawing.Point(101, 24);
            this.cmbSuppNo.Name = "cmbSuppNo";
            this.cmbSuppNo.Size = new System.Drawing.Size(147, 21);
            this.cmbSuppNo.TabIndex = 0;
            this.cmbSuppNo.SelectedIndexChanged += new System.EventHandler(this.cmbSuppNo_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(671, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Amount";
            // 
            // txAmount
            // 
            this.txAmount.Location = new System.Drawing.Point(642, 50);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(147, 20);
            this.txAmount.TabIndex = 24;
            this.txAmount.Text = "0";
            this.txAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txAmount_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(816, 51);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 26);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(816, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 26);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txNet
            // 
            this.txNet.Location = new System.Drawing.Point(653, 388);
            this.txNet.Name = "txNet";
            this.txNet.Size = new System.Drawing.Size(148, 20);
            this.txNet.TabIndex = 47;
            this.txNet.Text = "0";
            this.txNet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNet_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(607, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Net Bill";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(802, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Bill No";
            // 
            // lstAmount
            // 
            this.lstAmount.FormattingEnabled = true;
            this.lstAmount.Location = new System.Drawing.Point(655, 244);
            this.lstAmount.Name = "lstAmount";
            this.lstAmount.Size = new System.Drawing.Size(146, 82);
            this.lstAmount.TabIndex = 45;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(392, 435);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 26);
            this.btnOk.TabIndex = 44;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(828, 435);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 26);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txDiscount
            // 
            this.txDiscount.Location = new System.Drawing.Point(653, 358);
            this.txDiscount.Name = "txDiscount";
            this.txDiscount.Size = new System.Drawing.Size(147, 20);
            this.txDiscount.TabIndex = 41;
            this.txDiscount.Text = "0";
            this.txDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDiscount_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(602, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Discount";
            // 
            // txTotalBill
            // 
            this.txTotalBill.Location = new System.Drawing.Point(654, 332);
            this.txTotalBill.Name = "txTotalBill";
            this.txTotalBill.Size = new System.Drawing.Size(147, 20);
            this.txTotalBill.TabIndex = 39;
            this.txTotalBill.Text = "0";
            this.txTotalBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTotalBill_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(603, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Total Bill";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Price";
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
            // lstICode
            // 
            this.lstICode.FormattingEnabled = true;
            this.lstICode.Location = new System.Drawing.Point(34, 244);
            this.lstICode.Name = "lstICode";
            this.lstICode.Size = new System.Drawing.Size(146, 82);
            this.lstICode.TabIndex = 48;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 94);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Purchase Book";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 480);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstQty);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstIName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txNet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lstAmount);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txDiscount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txTotalBill);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lstICode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optCredit;
        private System.Windows.Forms.RadioButton optCash;
        private System.Windows.Forms.ListBox lstQty;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstIName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txPBillNo;
        private System.Windows.Forms.TextBox txDueAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txMobileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSuppName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSuppNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txNet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstAmount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txTotalBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txQty;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txIName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbICode;
        private System.Windows.Forms.ListBox lstICode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
    }
}