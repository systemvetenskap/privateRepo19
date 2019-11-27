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

namespace FL6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shape shape;
        List<Shape> shapes;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void UpdateUI()
        {
            lstShapes.ItemsSource = null; // varför null? För att tömma listan
            lstShapes.ItemsSource = shapes;

            cboShapes.ItemsSource = null;
            cboShapes.ItemsSource = shapes;
            cboShapes.SelectedIndex = 0;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Skapa själva uppgiften
            Assignment assignment = new Assignment()
            {
                Number = 23
            };

            // Skapa rätt figur till uppgiften
            shape = Helper.CreateShape("Square", 2, 2);
            assignment.AddShape(shape);
            shape = Helper.CreateShape("Rectangle",1.5,2);
            assignment.AddShape(shape);

            shapes = assignment.GetShapes();


            assignment.AddShape(shape);
            txtTotalArea.Text = assignment.TotalArea.ToString();


            
            UpdateUI();
        }

        private void BtnSelectShape_Click(object sender, RoutedEventArgs e)
        {
            Shape selectedShape;

            //selectedShape= lstShapes.SelectedItem as Shape;

            selectedShape = cboShapes.SelectedItem as Shape;
            MessageBox.Show($"{selectedShape.Height}: {selectedShape.Width}");
        }
    }
}
