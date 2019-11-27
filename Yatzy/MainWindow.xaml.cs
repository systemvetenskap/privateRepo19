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
        GameEngine gameEngine;


        public MainWindow()
        {
            // Den här koden körs en och endast en gång
            // nämligen när objektet skapas
            InitializeComponent();
            gameEngine = new GameEngine();
        }
        #region Gränssnittsmetoder

        private void DisplayDices(int[] input)
        {
            lblDieOne.Content = input[0].ToString();
            lblDieTwo.Content = input[1].ToString();
            lblDieThree.Content = input[2].ToString();
            lblDieFour.Content = input[3].ToString();
            lblDieFive.Content = input[4].ToString();
        }

        private bool[] GetSavedDices()
        {
            bool[] isSaved = new bool[5];
            isSaved[0] = (bool)chkDieOne.IsChecked;
            isSaved[1] = (bool)chkDieTwo.IsChecked;
            isSaved[2] = (bool)chkDieThree.IsChecked;
            isSaved[3] = (bool)chkDieFour.IsChecked;
            isSaved[4] = (bool)chkDieFive.IsChecked;
            return isSaved;
        }

        private void DisplayScore()
        {
            txtOnes.Text = gameEngine.Ones.ToString();
            txtFives.Text = gameEngine.Fives.ToString();
            txtTotal.Text = gameEngine.Total.ToString();
            txtBonus.Text = gameEngine.Bonus.ToString();
        }
        #endregion


        private void BtnRollDices_Click(object sender, RoutedEventArgs e)
        {
            bool[] savedDices = GetSavedDices();
            DisplayDices(gameEngine.RoleDices(savedDices));
        }

        private void BtnSaveScore_Click(object sender, RoutedEventArgs e)
        {
            gameEngine.SaveScore(5);
            DisplayScore();

        }
    }
}
