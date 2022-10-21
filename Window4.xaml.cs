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

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window10 nw = new Window10();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window6 nw = new Window6();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window7 nw = new Window7();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window8 nw = new Window8();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window9 nw = new Window9();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow nw = new MainWindow();
            nw.Show();
        }

       

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow nw = new MainWindow();
            nw.Show();
        }

        
        private void sn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window6 nw = new Window6();
            nw.ShowDialog();
            nw = null;
            this.Show();

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window7 nw = new Window7();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window8 nw = new Window8();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window9 nw = new Window9();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window10 nw = new Window10();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window5 nw = new Window5();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }

       

        private void rt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window5 nw = new Window5();
            nw.ShowDialog();
            nw = null;
            this.Show();
        }
    }
}
