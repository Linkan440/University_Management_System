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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String pass;
            String username;
            username = user.Text;
            pass = passw.Password;
            if (username == "abc" && pass == "123")
            {
                this.Hide();
                Window11 ls = new Window11();
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
