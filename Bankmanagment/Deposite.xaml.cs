﻿using System;
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
    /// Interaction logic for Deposite.xaml
    /// </summary>
    public partial class Deposite : UserControl
    {
        private int balance;
        private string name;
        public Deposite()
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
        int get_balance()
        {
            string myconnect = "datasource=localhost;port=3306;username=root;password=root";


            string q = "SELECT * FROM database.depositor where  `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'";
            MySqlConnection mydata = new MySqlConnection(myconnect);
            MySqlCommand cmdData = new MySqlCommand(q, mydata);
            MySqlDataReader myReader;
            mydata.Open();
            myReader = cmdData.ExecuteReader();

            while (myReader.Read())
            {
                name = myReader.GetString(3);
            }
            balance = int.Parse(this.comboTranAmmount.Text) + int.Parse(name);
            return balance;
        }
        void getTransaction()
        {
            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                string Query1 = " INSERT INTO `database`.`AllTransaction` (`Discription`, `TransactionBalance`, `AccountNumber`) VALUES ('Deposite','" + int.Parse(this.comboTranAmmount.Text) + "','" + this.comboAccountList.Text + "')";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query1, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();
                MessageBox.Show("saved");
                mydata.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        } 
        private void btnCreditAccount_Click_1(object sender, RoutedEventArgs e)
        {
             try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";

                string q = "UPDATE `database`.`depositor` SET `Balance`='" + get_balance() + "' WHERE `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'";
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(q, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();
                mydata.Close();
                MessageBox.Show("Your Account  Credit By " + comboTranAmmount.Text + " Successfully ");
                getTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }
    }
}
