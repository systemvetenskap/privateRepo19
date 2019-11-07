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

namespace FL3
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
            // boolskt uttryck
            // bool = true eller false

            // <   mindre än
            // >   större än
            // ==  lika med

            // !=   skiljt från

            // &&   logiskt och (and)
            // ||   logiskt eller (or)

            int myAge = 44;
            int yourAge = 55;

            int myWeight = 55;
            int referenceWeight = 10; // döp om med ctrl R + R

            string message="";
            char c= 'a';

            if (myAge != yourAge)
            {
                // jag är äldre än du
                message = "Jag är äldst";
            }



            if (myWeight > referenceWeight)
            {
                message = "Du är tyngre än referensvikten";
                // undersök bmi
                if (true) // är mitt bmi större än 25
                {
                    // gör något utifrån svaret
                }
            }
            else
            {
                message = "Så bra, vi verkar vara lika typ";
            }

            int myLength = 135;
            if (myLength <=135 && myLength > 120)
            {
                // jag får åka karusell
            }




            MessageBox.Show(message);
        }
    }
}
