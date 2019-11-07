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

namespace FL4
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

        private void BtnCalculateBmi_Click(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(txtHeight.Text), mass = double.Parse(txtMass.Text);
            double bmi;

            bmi = mass / (height * height);
            bmi = mass / Math.Pow(height, 2);
            bmi = 25.5;
            int number = 4;

            int value = (int)bmi; // cast

            value = 5 / 4;  // heltalsdivision
            bmi = 5 / 4.0; // variant 1
            int remainder = 5 % 4;
            bmi = 5 / (double)number; // variant 2
            txtResult.Text = remainder.ToString();

            txtResult.Text = Math.Round(bmi,0).ToString();
            if (bmi < 18.5)
            {
                // Underviktig
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                // Normalvikt
            }
            else
            {
                // Övervikt
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price = double.Parse(txtMass.Text);
            int area = 57;

            double pricePerSquare = price / area;

            txtResult.Text = $"{pricePerSquare} kr/kvm";

        }
    }
}
