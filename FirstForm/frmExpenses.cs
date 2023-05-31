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
    public partial class frmExpenses : Form
    {
        public frmExpenses()
        {
            InitializeComponent();
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select Balance From Cash");
                while (GlobalClass.dr.Read())
                {
                    lbExBal.Text = GlobalClass.dr[0].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                cmbTrNo.Text=Convert.ToString(GlobalClass.id_Resder("Select TrNo From Expenses"));

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReason.Text == "")
                {
                    MessageBox.Show("Select the reason");
                }
                else
                {
                   
                    if (txExAmount.Text == "")
                    {
                        MessageBox.Show("Enter Amount");
                    }
                    else
                    {
                        //int i = GlobalClass.id_Resder("Select TrNo From Expenses");
                        //MessageBox.Show(i.ToString());

                        GlobalClass.record_Manip("Insert into Expenses values (" + cmbTrNo.Text + ",'" + dtpExDate.Text + "','" + cmbReason.Text + "','" + txDetals.Text + "','" + txExAmount.Text + "')");

                        int ExpBal = Convert.ToInt32(lbExBal.Text) - Convert.ToInt32(txExAmount.Text);

                        int i = GlobalClass.id_Resder("Select TrNo from Cash");
                        //MessageBox.Show(i.ToString());
                        //MessageBox.Show("Insert into cash values (" + i + ",'" + dtpExDate.Text + "',0 ," + txExAmount.Text + "," + ExpBal + "," + cmbReason.Text + ")");
                        GlobalClass.record_Manip("Insert into cash values (" + i + ",'" + dtpExDate.Text + "',0," + txExAmount.Text + "," + ExpBal + ",'" + cmbReason.Text + "')");
                        MessageBox.Show("Record Save");

                        GlobalClass.record_Reader("Select Balance From Cash");
                        while (GlobalClass.dr.Read())
                        {
                            lbExBal.Text = GlobalClass.dr[0].ToString();
                        }
                        GlobalClass.dr.Close();
                        GlobalClass.con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                             
                    if (cmbReason.Text == "Light Bill")
                    {
                        txDetals.Text = "Home Light Bill";
                    }
                    else if (cmbReason.Text == "Salary")
                    {
                        txDetals.Text = "Employee Salary";
                    }
                    else if (cmbReason.Text == "Shopping")
                    {
                        txDetals.Text = "D-Mart";
                    }
                    else if (cmbReason.Text == "Traveling")
                    {
                        txDetals.Text = "Matheran";
                    }                              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void txExAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please Enter only Digit");
                e.Handled = true;
            }
        }

       
    }
}
