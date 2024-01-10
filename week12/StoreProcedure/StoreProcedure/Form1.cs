using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreProcedure
{
    public partial class cmdType : Form
    {
        public cmdType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmType = new Setup.frmType();
            frmType.ShowDialog();
        }
    }
}
