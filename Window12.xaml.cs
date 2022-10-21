using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string id, name, address, mobile, email;

            id = i.Text;
            name = n.Text;
            address = a.Text;
            mobile = m.Text;
            email = em.Text;

            string mycon = "user id=root;server=127.0.0.1;database=cseproject";
            string query = "UPDATE `adteinfo` SET `Address`='" + address + "',`Mobile`='" + mobile + "',Email='" + email + "' WHERE `Id`='" + id + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();
            MessageBox.Show("Info Update Sucessfully");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            {
                string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
                string query = "SELECT  `Name`,`Id`, `Pay`, `Department`, `Position`, `Address`, `Mobile`, `Email` FROM `adteinfo` WHERE `ID`='" + i.Text + "'";
                MySqlConnection con = new MySqlConnection(mycon);
                con.Open();

                using (MySqlCommand com = new MySqlCommand(query, con))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(com))
                    {
                        da.Fill(dt);
                        dataGrid.ItemsSource = dt.DefaultView;
                        con.Close();
                    }
                }
            }
        }
    }
}
