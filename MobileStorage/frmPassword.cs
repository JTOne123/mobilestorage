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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void miCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            this.Close();
        }

        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
        }

        private void miOk_Click(object sender, EventArgs e)
        {
            if (txtRePassword.Visible)
            {
                if (txtPassword.Text == txtRePassword.Text && txtPassword.Text.Length >= 9)
                {
                    lblRePassword.Visible = false;
                    lblError.Visible = false;
                    this.Close();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                this.Close();
            }
        }

        public void ShowDialogWithRePassword()
        {
            lblRePassword.Visible = true;
            txtRePassword.Visible = true;
            this.ShowDialog();
        }
    }
}