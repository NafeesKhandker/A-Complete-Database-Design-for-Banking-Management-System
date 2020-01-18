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
using MySql.Data.MySqlClient;

namespace Bankmanagment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }
        private void move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {   //string q="SELECT * FROM database.person WHERE City='khulna'";
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                string Query = "SELECT * FROM database.LoginInformation where UserName='" + this.textBox1.Text + "'and Password='" + this.passwordBox1.Password + "' ;";

                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();
                // MessageBox.Show("saved");
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show(myReader.GetValue(6).ToString());
                    if (myReader.GetValue(6).ToString() == "Admin")
                    {
                        //MessageBox.Show("Username and Password is correct");
                        AdminMainWindow w1 = new AdminMainWindow();
                        Application.Current.MainWindow = w1;
                        w1.Show();
                        Close();
                    }
                    else
                    {
                        Window2 w = new Window2();
                        Application.Current.MainWindow = w;
                        w.Show();
                        Close();
                    }
                }
                else if (count > 1)
                {
                    MessageBox.Show("Diplicate Username and Password..");
                }
                else
                {

                    MessageBox.Show("Username and Password is not correct");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
