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
    public partial class frmCustomerPayment : Form
    {
        public frmCustomerPayment()
        {
            InitializeComponent();
        }

        private void frmCustomerPayment_Load(object sender, EventArgs e)
        {
            GlobalClass.SrNo = Convert.ToString(GlobalClass.id_Resder("select SrNo from Customer_Payment"));
            txSrNO.Text = GlobalClass.SrNo;

            GlobalClass.record_Reader("Select CustNo From Customer");
            while (GlobalClass.dr.Read())
            {
                cmbCustNo.Items.Add ( GlobalClass.dr[0].ToString());
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();

            GlobalClass.Show_List_Customer_pay("Select * from customer_Payment");
            dataGrid1.DataSource = GlobalClass.ds.Tables["Customer_Payment"];
            GlobalClass.con.Close();
        }

        private void cmbCustNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalClass.record_Reader("Select * from Customer");
            while (GlobalClass.dr.Read())
            {
                GlobalClass.CustNo = GlobalClass.dr[0].ToString();
                GlobalClass.CustName = GlobalClass.dr[1].ToString();
                GlobalClass.DueAmount = GlobalClass.dr[5].ToString();

                if (cmbCustNo.Text == GlobalClass.CustNo)
                {
                    txDueAmount.Text = GlobalClass.DueAmount.ToString();
                    txCustName.Text = GlobalClass.CustName.ToString();
                }
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();
            txPaidAmount.Text = "0";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txDueAmount.Text) >= Convert.ToInt32(txPaidAmount.Text))
                {
                    txDueAmount.Text = Convert.ToString(Convert.ToInt32(txDueAmount.Text) - Convert.ToInt32(txPaidAmount.Text));

                    GlobalClass.record_Manip("Update Customer set DueAmount= '" + txDueAmount.Text + "' where Custno= " + cmbCustNo.Text);

                    GlobalClass.record_Manip("insert into Customer_Payment Values ('" + txSrNO.Text + "','" + cmbCustNo.Text + "','" + txCustName.Text + "','" + dtpDate.Text + "','" + txPaidAmount.Text + "' )");
                    MessageBox.Show("Record Save");

                    GlobalClass.Show_List_Customer_pay("Select * from customer_Payment");
                    dataGrid1.DataSource = GlobalClass.ds.Tables["Customer_Payment"];
                    GlobalClass.con.Close();
                }
                else
                {
                    MessageBox.Show("Paid Amount Greater Than Due Amount");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGrid1.CurrentRowIndex;
                cmbCustNo.Text = dataGrid1[r, 0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
