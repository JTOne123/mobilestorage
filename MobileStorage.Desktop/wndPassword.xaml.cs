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
        public wndPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            if(string.IsNullOrEmpty(pwdBox.Password))
            {
                MessageBox.Show("Please enter password");
                return;                
            }

            this.Close();
        }

        public string GetPassword()
        {
            this.ShowDialog();
            return pwdBox.Password;            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
