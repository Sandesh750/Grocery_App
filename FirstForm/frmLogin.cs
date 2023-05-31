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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                int tmp = 0;
                GlobalClass.record_Reader("Select * from login");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.Uname = GlobalClass.dr[0].ToString();
                    GlobalClass.Pass = GlobalClass.dr[1].ToString();
                
                
                    if ((txUName.Text == GlobalClass.Uname) && (txPass.Text == GlobalClass.Pass))
                     {
                         tmp = 1;
                           break;
                    
                     }
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
                if (tmp == 1)
                {
                    //MessageBox.Show("Login Successfuly");
                    MDIParent1 obj = new MDIParent1();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Inccorect UName or Pass");
                    txUName.Text = "";
                    txPass.Text = "";
                    txUName.Focus();
                }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPass obj = new frmForgetPass();
            obj.Show();
            this.Hide();
        }

        private void txUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                MessageBox.Show("Enter Only Characters");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txPass.PasswordChar == '*')
            {
                button1.BringToFront();
                txPass.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txPass.PasswordChar == '\0')
            {
                button2.BringToFront();
                txPass.PasswordChar = '*';
            }
        }

              
    }
} 
