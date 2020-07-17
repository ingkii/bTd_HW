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

namespace subproject
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

        private void Cal_Click(object sender, RoutedEventArgs e)
        {
            double Cal = double.Parse(txtN.Text) / (double.Parse(txtIn.Text) - double.Parse(txtEx.Text));
            txtDays.Text =  $"{(Cal)}";
        }

        private void reSet_Click(object sender, RoutedEventArgs e)
        {
            txtIn.Clear();
            txtEx.Clear();
            txtN.Clear();
            txtDays.Clear();
        }
    }
}
