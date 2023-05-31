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
    public partial class frmEmployeeRPT : Form
    {
        public frmEmployeeRPT()
        {
            InitializeComponent();
        }

        private void frmEmployeeRPT_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.book_Reader("Select EmpNo from [Sheet2$]");
                while (GlobalClass.bdr.Read())
                {
                    cmbEmpNo.Items.Add(GlobalClass.bdr[0].ToString());
                }
                GlobalClass.bdr.Close();
                GlobalClass.bcon.Close();


                //For report Using 
                GlobalClass.bda = new OleDbDataAdapter("select * from [Sheet2$]", GlobalClass.bcon);
                GlobalClass.bda.Fill(GlobalClass.bds, "[Sheet2$]");
                rptEmployeeReport rpt = new rptEmployeeReport();
                rpt.SetDataSource(GlobalClass.bds.Tables["[Sheet2$]"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.bds.Reset();
                GlobalClass.bcon.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //For report Using 
                GlobalClass.bda = new OleDbDataAdapter("Select * from [Sheet2$] where EmpNo= " + cmbEmpNo.Text, GlobalClass.bcon);
                GlobalClass.bda.Fill(GlobalClass.bds, "[Sheet2$]");
                rptEmployeeReport rpt = new rptEmployeeReport();
                rpt.SetDataSource(GlobalClass.bds.Tables["[Sheet2$]"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.bds.Reset();
                GlobalClass.bcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //For report Using 

                GlobalClass.bda = new OleDbDataAdapter("Select * from [Sheet2$] where Post= '" + cmbPost.Text + "'", GlobalClass.bcon);
                GlobalClass.bda.Fill(GlobalClass.bds, "[Sheet2$]");
                rptEmployeeReport rpt = new rptEmployeeReport();
                rpt.SetDataSource(GlobalClass.bds.Tables["[Sheet2$]"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.bds.Reset();
                GlobalClass.bcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
