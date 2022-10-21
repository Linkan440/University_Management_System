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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            data();
        }

  
        public void data()
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT * FROM `semester_courses`";
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
            string query = "SELECT * FROM adstregister where ID='" + id.Text + "'";
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
            string query = "UPDATE `adstregister` SET `Approval`='Approved' WHERE `ID`='" + id.Text + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;
            int count = 0;
            con.Open();
            reader = com.ExecuteReader();
            
            while (reader.Read())
            {
                count++;
            }
            con.Close();
            data2();
            MessageBox.Show("Student Registration Approved ");
            
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
    }
}
