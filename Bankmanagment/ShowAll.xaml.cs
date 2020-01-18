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
    /// Interaction logic for ShowAll.xaml
    /// </summary>
    public partial class ShowAll : UserControl
    {
        public ShowAll()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            string myconnection = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection mydata = new MySqlConnection(myconnection);
            MySqlCommand cmdData = new MySqlCommand("select*from database.ClientInfo;", mydata);
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

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

      
       
    }
}
