using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MobileStorage.Desktop
{
    /// <summary>
    /// Interaction logic for wndPassword.xaml
    /// </summary>
    public partial class wndAddItem : Window
    {

        public string FileName { get; set; }

        public wndAddItem(string FileName)
        {
            InitializeComponent();
            this.FileName = FileName;
        }

        private void cmdOK_Click(object sender, RoutedEventArgs e)
        {
            var si = new StorageItems(txtKey.Text, txtValue.Text, string.Empty);

            SaveFile(si);
        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveFile(StorageItems si)
        {
            string pwd = (new wndPassword()).GetPassword();

            if (pwd != null)
            {
                var siList = Business.Convertor.DecryptList(Business.XMLSerialize.DeserializeFromXML(FileName), pwd);

                if (siList == null)
                {
                    MessageBox.Show("Password incorect");
                    return;
                }

                siList.Add(si);
                Business.XMLSerialize.SerializeToXML(Business.Convertor.EncryptList(siList, pwd), FileName);
            }
        }
    }
}
