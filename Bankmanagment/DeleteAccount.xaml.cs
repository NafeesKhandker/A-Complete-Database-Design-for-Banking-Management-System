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
    /// Interaction logic for DeleteAccount.xaml
    /// </summary>
    public partial class DeleteAccount : UserControl
    {
        public DeleteAccount()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
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
                    string name = myReader.GetString(0);
                    comboAccountList.Items.Add(name);

                }

                mydata.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void delleteclientinfo() {
            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
               // string q = "SELECT * FROM database.currentaccount join database.clientinfo on currentaccount.AccountNumber=clientinfo.AccountNumber";
                string Query = " DELETE FROM database.clientinfo WHERE `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();


                while (myReader.Read())
                {

                }
                mydata.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }

        void delletedepositor()
        {
            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                // string q = "SELECT * FROM database.currentaccount join database.clientinfo on currentaccount.AccountNumber=clientinfo.AccountNumber";
                string Query = " DELETE FROM database.depositor WHERE `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();


                while (myReader.Read())
                {

                }
                mydata.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        void delletelogininformation()
        {
            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                // string q = "SELECT * FROM database.currentaccount join database.clientinfo on currentaccount.AccountNumber=clientinfo.AccountNumber";
                string Query = " DELETE FROM database.depositor WHERE `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();


                while (myReader.Read())
                {

                }
                mydata.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            delleteclientinfo();
            delletedepositor();
            delletelogininformation();
        }
    }
}
