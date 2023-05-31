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
    public partial class frmSellBook : Form
    {
        public frmSellBook()
        {
            InitializeComponent();
        }

        private void frmSellBook_Load(object sender, EventArgs e)
        {
            try
            {
                optCash.Checked = true;

                 GlobalClass.sbillNo = Convert.ToString(GlobalClass.id_Resder("select SBillNo from sales"));
                 txSBillNo.Text = GlobalClass.sbillNo;

                 GlobalClass.record_Reader("Select CustNo from Customer");
                 while (GlobalClass.dr.Read())
                 {
                     cmbCustNo.Items.Add(GlobalClass.dr[0].ToString());
                 }
                 GlobalClass.dr.Close();
                 GlobalClass.con.Close();

                GlobalClass.record_Reader("Select ICode From Item");
                while (GlobalClass.dr.Read())
                {
                    cmbICode.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCustNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from Customer");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.CustNo = GlobalClass.dr[0].ToString();
                    GlobalClass.CustName = GlobalClass.dr[1].ToString();
                    GlobalClass.Address = GlobalClass.dr[2].ToString();
                    GlobalClass.City = GlobalClass.dr[3].ToString();
                    GlobalClass.MobileNo = GlobalClass.dr[4].ToString();
                    GlobalClass.DueAmount = GlobalClass.dr[5].ToString();

                    if (cmbCustNo.Text == GlobalClass.CustNo)
                    {
                        txCustName.Text = GlobalClass.CustName.ToString();
                        txAddress.Text = GlobalClass.Address.ToString();
                        txCity.Text = GlobalClass.City.ToString();
                        txMobileNo.Text = GlobalClass.MobileNo.ToString();
                        txDueAmount.Text = GlobalClass.DueAmount.ToString();   
                    }
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbICode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from Item");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.ICode = GlobalClass.dr[0].ToString();
                    GlobalClass.IName = GlobalClass.dr[1].ToString();
                    GlobalClass.Price = GlobalClass.dr[2].ToString();

                    if (cmbICode.Text == GlobalClass.ICode)
                    {
                        txIName.Text = GlobalClass.IName;
                        txPrice.Text = GlobalClass.Price;
                    }
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
   
                txQty.Text = "0";
                txAmount.Text = "0";
                txQty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lstICode.Items.Add(cmbICode.Text);
                lstIName.Items.Add(txIName.Text);
                lstQty.Items.Add(txQty.Text);
                lstPrice.Items.Add(txPrice.Text);
                lstAmount.Items.Add(txAmount.Text);
               

                txTotalBill.Text = Convert.ToString(Convert.ToInt32(txTotalBill.Text) + Convert.ToInt32(txAmount.Text));

                if (optCash.Checked == true)
                {
                    txDiscount.Text = Convert.ToString((Convert.ToInt32(txTotalBill.Text) *  5)/100);
                }

                txNet.Text = Convert.ToString(Convert.ToInt32(txTotalBill.Text) - Convert.ToInt32(txDiscount.Text));   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txQty_Leave(object sender, EventArgs e)
        {
            txAmount.Text = Convert.ToString(Convert.ToInt32(txPrice.Text) * Convert.ToInt32(txQty.Text));
        }
      

        private void optCredit_CheckedChanged(object sender, EventArgs e)
        {
            //GlobalClass.record_Reader("select DueAmount from Customer where CustNo= " + cmbCustNo.Text );
            //while (GlobalClass.dr.Read())
            //{
            //    txDueAmount.Text = GlobalClass.dr[0].ToString();
            //}
            //GlobalClass.dr.Close();
            //GlobalClass.con.Close();

            txDiscount.Text = Convert.ToString(0);
            txNet.Text = Convert.ToString(Convert.ToInt32(txTotalBill.Text) - Convert.ToInt32(txDiscount.Text));
        }

        private void optCash_CheckedChanged(object sender, EventArgs e)
        {
            //GlobalClass.record_Reader("select DueAmount from Customer where CustNo= " + cmbCustNo.Text );
            //while (GlobalClass.dr.Read())
            //{
            //    txDueAmount.Text = GlobalClass.dr[0].ToString();
            //}
            //GlobalClass.dr.Close();
            //GlobalClass.con.Close();


            txDiscount.Text = Convert.ToString((Convert.ToInt32(txTotalBill.Text) * 5) / 100);
            txNet.Text = Convert.ToString(Convert.ToInt32(txTotalBill.Text) - Convert.ToInt32(txDiscount.Text));           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txTotalBill.Text == "0")
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
            int tmpAmount = 0;
            lstAmount.SelectedIndex = lstIName.SelectedIndex;
            lstICode.SelectedIndex = lstIName.SelectedIndex;
            lstPrice.SelectedIndex = lstIName.SelectedIndex;
            lstQty.SelectedIndex = lstIName.SelectedIndex;

            tmpAmount = Convert.ToInt32(lstAmount.SelectedItem);
            txTotalBill.Text = Convert.ToString(Convert.ToInt32(txTotalBill.Text) - tmpAmount);
            txDiscount.Text = Convert.ToString((Convert.ToInt32(txTotalBill.Text) * 5) / 100);
            txNet.Text = Convert.ToString(Convert.ToInt32(txTotalBill.Text) - Convert.ToInt32(txDiscount.Text));
           

            lstICode.Items.Remove(cmbICode.Text);
            lstIName.Items.Remove(txIName.Text);
            lstPrice.Items.Remove(txPrice.Text);
            lstQty.Items.Remove(txQty.Text);
            lstAmount.Items.Remove(txAmount.Text);

           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCustNo.Text = "";
            txCustName.Text = "";
            txAddress.Text = "";
            txCity.Text = "";
            txMobileNo.Text = "";
            txDueAmount.Text = "0";
            cmbICode.Text = "";
            txIName.Text = "";
            txPrice.Text = "0";
            txQty.Text = "0";
            txAmount.Text = "0";
            txTotalBill.Text = "0";
            txDiscount.Text = "0";
            txNet.Text = "0";

            lstICode.Items.Clear();
            lstIName.Items.Clear();
            lstPrice.Items.Clear();
            lstQty.Items.Clear();
            lstAmount.Items.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lstIName.Items.Count; i++)
                {
                   GlobalClass.lstiname = GlobalClass.lstiname +  lstIName.Items[i].ToString()+"\r\n";
                }

                for (int i = 0; i < lstICode.Items.Count; i++)
                {
                    GlobalClass.lsticode = GlobalClass.lsticode +  lstICode.Items[i].ToString() + "\r\n";                    
                }

                for (int i = 0; i < lstPrice.Items.Count; i++)
                {
                    GlobalClass.lstprice = GlobalClass.lstprice + lstPrice.Items[i].ToString() + "\r\n";
                }

                for (int i = 0; i < lstQty.Items.Count; i++)
                {
                    GlobalClass.lstqty = GlobalClass.lstqty + lstQty.Items[i].ToString() + "\r\n";
                }

                for (int i = 0; i < lstAmount.Items.Count; i++)
                {
                    GlobalClass.lstamount = GlobalClass.lstamount + lstAmount.Items[i].ToString() + "\r\n";
                }

                if (optCash.Checked == true)
                {
                    GlobalClass.PayMode = "Cash";

                    GlobalClass.record_Reader("select Balance from Cash");
                    while (GlobalClass.dr.Read())
                    {     
                        GlobalClass.Balance = GlobalClass.dr[0].ToString();   
                    }
                    GlobalClass.dr.Close();
                    GlobalClass.con.Close();

                    GlobalClass.STrNo = Convert.ToString(GlobalClass.id_Resder("Select TrNo From Cash"));

                    GlobalClass.Balance = Convert.ToString(Convert.ToInt32(GlobalClass.Balance) + Convert.ToInt32(txNet.Text));

                    GlobalClass.record_Manip("Insert into cash values ('" + GlobalClass.STrNo + "','" + dtpDate.Text + "','" + txNet.Text + "',0,'" + GlobalClass.Balance + "','Sales')");    
                }
                else
                {
                    if (optCredit.Checked == true)
                    {
                        GlobalClass.PayMode = "Credit";
                        txDueAmount.Text = Convert.ToString(Convert.ToInt32(txDueAmount.Text) + Convert.ToInt32(txNet.Text));
                    }
                }

                GlobalClass.record_Manip("Update Customer set DueAmount= '" + txDueAmount.Text + "' where CustNo= " + cmbCustNo.Text);

                GlobalClass.record_Manip("Insert into sales Values ('" + GlobalClass.sbillNo + "','" + dtpDate.Text + "','" + cmbCustNo.Text + "','" + GlobalClass.lsticode + "' , '" + GlobalClass.lstiname + "','" + GlobalClass.lstprice + "','" + GlobalClass.lstqty + "','" + GlobalClass.lstamount + "','" + txTotalBill.Text + "','" + txDiscount.Text + "','" + txNet.Text + "','" + GlobalClass.PayMode + "')");
                MessageBox.Show("Record Save");        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txTotalBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txNet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txDueAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        private void txSBillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

        

        
    }
}
