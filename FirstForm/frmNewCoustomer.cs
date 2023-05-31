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
    public partial class frmNewCoustomer : Form
    {
        public frmNewCoustomer()
        {
            InitializeComponent();
        }

        private void frmNewCoustomer_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("select CustNo from Customer");
                while (GlobalClass.dr.Read())
                {
                    cmbCustNo.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                GlobalClass.Show_List_Customer("Select * from Customer");
                dataGrid1.DataSource = GlobalClass.ds.Tables["Customer"];
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
                GlobalClass.record_Reader("select * from Customer where CustNo=" + cmbCustNo.Text);
                while (GlobalClass.dr.Read())
                {
                    txCustName.Text = GlobalClass.dr[1].ToString();
                    txAddress.Text = GlobalClass.dr[2].ToString();
                    txCity.Text = GlobalClass.dr[3].ToString();
                    txMobile.Text = GlobalClass.dr[4].ToString();
                    txDueAmount.Text = GlobalClass.dr[5].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                cmbCustNo.Text = Convert.ToString(GlobalClass.id_Resder("Select CustNo from Customer"));
                txCustName.Text = "";
                txAddress.Text = "";
                txCity.Text = "";
                txMobile.Text = "";
                txDueAmount.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txCustName.Text == "") && (txAddress.Text == "") && (txCity.Text == "") && (txMobile.Text == "") && (txDueAmount.Text == "0"))
                {
                    MessageBox.Show("Enter the data");
                }
                else
                {
                    cmbCustNo.Items.Add(cmbCustNo.Text);
                    GlobalClass.record_Manip("insert into Customer values ('" + cmbCustNo.Text + "','" + txCustName.Text + "','" + txAddress.Text + "','" + txCity.Text + "','" + txMobile.Text + "','" + txDueAmount.Text + "')");
                    MessageBox.Show("Record Save");

                    GlobalClass.Show_List_Customer("Select * from Customer");
                    dataGrid1.DataSource = GlobalClass.ds.Tables["Customer"];
                    GlobalClass.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txDueAmount.Text == "0")
                {
                    GlobalClass.record_Manip("delete from Customer where CustNo= " + cmbCustNo.Text);
                    MessageBox.Show("Record Delete");
                    cmbCustNo.Items.Remove(cmbCustNo.Text);
                    txCustName.Text = "";
                    txAddress.Text = "";
                    txCity.Text = "";
                    txMobile.Text = "";
                    txDueAmount.Text = "";

                    GlobalClass.Show_List_Customer("Select * from Customer");
                    dataGrid1.DataSource = GlobalClass.ds.Tables["Customer"];
                    GlobalClass.con.Close();
                }
                else
                {
                    MessageBox.Show("Pay your due amount");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
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

        private void txMobile_KeyPress(object sender, KeyPressEventArgs e)
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

        
    }
}
