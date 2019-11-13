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

namespace Capitalize
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

        private string Captialize(string text)
        {
            string[] words = text.Split(' ');
            string title = "";

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    // om det är första bokstaven i ordet --> index = 0
                    if (i == 0)
                    {
                        title += Char.ToUpper(word[0]);
                    }
                    else
                    {
                        title += Char.ToLower(word[i]);
                    }
                }
                // vi har hittat alla bokstäver i ordet
                // lägga på ett mellanslag
                title += " ";
            }
            return title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string text = Captialize("This is a title");


            
        }
    }
}
