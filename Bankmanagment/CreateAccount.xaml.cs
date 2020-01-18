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
using MySql.Data.MySqlClient;


namespace Bankmanagment
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

       

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {
            AdminLoginInformation u3 = new AdminLoginInformation();

            try
            {
                if (txt_name.Text != string.Empty && txt_presentadress.Text != string.Empty && txt_prmanentaddress.Text != string.Empty && txt_contact.Text != string.Empty && datePic_createdate.Text != string.Empty)
                {
                    string myconnect = "datasource=localhost;port=3306;username=root;password=root";
                    string Query = " INSERT INTO `database`.`clientinfo` (`name`, `surname`, `peresentadress`, `parmanentadress`, `country`, `contatctnumber`, `telephonenumber`, `email`, `dateofbirth`, `accountcreatedate`, `age`, `accupation`, `annualincome`, `openingaccount`) VALUES ('" + this.txt_name.Text + "', '" + this.txt_surname.Text + "', '" + this.txt_presentadress.Text + "', '" +this. txt_prmanentaddress.Text + "', '" + this.comb_country.Text + "', '" + this.txt_contact.Text + "', '" + this.txt_telephone.Text + "', '" + this.txt_email.Text + "', '" + this.datePic_birth.SelectedDate + "', '" + this.datePic_createdate.SelectedDate + "', '" + this.txt_age.Text + "', '" + this.comb_occupation.Text + "', '" + this.comb_annualIncome.Text + "', '" + this.comb_openingAmmount.Text + "')";


                    MySqlConnection mydata = new MySqlConnection(myconnect);
                    MySqlCommand cmdData = new MySqlCommand(Query, mydata);
                    MySqlDataReader myReader;
                    mydata.Open();
                    myReader = cmdData.ExecuteReader();
                    MessageBox.Show("saved");
                    grid.Children.Clear();
                    grid.Children.Add(u3);

                    while (myReader.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Enter all required field...");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {

            txt_name.Text = "";
            txt_presentadress.Text = "";
            txt_prmanentaddress.Text = "";
            datePic_createdate.Text = "";
            
        }

    }
}
