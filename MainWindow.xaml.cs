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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void adlog_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 ad = new Window1();
            ad.Show();
        }

        private void telog_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 ad = new Window2();
            ad.Show();
        }

        private void stlog_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window3 ad = new Window3();
            ad.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 ad = new Window1();
            ad.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 ad = new Window2();
            ad.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window3 ad = new Window3();
            ad.Show();
        }
    }
}
