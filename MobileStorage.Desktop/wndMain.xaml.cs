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
        public wndMain()
        {
            InitializeComponent();
        }

        private void mnuOpenStorage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xml files (*.xml)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();

            var filename = openFileDialog.FileName;

            if (filename != string.Empty)
            {
                wndPassword wndPwd = new wndPassword();
                wndPwd.ShowDialog();

                var password = wndPwd.Password;

                if (password != string.Empty)
                {
                    lvGrid.ItemsSource = Business.Convertor.DecryptList(Business.XMLSerialize.DeserializeFromXML(filename), password);
                }
            }
        }

        private void lvGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((MobileStorage.StorageItems)(((object[])(e.AddedItems))[0])).Value);
        }

    }
}
