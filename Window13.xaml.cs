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
    /// Interaction logic for Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        public Window13()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "SELECT `CourseCode`, `Title`, `Room`, `Time` FROM `teaclass` WHERE `TeacherID`='" + txt_id.Text + "'";
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
