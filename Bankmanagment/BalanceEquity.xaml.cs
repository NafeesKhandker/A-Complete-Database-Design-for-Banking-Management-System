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
using System.Data;

namespace Bankmanagment
{
    /// <summary>
    /// Interaction logic for BalanceEquity.xaml
    /// </summary>
    public partial class BalanceEquity : UserControl
    {
        public BalanceEquity()
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
        void show()
        {
            {
                string myconnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection mydata = new MySqlConnection(myconnection);
                string q = " SELECT * FROM database.alltransaction WHERE `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'";
                MySqlCommand cmdData = new MySqlCommand(q, mydata);
                try
                {
                    MySqlDataAdapter dataAdp = new MySqlDataAdapter();
                    dataAdp.SelectCommand = cmdData;
                    DataTable dbDataSet = new DataTable();
                    dataAdp.Fill(dbDataSet);
                    dataGrid.ItemsSource = dbDataSet.DefaultView;
                    dataAdp.Update(dbDataSet);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void btnCheckBalance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            
                string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                string Query = " SELECT * FROM database.depositor  WHERE `AccountNumber`='" + this.comboAccountList.SelectedItem.ToString() + "'"; 
                MySqlConnection mydata = new MySqlConnection(myconnect);
                MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                MySqlDataReader myReader;
                mydata.Open();
                myReader = cmdData.ExecuteReader();


                while (myReader.Read())
                {
                    textBox1.Text = myReader.GetValue(3).ToString();
                    textBox2.Text = myReader.GetValue(4).ToString();
                }

                mydata.Close();
                show();
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
