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
    public partial class frmChange_Pass : Form
    {
        public frmChange_Pass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txOldPass.Text == "" || txConform.Text == "")
            {
                MessageBox.Show("Enter the New password ");
            }
            else
            {
                if (txNewPass.Text == txConform.Text)
                {
                    GlobalClass.record_Manip("Update Login set pass='"+txNewPass.Text+"' Where UName='"+ GlobalClass.Uname.ToString()+"'");
                    GlobalClass.record_Manip("Update SecurityQuestion set pass='" + txNewPass.Text + "' Where UName='" + GlobalClass.Uname.ToString() + "'");
                    MessageBox.Show("Password change");
                }
                else
                {
                    MessageBox.Show("New pass and Conformed pass not same");
                }
            }
            
        }

        private void txOldPass_Leave(object sender, EventArgs e)
        {
            if (GlobalClass.Pass == txOldPass.Text)
            {
                //MessageBox.Show("Enter New Pass ");
                txNewPass.Focus();
            }
            else
            {
                //MessageBox.Show("Incorrect Old pass");
                txOldPass.Text = "";
                txOldPass.Focus();
            }
        }

        private void frmChange_Pass_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
