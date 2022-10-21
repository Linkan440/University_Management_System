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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void admi_Click(object sender, RoutedEventArgs e)
        {
            string adm, pass;
            adm =adid.Text;
            pass=adpass.Password;
            string mycon = "user id=root;server=127.0.0.1;database=cseproject;allowuservariables=True";
            string query = "select * from adpass where ID = '" + adm + "'and Password='" + pass + "'";
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
            if (count == 1)
            {
                this.Hide();
                Window4 ls = new Window4();
                ls.Show();                                        
            }
            else
            {
                MessageBox.Show("Wrong password. Try again....");
            }
        }
    }
}
