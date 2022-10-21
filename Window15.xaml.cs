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
    /// Interaction logic for Window15.xaml
    /// </summary>
    public partial class Window15 : Window
    {
        public Window15()
        {
            InitializeComponent();
        }
        public bool isValid()
        {
            if (text.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox3_Copy2.Text == string.Empty)
            {
                MessageBox.Show("ID is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Address is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Mobile is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox3_Copy1.Text == string.Empty)
            {
                MessageBox.Show("Date of Birth is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox3_Copy.Text == string.Empty)
            {
                MessageBox.Show("Gardian Mobile is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name, id, address, mobile, email, date_of_birth, g_mobile;
            name = text.Text;
            id = textBox3_Copy2.Text;
            address = textBox1.Text;
            mobile = textBox2.Text;
            email = textBox3.Text;
            date_of_birth = textBox3_Copy1.Text;
            g_mobile = textBox3_Copy.Text;



            try
            {
                if (isValid())
                {
                    MessageBox.Show("Info. Save Successfully", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Save Successfully");
            }



            string mycon = "user id=root;server=127.0.0.1;database=cseproject";
            string query = "UPDATE `adstinfo` SET `Address`='" + address + "',`Mobile`='" + mobile + "',`GuardianMobile`='" + g_mobile + "',`Email`='" + email + "',`DateOfBirth`='" + date_of_birth + "' WHERE `StudentID`='" + id + "'";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            con.Close();




        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
            textBox3_Copy2.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3_Copy1.Clear();
            textBox3_Copy.Clear();
        }

    }
}
