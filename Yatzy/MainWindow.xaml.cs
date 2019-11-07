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

namespace Yatzy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // En slumpgenerator vid namn random
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void BtnRollDices_Click(object sender, RoutedEventArgs e)
        {
            int dieOne, dieTwo, dieThree, dieFour, dieFive, totalSum, bonus;
            // uppdrag
            // kasta en tärning och presentera resultatet 

            dieOne = random.Next(1, 7); // slumpa fram ett tal mellan 1 och 6
            dieTwo = random.Next(1, 7); // slumpa fram ett tal mellan 1 och 6
            dieThree = random.Next(1, 7); // slumpa fram ett tal mellan 1 och 6
            dieFour = random.Next(1, 7); // slumpa fram ett tal mellan 1 och 6
            dieFive = random.Next(1, 7); // slumpa fram ett tal mellan 1 och 6

            // Uppdrag Presentera resultatet av slumpgeneratorn
            // alla tärningar ska visas i gränssnittet
            lblDieOne.Content = dieOne; 
            lblDieTwo.Content = dieTwo; 
            lblDieThree.Content = dieThree; 
            lblDieFour.Content = dieFour;
            lblDieFive.Content = dieFive;

            // Beräkna totalsumman av alla tärningar
            totalSum = dieOne + dieTwo + dieThree + dieFour + dieFive;
            //totalSum = 62; // hårdkodat testdata
            // uppdrag 2. Får man bonus?

            if (totalSum >= 63)
            {
                bonus = 50;
                totalSum += bonus;
            }
            else
            {
                bonus = 0;
            }
            txtBonus.Text = bonus.ToString();
            txtTotal.Text = totalSum.ToString();

        }
    }
}
