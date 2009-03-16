namespace MobileStorage
{
    partial class frmPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.miOk = new System.Windows.Forms.MenuItem();
            this.miCancel = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.miOk);
            this.mainMenu1.MenuItems.Add(this.miCancel);
            // 
            // miOk
            // 
            this.miOk.Text = "Ok";
            this.miOk.Click += new System.EventHandler(this.miOk_Click);
            // 
            // miCancel
            // 
            this.miCancel.Text = "Cancel";
            this.miCancel.Click += new System.EventHandler(this.miCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.Text = "Enter password, please";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(25, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(188, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(25, 131);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(188, 21);
            this.txtRePassword.TabIndex = 3;
            this.txtRePassword.Visible = false;
            // 
            // lblRePassword
            // 
            this.lblRePassword.Location = new System.Drawing.Point(25, 98);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(100, 20);
            this.lblRePassword.Text = "RePassword";
            this.lblRePassword.Visible = false;
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(25, 178);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(176, 48);
            this.lblError.Text = "Password missmatch or password little, min 9 symbols";
            this.lblError.Visible = false;
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmPassword";
            this.Text = "Enter password";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem miOk;
        private System.Windows.Forms.MenuItem miCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblError;
    }
}