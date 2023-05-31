using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FirstForm
{
    public partial class frmCashReport : Form
    {
        public frmCashReport()
        {
            InitializeComponent();
        }

        private void frmCashReport_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from cash");
                while (GlobalClass.dr.Read())
                {
                    cmbTrNo.Items.Add(GlobalClass.dr[0].ToString());
                    //cmbRemark.Items.Add(GlobalClass.dr[5].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                //For report Using 
                GlobalClass.da = new OleDbDataAdapter("Select * From cash", GlobalClass.con);
                GlobalClass.da.Fill(GlobalClass.ds, "cash");
                rptCashReport rpt = new rptCashReport();
                rpt.SetDataSource(GlobalClass.ds.Tables["cash"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.ds.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //For report Using 
                GlobalClass.da = new OleDbDataAdapter("Select * from Cash where Trno=" + cmbTrNo.Text, GlobalClass.con);
                GlobalClass.da.Fill(GlobalClass.ds, "Cash");
                rptCashReport rpt = new rptCashReport();
                rpt.SetDataSource(GlobalClass.ds.Tables["Cash"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.ds.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRemark_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //For report Using 
                GlobalClass.da = new OleDbDataAdapter("Select * from cash where Remark= '" + cmbRemark.Text + "'", GlobalClass.con);
                GlobalClass.da.Fill(GlobalClass.ds, "Cash");
                rptCashReport rpt = new rptCashReport();
                rpt.SetDataSource(GlobalClass.ds.Tables["Cash"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.ds.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
