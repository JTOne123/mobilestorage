namespace MobileStorage
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.miDonate = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbkOffSite = new System.Windows.Forms.LinkLabel();
            this.cmdDonamte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.miDonate);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Ok";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // miDonate
            // 
            this.miDonate.Text = "Donate $1";
            this.miDonate.Click += new System.EventHandler(this.miDonate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.Text = "Paul Datsyuk 2009";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.Text = "Mobile Storage 0.1 betta";
            // 
            // lbkOffSite
            // 
            this.lbkOffSite.Location = new System.Drawing.Point(23, 108);
            this.lbkOffSite.Name = "lbkOffSite";
            this.lbkOffSite.Size = new System.Drawing.Size(100, 20);
            this.lbkOffSite.TabIndex = 2;
            this.lbkOffSite.Text = "Official site";
            this.lbkOffSite.Click += new System.EventHandler(this.lbkOffSite_Click);
            // 
            // cmdDonamte
            // 
            this.cmdDonamte.Location = new System.Drawing.Point(23, 152);
            this.cmdDonamte.Name = "cmdDonamte";
            this.cmdDonamte.Size = new System.Drawing.Size(197, 20);
            this.cmdDonamte.TabIndex = 3;
            this.cmdDonamte.Text = "Donate $1";
            this.cmdDonamte.Click += new System.EventHandler(this.cmdDonamte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 16);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdDonamte);
            this.Controls.Add(this.lbkOffSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbkOffSite;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem miDonate;
        private System.Windows.Forms.Button cmdDonamte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}