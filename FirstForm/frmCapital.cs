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
    public partial class frmCapital : Form
    {
        public frmCapital()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txAmount.Text == "") || (txAmount.Text=="0"))
                {
                    MessageBox.Show("Enter the valid Amount");
                }
                else
                {
                    int i = GlobalClass.id_Resder("Select TrNo from capital");
                    //MessageBox.Show(i.ToString());

                    GlobalClass.record_Manip("Insert into capital values (" + i + ",'" + dtpTrDate.Text + "'," + txAmount.Text + ")");
                    MessageBox.Show("Record Save");

                    int CashBal = Convert.ToInt32(lbBal.Text) + Convert.ToInt32(txAmount.Text);
                    i = GlobalClass.id_Resder("Select TrNo from Cash");

                    GlobalClass.record_Manip("Insert into cash values (" + i + ",'" + dtpTrDate.Text + "'," + txAmount.Text + ",0," + CashBal + ",'Cash from capital')");

                    GlobalClass.record_Reader("Select Balance From Cash");
                    while (GlobalClass.dr.Read())
                    {
                        lbBal.Text = GlobalClass.dr[0].ToString();
                    }
                    GlobalClass.dr.Close();
                    GlobalClass.con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCapital_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                GlobalClass.record_Reader("Select Balance From Cash");
                while (GlobalClass.dr.Read())
                {
                    lbBal.Text = GlobalClass.dr[0].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
                txAmount.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
