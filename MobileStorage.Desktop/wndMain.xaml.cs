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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace MobileStorage.Desktop
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        private string _Filename = null;
        public string FileName
        {
            get
            {
                if (_Filename == null)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "xml files (*.xml)|*.*";
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.ShowDialog();

                    _Filename = openFileDialog.FileName;
                }

                return _Filename;
            }
            set
            {
                _Filename = value;
            }
        }

        public wndMain()
        {
            InitializeComponent();
        }

        private void mnuOpenStorage_Click(object sender, RoutedEventArgs e)
        {
            FileName = null;
            DataBind();
        }

        private void lvGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((MobileStorage.StorageItems)(((object[])(e.AddedItems))[0])).Value);
        }

        private void mnuAddItem_Click(object sender, RoutedEventArgs e)
        {
            wndAddItem wndAddItm = new wndAddItem(FileName);
            wndAddItm.ShowDialog();
            DataBind();
        }

        private void DataBind()
        {
            if (FileName != string.Empty)
            {
                var pwd = (new wndPassword()).GetPassword();

                if (pwd == null)
                    return;

                lvGrid.ItemsSource = Business.Convertor.DecryptList(Business.XMLSerialize.DeserializeFromXML(FileName), pwd);
            }
        }
    }
}
