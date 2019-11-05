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

namespace FL1
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

        // En händelse för klick på knappen BtnShowName
        private void BtnShowName_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Hej";
            MessageBox.Show("Hej världen");
            // ny kod
            // ny kod
            // ny kod
            // ny kod
            // ny kod
            // ny kod
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

    
    }
}
