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

namespace Challenge
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = "What a gorgeous day.";
            text = "Dude, this is so awesome!";
            double mean = 0;
            int countWords = 1, totalSum = 0;

            // 4 + 1 + 6 + 3

            foreach (char c in text)
            {
                if (Char.IsWhiteSpace(c))
                {
                    // aha, ett nytt ord
                    countWords++;
                }
                else if (Char.IsLetter(c))
                {
                    // men då måste det vara en bokstav
                    totalSum++;
                }
            }

            // beräkna medelvärdet
            mean = totalSum / (double)countWords;  // heltalsdivison


        }
    }
}
