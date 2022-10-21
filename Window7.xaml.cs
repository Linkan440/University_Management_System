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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

       
        
        public void data2()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT * FROM adsresult where StudentID='" + id.Text + "'";
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
            string g;
            if (checkBi.IsChecked == true)
            {
                g = "Bi-semester";
            }
            else
            {
                g = "Tri-semester";

            }
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT `CourseCode`, `Title`, `Credit`, `Remark` FROM `semester_courses` WHERE `Year`='" + ye.Text + "' AND (`Semester`='" + se.Text + "' AND `Type`='" + g + "');";
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

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "server=127.0.0.1;user id=root;database=cseproject";
            string query = "INSERT INTO `adsresult`(`StudentID`, `Year`, `Semester`, `Credit`, `CGPA`) VALUES ('" + id.Text+"','"+ye.Text + "','"+se.Text + "','"+cre.Text + "','"+cg.Text + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            con.Close();
            data2();
            MessageBox.Show("Student Result is summarized ");
        }
    }
}
