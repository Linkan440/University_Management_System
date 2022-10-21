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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            data();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject";
            string query = "insert into adteinfo (`name`, `id`, `pay`, `department`, `position`, `address`, `mobile`, `email`) values('" + name.Text + "', '" + tid.Text + "', '" + pa.Text + "', '" + dep.Text + "', '" + pos.Text + "', '" + adr.Text + "', '" + mob.Text + "', '" + ema.Text + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            name.Text = "";
            tid.Text = "";
            pa.Text = "";
            dep.Text = "";
            pos.Text = "";
            adr.Text = "";
            mob.Text = "";
            ema.Text = "";
            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("Info. Inserted Successfully...");
        }
        public void data()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "select * from adteinfo";
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
     

        private void view_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "select * from adteinfo where id='" + tid.Text + "' or name='" + name.Text+"'";
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
            string mycon = "user id=root;server=127.0.0.1;database=cseproject";
            string query = "DELETE FROM adteinfo WHERE ID= '" + tid.Text + "' or Name='" + name.Text + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();
            data();
            MessageBox.Show("Teacher Deleted Successfully From Database...");
        }
    }
}
