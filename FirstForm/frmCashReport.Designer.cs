namespace FirstForm
{
    partial class frmCashReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCashReport1 = new FirstForm.rptCashReport();
            this.cmbTrNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRemark = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptCashReport1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1481, 531);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cmbTrNo
            // 
            this.cmbTrNo.FormattingEnabled = true;
            this.cmbTrNo.Location = new System.Drawing.Point(312, 24);
            this.cmbTrNo.Name = "cmbTrNo";
            this.cmbTrNo.Size = new System.Drawing.Size(178, 21);
            this.cmbTrNo.TabIndex = 1;
            this.cmbTrNo.SelectedIndexChanged += new System.EventHandler(this.cmbTrNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tr No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remark";
            // 
            // cmbRemark
            // 
            this.cmbRemark.FormattingEnabled = true;
            this.cmbRemark.Items.AddRange(new object[] {
            "Sales",
            "Purchase",
            "Cash from capital",
            "Traveling",
            "Shopping",
            "Light Bill"});
            this.cmbRemark.Location = new System.Drawing.Point(669, 24);
            this.cmbRemark.Name = "cmbRemark";
            this.cmbRemark.Size = new System.Drawing.Size(178, 21);
            this.cmbRemark.TabIndex = 3;
            this.cmbRemark.SelectedIndexChanged += new System.EventHandler(this.cmbRemark_SelectedIndexChanged);
            // 
            // frmCashReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTrNo);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmCashReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCashReport";
            this.Load += new System.EventHandler(this.frmCashReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptCashReport rptCashReport1;
        private System.Windows.Forms.ComboBox cmbTrNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRemark;
    }
}