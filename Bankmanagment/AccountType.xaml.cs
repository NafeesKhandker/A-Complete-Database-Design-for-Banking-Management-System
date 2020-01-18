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
    /// Interaction logic for AccountType.xaml
    /// </summary>
    public partial class AccountType : UserControl
    {
        public AccountType()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            CurentAccount c = new CurentAccount();
            grid.Children.Clear();
            grid.Children.Add(c);

        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            SavingsAccount c = new SavingsAccount();
            grid.Children.Clear();
            grid.Children.Add(c);
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            FixedAccount c = new FixedAccount();
            grid.Children.Clear();
            grid.Children.Add(c);
        }
    }
}
