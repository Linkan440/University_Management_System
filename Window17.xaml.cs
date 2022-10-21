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
    /// Interaction logic for Window17.xaml
    /// </summary>
    public partial class Window17 : Window
    {
        public Window17()
        {
            InitializeComponent();
        }



        public void disp_data()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT * FROM adsresult where StudentID='" + st_id.Text + "'";
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



        private void click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject";
            string query = "SELECT * FROM adsresult where StudentID='" + st_id.Text + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();

            disp_data();

        }
    }
}
