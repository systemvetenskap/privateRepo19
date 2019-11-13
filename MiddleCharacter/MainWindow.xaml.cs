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

namespace MiddleCharacter
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

        // Mata metoden med en parameter av typen string
        private string GetMiddle(string word)
        {
            int middle = word.Length / 2;  // heltalsdivision ger alltid heltal 2,1   2,9
            string result = "";
            if (word.Length % 2 != 0)
            {
                result = word[middle].ToString();
            }

            else
            {
                result = $"{word[middle - 1]}{word[middle]}";
            }
            return result;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // vi gör ett metodanrop

            string word = txtInput.Text;
            string middleChars = GetMiddle(word);

            
        }


    }
}
