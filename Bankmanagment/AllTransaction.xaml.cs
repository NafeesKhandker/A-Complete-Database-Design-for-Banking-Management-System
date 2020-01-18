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
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using Microsoft.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Bankmanagment
{
    /// <summary>
    /// Interaction logic for AllTransaction.xaml
    /// </summary>
    public partial class AllTransaction : UserControl
    {
        public AllTransaction()
        {
            InitializeComponent();
            showAlltransaction();
        }
        void showAlltransaction() { 
        
            string myconnection = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection mydata = new MySqlConnection(myconnection);
            MySqlCommand cmdData = new MySqlCommand("SELECT * FROM database.AllTransaction ORDER BY AllTransaction.Date DESC", mydata);
            try
            {
                MySqlDataAdapter dataAdp = new MySqlDataAdapter();
                dataAdp.SelectCommand = cmdData;
                DataTable dbDataSet = new DataTable();
                dataAdp.Fill(dbDataSet);
                dataGrid1.ItemsSource = dbDataSet.DefaultView;
                dataAdp.Update(dbDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
