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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee obj = new frmEmployee();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent obj =new frmStudent();
            obj.MdiParent = this;
            obj.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hello " + GlobalClass.Uname + "..!";
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChange_Pass obj =new frmChange_Pass();
            obj.MdiParent = this;
            obj.Show();
        }

        private void capitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapital obj = new frmCapital();
            obj.MdiParent = this;
            obj.Show();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpenses obj = new frmExpenses();
            obj.MdiParent = this;
            obj.Show();
        }

        private void sellBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellBook obj = new frmSellBook();
            obj.MdiParent = this;
            obj.Show();  
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase obj = new frmPurchase();
            obj.MdiParent = this;
            obj.Show();
        }

        private void customerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerPayment obj = new frmCustomerPayment();
            obj.MdiParent = this;
            obj.Show();
        }

        private void supplierPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierPayment obj = new frmSupplierPayment();
            obj.MdiParent = this;
            obj.Show();
        }

        private void cashReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCashReport obj = new frmCashReport();
            obj.MdiParent = this;
            obj.Show();
        }


        private void emloyeeBookRPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeRPT obj = new frmEmployeeRPT();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCoustomer obj = new frmNewCoustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addOrRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewsupplier obj = new frmNewsupplier();
            obj.MdiParent = this;
            obj.Show();
        }

       
    }
}
