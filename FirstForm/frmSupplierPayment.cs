using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class frmSupplierPayment : Form
    {
        public frmSupplierPayment()
        {
            InitializeComponent();
        }

        private void frmSupplierPayment_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.SrNo = Convert.ToString(GlobalClass.id_Resder("select SrNo from Supplier_Payment"));
                txSrNO.Text = GlobalClass.SrNo;

                GlobalClass.record_Reader("Select SuppNo From Supplier");
                while (GlobalClass.dr.Read())
                {
                    cmbSuppNo.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                GlobalClass.Show_List_Supplier_pay("Select * from Supplier_Payment");
                dataGrid1.DataSource = GlobalClass.ds.Tables["Supplier_Payment"];
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSuppNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from Supplier");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.SuppNo = GlobalClass.dr[0].ToString();
                    GlobalClass.SuppName = GlobalClass.dr[1].ToString();
                    GlobalClass.DueAmount = GlobalClass.dr[5].ToString();

                    if (cmbSuppNo.Text == GlobalClass.SuppNo)
                    {
                        txDueAmount.Text = GlobalClass.DueAmount.ToString();
                        txSuppName.Text = GlobalClass.SuppName.ToString();
                    }
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                txPaidAmount.Text = "0";
                txPaidAmount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txDueAmount.Text) >= Convert.ToInt32(txPaidAmount.Text))
                {
                    txDueAmount.Text = Convert.ToString(Convert.ToInt32(txDueAmount.Text) - Convert.ToInt32(txPaidAmount.Text));

                    GlobalClass.record_Manip("Update Supplier set DueAmount= '" + txDueAmount.Text + "' where Suppno= " + cmbSuppNo.Text);

                    GlobalClass.record_Manip("insert into Supplier_Payment Values ('" + txSrNO.Text + "','" + cmbSuppNo.Text + "','"+txSuppName.Text+"','" + dtpDate.Text + "','" + txPaidAmount.Text + "' )");
                    MessageBox.Show("Record Save");

                    GlobalClass.Show_List_Supplier_pay("Select * from Supplier_Payment");
                    dataGrid1.DataSource = GlobalClass.ds.Tables["Supplier_Payment"];
                    GlobalClass.con.Close();
                }
                else
                {
                    MessageBox.Show("Enter Valid Amount");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGrid1.CurrentRowIndex;
                cmbSuppNo.Text = dataGrid1[r, 0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

       
    }
}
