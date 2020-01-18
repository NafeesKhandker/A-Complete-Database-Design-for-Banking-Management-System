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
    /// Interaction logic for FixedAccount.xaml
    /// </summary>
    public partial class FixedAccount : UserControl
    {
        public FixedAccount()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                string Query = " SELECT * FROM database.clientinfo";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();

                while (myReader.Read())
                {


                    textBox1.Text = myReader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                try
                {

                    string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                    string Query = "INSERT INTO `database`.`Depositor` ( `AccountType`, `AccountNumber`, `Balance`) VALUES ('Fixed','" + this.textBox1.Text + "', '" + this.textBox2.Text + "')";
                    MySqlConnection mydata = new MySqlConnection(myconnect);
                    MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                    MySqlDataReader myReader;
                    mydata.Open();
                    myReader = cmdData.ExecuteReader();
                    mydata.Close();
                    MessageBox.Show("Your Account Create SucessFully.......");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Enter all required field...");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           
            grid.Children.Clear();
          
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            txtinterest.Text = "2.5";
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            txtinterest.Text = "5.5";
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            txtinterest.Text = "10";
        }

        private void checkBox4_Checked(object sender, RoutedEventArgs e)
        {
            txtinterest.Text = "15";
        }

       

      
    }
}
