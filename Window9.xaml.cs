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
    /// Interaction logic for Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
            data();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT  `TeacherID`,`CourseCode`, `Title`, `Room`, `Time` FROM `teaclass` WHERE `TeacherID`='" + id.Text + "'";
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

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "  INSERT INTO `teaclass`(`CourseCode`, `Title`, `Room`, `Time`, `TeacherID`) VALUES( '" + cc.Text + "', '" + ct.Text + "', '" + ro.Text + "','" + ti.Text + "','" + id.Text + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            cc.Text = "";
            ct.Text = "";
            ro.Text = "";
            ti.Text = "";

            reader = com.ExecuteReader();
            con.Close();
            data2();
            MessageBox.Show("Info. Inserted Successfully...");
        }
        public void data()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT  `TeacherID`,`CourseCode`, `Title`, `Room`, `Time` FROM `teaclass`";
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
        public void data2()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT  `TeacherID`,`CourseCode`, `Title`, `Room`, `Time` FROM `teaclass` WHERE `TeacherID`='" + id.Text + "'";
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
