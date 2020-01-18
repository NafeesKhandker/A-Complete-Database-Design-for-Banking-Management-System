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

namespace Bankmanagment
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount u = new CreateAccount();
            grid3.Children.Clear();
            grid3.Children.Add(u);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Withdraw w = new Withdraw();
            grid3.Children.Clear();
            grid3.Children.Add(w);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DeleteAccount d = new DeleteAccount();
            grid3.Children.Clear();
            grid3.Children.Add(d);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            BalanceEquity b = new BalanceEquity();
            grid3.Children.Clear();
            grid3.Children.Add(b);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Deposite d = new Deposite();
            grid3.Children.Clear();
            grid3.Children.Add(d);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            AllTransaction t = new AllTransaction();
            grid3.Children.Clear();
            grid3.Children.Add(t);
        }
    }
}
