using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyExpenses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form frm = new frmCategory();
            frm.ShowDialog();
        }

        private void btnIncomeExpense_Click(object sender, EventArgs e)
        {
            Form frm = new frmExpenses();
            frm.ShowDialog();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            Form frm = new frmType();
            frm.ShowDialog();
        }
    }
}
