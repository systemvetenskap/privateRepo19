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

            // skapa objekt
            Rectangle rectangle = new Rectangle()
            {
                Height = 2,
                Width = 2
            };

            Rectangle rectangle2 = new Rectangle()
            {
                Height = 1.5,
                Width = 2,
            };

            Triangle triangle = new Triangle()
            {
                Height = 2,
                Width = 34,
            };

            Shape shape;

            shape = new Square()
            {
                Height=3,
                Width=3
            };

            // Uppdrag: Jag vill kunna spara alla figurer i en collection
            char[] chars = new char[2];
            chars[1] = 'b';
            bool[] bools;
            int[] integers;
            Rectangle[] rectangles = new Rectangle[2];

            // skapa lista
            List<Shape> shapes = new List<Shape>(); // flexibel eller dynamisk
            shapes.Add(rectangle);
            shapes.Add(rectangle2);
            shapes.Add(triangle);
            shapes.Add(shape);
            foreach (Shape s in shapes)
            {
                MessageBox.Show($"En {s.Type} med höjden: {s.Height} och bredden: {s.Width} och area: {s.Area()}");
            }



















            double bas, bas2, höjd, höjd2, totalArea, area1, area2;

            area1 = Area(rectangle.Height, rectangle.Width);


            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // figur 1
            bas = 2;
            höjd = 2;
            area1 = bas * höjd;


            // figur 2
            bas2 = 2;
            höjd2 = 1.5;
            area2 = bas2 * höjd2;

            // total area
            totalArea = area1 + area2;






        }
    }
}
