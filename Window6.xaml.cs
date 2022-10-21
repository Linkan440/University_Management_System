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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            data();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "insert into adstinfo (`StudentID`, `Name`, `FatherName`, `MotherName`, `Blood`, `Address`, `Mobile`, `GuardianMobile`, `Email`, `DateOfBirth`) values('" + id.Text + "', '" + name.Text + "', '" + fna.Text + "', '" + mna.Text + "', '" + btype.Text + "','" + ad.Text + "', '" + mob.Text + "', '" + gmob.Text + "', '" + ema.Text + "', '" + bir.Text + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();           
            mob.Text = "";
            gmob.Text = "";
            ema.Text = "";
            bir.Text = "";
            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("Info. Inserted Successfully...");
        }
        public void data()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "select `StudentID`, `Name`, `FatherName`, `MotherName`, `Blood`, `Address`, `Mobile`, `Email` from adstinfo";
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
     
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "select `Name`, `Blood`, `Address`, `Mobile`, `GuardianMobile`, `Email`, `DateOfBirth` from adstinfo where StudentID='" + id.Text + "'";
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

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "DELETE FROM adstinfo where StudentID='" + id.Text + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            id.Text = "";
            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("Student Deleted Successfully From Database...");
        }
    }
}
