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

        private void SågaBräda()
        {
        }


        private void BtnRollDices_Click(object sender, RoutedEventArgs e)
        {
            int[] dices = gameEngine.RoleDices();
        }

        private void BtnSaveScore_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtOnes.Text);
            gameEngine.SaveScore(score, 1);
            

        }
    }
}
