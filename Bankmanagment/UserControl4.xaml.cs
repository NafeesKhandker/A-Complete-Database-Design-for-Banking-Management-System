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

namespace Bankmanagment
{
    /// <summary>
    /// Interaction logic for UserControl4.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            grid1.Children.Clear();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

             UserControl2 u2 = new UserControl2();
            grid1.Children.Clear();
            grid1.Children.Add(u2);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
