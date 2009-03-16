using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MobileStorage
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}