namespace MobileStorage
{
    partial class frmMain
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.miOpen = new System.Windows.Forms.MenuItem();
            this.miSave = new System.Windows.Forms.MenuItem();
            this.miNewValue = new System.Windows.Forms.MenuItem();
            this.miExit = new System.Windows.Forms.MenuItem();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.miAbout = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.miExit);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.miOpen);
            this.menuItem1.MenuItems.Add(this.miSave);
            this.menuItem1.MenuItems.Add(this.miNewValue);
            this.menuItem1.MenuItems.Add(this.miAbout);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Text = "Open Storage";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Text = "Save Storage";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miNewValue
            // 
            this.miNewValue.Text = "New Value";
            this.miNewValue.Click += new System.EventHandler(this.miNewValue_Click);
            // 
            // miExit
            // 
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 268);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // miAbout
            // 
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Donate $1";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Mobile Storage";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem miSave;
        private System.Windows.Forms.MenuItem miNewValue;
        private System.Windows.Forms.MenuItem miExit;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.MenuItem miOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuItem miAbout;
        private System.Windows.Forms.MenuItem menuItem2;

    }
}

