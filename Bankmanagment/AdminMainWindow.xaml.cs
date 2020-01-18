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
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {

        public AdminMainWindow()
        {
            InitializeComponent();
            
        }

      
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ShowAll u = new ShowAll();
            grid1.Children.Clear();
            grid1.Children.Add(u);
           
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            
            grid1.Children.Clear();
         

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e){
          
            grid1.Children.Clear();
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
           
       
        }

      

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            CreateAccount c = new CreateAccount();
            grid1.Children.Clear();
            grid1.Children.Add(c);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        

    }
}
