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
    /// Interaction logic for Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();
            data();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "INSERT INTO `adpass`(`ID`, `Password`) VALUES ( '" + ad.Text + "', '" + pa.Text + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            ad.Text = "";
            pa.Text = "";


            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("User Inserted Successfully...");
        }
        public void data()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT * FROM `adpass`";
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
        private void update_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "UPDATE `adpass` SET `Password`='" + pa.Text + "' WHERE `ID`='" + ad.Text + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            ad.Text = "";
            pa.Text = "";


            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("User Ifo Updated Successfully...");
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "DELETE FROM `adpass` WHERE `ID`='" + ad.Text + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            ad.Text = "";
            pa.Text = "";


            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("User Deleted Successfully...");
        }
    }
}
