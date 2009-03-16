using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MobileStorage
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lbkOffSite_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe", "http://jthotblog.blogspot.com/");
        }

        private void cmdDonamte_Click(object sender, EventArgs e)
        {
            frmDonate frmDon = new frmDonate();
            frmDon.ShowDialog();
        }

        private void miDonate_Click(object sender, EventArgs e)
        {
            frmDonate frmDon = new frmDonate();
            frmDon.ShowDialog();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}