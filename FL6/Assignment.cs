using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    class Assignment 
    {
        public int Number { get; set; }
        public double TotalArea => CalculateTotalArea();

        //  public List<Shape> Shapes { get; private set; }
        private List<Shape> shapes;
        public Assignment()
        {
            shapes = new List<Shape>();
        }
        // Beräkna totala arean
        private double CalculateTotalArea()
        {
            double total = 0;
            foreach (Shape s in shapes)
            {
                total += s.Area();
            }
            return total;
        }
            

    public bool AddShape(Shape shape)
        {
            
            if (shapes.Count < 100)
            {
                shapes.Add(shape);
                return true;
            }
            return false;
        }

        public List<Shape> GetShapes()
        {
            return shapes;
        }

    }
}
