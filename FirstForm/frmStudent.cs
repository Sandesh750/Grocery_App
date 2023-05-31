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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select SCode from Student");
                while (GlobalClass.dr.Read())
                {
                    cmbSCode.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                GlobalClass.Show_List_Student("Select * from Student");
                dataGrid2.DataSource = GlobalClass.ds.Tables["Student"];
                GlobalClass.con.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from Student where SCode=" + cmbSCode.Text);
                while (GlobalClass.dr.Read())
                {
                    txSName.Text =GlobalClass.dr[1].ToString();
                    cmbCCode.Text = GlobalClass.dr[2].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                btnSave.Enabled = false;
                btnNew.Enabled = true;
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
                cmbSCode.Text = Convert.ToString(GlobalClass.id_Resder("Select max(SCode) from student"));
                txSName.Text = "";
                cmbCCode.Text = "";
                txSName.Focus();
                btnNew.Enabled = false;
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txSName.Text == "" || cmbCCode.Text == "")
            {
                MessageBox.Show("Enter the value of SName & CCode");
            }
            else
            {
                try
                {
                    GlobalClass.record_Manip("Insert into Student Values(" + cmbSCode.Text + ",'" + txSName.Text + "','" + cmbCCode.Text + "')");
                    MessageBox.Show("Record save");
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    cmbSCode.Items.Add(cmbSCode.Text);

                    GlobalClass.Show_List_Student("Select * from Student");
                    dataGrid2.DataSource = GlobalClass.ds.Tables["Student"];
                    GlobalClass.con.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Manip("Update Student Set SName='"+txSName.Text+"',CCode='"+cmbCCode.Text+"' where SCode="+cmbSCode.Text);
                MessageBox.Show("Record Update");

                GlobalClass.Show_List_Student("Select * from Student");
                dataGrid2.DataSource = GlobalClass.ds.Tables["Student"];
                GlobalClass.con.Close();
                btnNew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Manip("Delete from Student where SCode="+cmbSCode.Text);
                MessageBox.Show("Record Delete");
                cmbSCode.Text = "";
                cmbCCode.Text = "";
                txSName.Text = "";
                cmbSCode.Items.Remove(cmbSCode.SelectedItem.ToString());

                GlobalClass.Show_List_Student("Select * from Student");
                dataGrid2.DataSource = GlobalClass.ds.Tables["Student"];
                GlobalClass.con.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                MessageBox.Show("Please enter only Charecters");
                e.Handled = true;
            }
        }

        private void cmbCCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please enter only Digits");
                e.Handled = true;
            }
        }

        private void dataGrid2_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGrid2.CurrentRowIndex;
                cmbSCode.Text = dataGrid2[r, 0].ToString();
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

       
    }
}
