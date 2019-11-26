using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    class Assignment //= kund
    {
        public int Number { get; set; }

        //  public List<Shape> Shapes { get; private set; }
        private List<Shape> shapes;
        public Assignment()
        {
            shapes = new List<Shape>();
        }


        public bool AddShape(Shape shape)
        {
            
            if (shapes.Count < 2)
            {
                shapes.Add(shape);
                return true;
            }
            return false;
        }

        public List<Shape> GetShapes()
        {
            return shapes.OrderBy(x => x.Height).ToList();
        }

    }
}
