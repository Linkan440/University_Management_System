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
    /// Interaction logic for Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        public Window16()
        {
            InitializeComponent();
        }

        public bool isValid()
        {
            if (textBox.Text == string.Empty)
            {
                MessageBox.Show("Year is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Semester is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Examination is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            string id, year, semester, examination;
            id = i.Text;
            year = textBox.Text;
            semester = textBox1.Text;
            examination = textBox2.Text;




            try
            {
                if (isValid())
                {
                    MessageBox.Show("Successfully registered", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registered Successfully");
            }


            string mycon = "user id=root;server=127.0.0.1;database=cseproject";
            string query = "insert into adstregister (`ID`, `Year`, `Semester`, `Type`) values ('" + id + "','" + year + "', '" + semester + "', '" + examination + "')";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();


        }
    }
}
