using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MobileStorage
{
    public partial class frmMain : Form
    {
        List<StorageItems> siList = new List<StorageItems>();
        private string LastChangedFile;

        private string Password { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //string a = Business.Encrypt("a123b", "sjkladfhja");
            //string b = Business.Decrypt(a, "sjkladfhja");
        }

        private void dataGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid1.CurrentRowIndex != -1)
            {
                frmAddItem frmAddItem = new frmAddItem();

                frmAddItem.txtKey.Text = siList[dataGrid1.CurrentRowIndex].Key;
                frmAddItem.txtValue.Text = siList[dataGrid1.CurrentRowIndex].Value;
                frmAddItem.txtDescription.Text = siList[dataGrid1.CurrentRowIndex].Description;

                frmAddItem.ShowDialog();

                siList[dataGrid1.CurrentRowIndex].Key = frmAddItem.txtKey.Text;
                siList[dataGrid1.CurrentRowIndex].Value = frmAddItem.txtValue.Text;
                siList[dataGrid1.CurrentRowIndex].Description = frmAddItem.txtDescription.Text;

                if (!string.IsNullOrEmpty(LastChangedFile))
                {
                    SaveFile();
                }
                else
                {
                    miSave_Click(null, null);
                }

                DataGridRefresh();
            }
        }

        private void DataGridRefresh()
        {
            dataGrid1.DataSource = null;
            dataGrid1.DataSource = siList;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LastChangedFile = openFileDialog1.FileName;

                frmPassword frmPass = new frmPassword();
                frmPass.ShowDialog();

                Password = frmPass.Password;

                if (!string.IsNullOrEmpty(Password))
                {
                    siList = Business.Convertor.DecryptList(Business.XMLSerialize.DeserializeFromXML(LastChangedFile), Password);

                    if (siList == null)
                    {
                        MessageBox.Show("Password error");
                    }
                }
                else
                {
                    MessageBox.Show("File dont opened");
                }

                DataGridRefresh();
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LastChangedFile = saveFileDialog1.FileName;

                SaveFile();
            }
        }

        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(Password))
            {
                Business.XMLSerialize.SerializeToXML(Business.Convertor.EncryptList(siList, Password), LastChangedFile);
            }
            else
            {
                frmPassword frmPass = new frmPassword();
                frmPass.ShowDialogWithRePassword();

                Password = frmPass.Password;

                if (!string.IsNullOrEmpty(Password))
                {
                    Business.XMLSerialize.SerializeToXML(
                        Business.Convertor.EncryptList(siList, Password), LastChangedFile);
                }
                else
                {
                    MessageBox.Show("File dont saved");
                }
            }
        }

        private void miNewValue_Click(object sender, EventArgs e)
        {
            frmAddItem frmAddItem = new frmAddItem();
            frmAddItem.ShowDialog();

            if (siList == null) siList = new List<StorageItems>();

            siList.Add(new StorageItems(frmAddItem.txtKey.Text, frmAddItem.txtValue.Text, frmAddItem.txtDescription.Text));

            if (!string.IsNullOrEmpty(LastChangedFile))
            {
                SaveFile();
            }
            else
            {
                miSave_Click(null, null);
            }

            DataGridRefresh();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAb = new frmAbout();
            frmAb.ShowDialog();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            frmDonate frmDon = new frmDonate();
            frmDon.ShowDialog();
        }
    }
}