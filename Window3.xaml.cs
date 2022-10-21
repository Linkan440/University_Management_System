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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String pass;
            String username;
            username = user.Text;
            pass = passw.Password;
            if (username == "20201060010" && pass == "12345678")
            {
                this.Hide();
                Window14 ls = new Window14();
                ls.Show();
                MessageBox.Show("Successfully Login");
            }
            else if (username == "20201036010" && pass == "12345678")
            {
                this.Hide();
                Window14 ls = new Window14();
                ls.Show();
                MessageBox.Show("Successfully Login");
            }
            else if (username == "20201037010" && pass == "12345678")
            {
                this.Hide();
                Window14 ls = new Window14();
                ls.Show();
                MessageBox.Show("Successfully Login");
            }
            else if (username == "2" && pass == "2")
            {
                this.Hide();
                Window14 ls = new Window14();
                ls.Show();
                MessageBox.Show("Successfully Login");
            }
            else
            {
                MessageBox.Show("Wrong password. Try again....");
            }
        }
    }
}
