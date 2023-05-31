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
    public partial class frmForgetPass : Form
    {
        public frmForgetPass()
        {
            InitializeComponent();
        }        
        private void frmForgetPass_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from SecurityQuestion");
                while (GlobalClass.dr.Read())
                {
                    //cmbQues.Items.Add(GlobalClass.dr[2].ToString());
                    cmbUName.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("select * from securityQuestion");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.FUname = GlobalClass.dr[0].ToString();
                    GlobalClass.Que = GlobalClass.dr[2].ToString();
                    GlobalClass.Pass = GlobalClass.dr[1].ToString();
                    GlobalClass.Ans = GlobalClass.dr[3].ToString();

                    if (cmbUName.Text == GlobalClass.FUname)
                    {
                        if ((cmbQues.Text == GlobalClass.Que) && (txAns.Text == GlobalClass.Ans))
                        {
                            MessageBox.Show("Your Password is " +GlobalClass.Pass.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Wrong Qus Or Ans");
                        }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
