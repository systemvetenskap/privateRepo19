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
        
        public MainWindow()
        {
            InitializeComponent();
        }

        // Lägg inte metoden här, utan lägg den i rätt klass
        private  double Area(double height, double width)
        {
            return height * width;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Shape shape;
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
            assignment.AddShape(shape);
            assignment.AddShape(shape);

            List<Shape> shapes = assignment.GetShapes();


        }
    }
}
