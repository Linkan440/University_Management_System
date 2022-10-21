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
    /// Interaction logic for Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        public Window14()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window15 sls = new Window15();
            sls.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Window16 lss = new Window16();
            lss.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window17 lss = new Window17();
            lss.Show();
        }

    }
}
