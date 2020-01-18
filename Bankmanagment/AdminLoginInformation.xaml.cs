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
    /// Interaction logic for UserControl3.xaml
    /// </summary>
    public partial class AdminLoginInformation : UserControl
    {
        private string s;
        public AdminLoginInformation()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                string Query1 = " INSERT INTO `database`.`LoginInformation` (`UserName`, `Password`, `SequarityQuestion`, `FirstAnswer`, `SecondAnswer`, `UserType`) VALUES ('" + this.txt_username.Text + "', '" + this.txt_password.Text + "', '" + this.comb_question.Text + "', '" + this.txt_firstans.Text + "','" + this.txt_secondans.Text + "','" + this.comb_userType.Text + "')";

                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query1, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();
                MessageBox.Show("saved");
                while (myReader.Read())
                {

                }
                mydata.Close();

                grid1.Children.Clear();
                AccountType t = new AccountType();
                grid1.Children.Add(t);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            delleteclientinfo();
        
        }
        int generateAccountNumber()
        {
            string myconnect = "datasource=localhost;port=3306;username=root;password=root";


            string q = "SELECT * FROM database.clientinfo ";
            MySqlConnection mydata = new MySqlConnection(myconnect);
            MySqlCommand cmdData = new MySqlCommand(q, mydata);
            MySqlDataReader myReader;
            mydata.Open();
            myReader = cmdData.ExecuteReader();

            while (myReader.Read())
            {
                s = myReader.GetString(3);
            }
         int  id  = int.Parse(s);
         MessageBox.Show(id.ToString());
            return id;
        }   
      
        void delleteclientinfo()
        {
            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                // string q = "SELECT * FROM database.currentaccount join database.clientinfo on currentaccount.AccountNumber=clientinfo.AccountNumber";
                string Query = " DELETE FROM database.depositor WHERE `AccountNumber`='" + this.generateAccountNumber().ToString() + "'";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();


               // while (myReader.Read())
                //{

                //}
                mydata.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
    }
}
