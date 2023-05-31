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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select Empno from Employee");
                while (GlobalClass.dr.Read())
                {
                    cmbEmpNo.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

            
        }

        private void cmbEmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               GlobalClass.record_Reader("select * from Employee where Empno=" + cmbEmpNo.Text);
                while (GlobalClass.dr.Read())
                {
                    txEName.Text = GlobalClass.dr[1].ToString();

                    cmbPost.Text = GlobalClass.dr[2].ToString();
                    
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
                cmbEmpNo.Text = Convert.ToString(GlobalClass.id_Resder("select max(Empno) from Employee"));
                txEName.Text = "";
                cmbPost.Text = "";
                txEName.Focus();
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
            
            if (txEName.Text == "" || cmbPost.Text == "")
            {
                MessageBox.Show("Enter The Value of EName & Post");
            }
            else
            {
                try
                {
                    GlobalClass.record_Manip("Insert into employee values ('" + cmbEmpNo.Text + "','" + txEName.Text + "','" + cmbPost.Text + "')");
                    MessageBox.Show("Record save");
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    cmbEmpNo.Items.Add(cmbEmpNo.Text);

                    GlobalClass.Show_List("Select * from Employee");
                    dataGrid1.DataSource = GlobalClass.ds.Tables["Employee"];
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
            GlobalClass.record_Manip("update Employee set EName='"+txEName.Text+"',Post='"+cmbPost.Text+"' where empno=" +cmbEmpNo.Text);
            MessageBox.Show("Record Upsate");

            GlobalClass.Show_List("Select * from Employee");
            dataGrid1.DataSource = GlobalClass.ds.Tables["Employee"];
            GlobalClass.con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Manip("Delete from Employee Where Empno="+cmbEmpNo.Text);
                MessageBox.Show("Record Delete");
                cmbEmpNo.Text = "";
                txEName.Text = "";
                cmbPost.Text = "";
                cmbEmpNo.Items.Remove(cmbEmpNo.SelectedItem.ToString());

                GlobalClass.Show_List("Select * from Employee");
                dataGrid1.DataSource = GlobalClass.ds.Tables["Employee"];
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txEName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txEName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                MessageBox.Show("Please enter only Charecters");
                e.Handled = true;
            }
        }

        private void cmbPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                MessageBox.Show("Please enter only Charecters");
                e.Handled = true;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GlobalClass.Show_List("Select * from Employee");
            dataGrid1.DataSource = GlobalClass.ds.Tables["Employee"];
            GlobalClass.con.Close();
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGrid1.CurrentRowIndex;
                cmbEmpNo.Text = dataGrid1[r, 0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }                    
    }
 }

