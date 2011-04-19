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
    public partial class wndPassword : Window
    {

        public string Password { get; set; }

        public wndPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Password = pwdBox.Password;
            this.Close();
        }
    }
}
