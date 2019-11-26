using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    static class Helper
    {
        public static Shape CreateShape(string objectType, double height, double width)
        {
            Shape shape;
            if (objectType.Equals("Triangle"))
            {
                shape = new Triangle();
               
            }
            else if(objectType.Equals("Square"))
            {
                shape = new Square()
                {
                    Height = height,
                    Width = width
                };
            }
            else
            {
                shape = new Rectangle()
                {
                    Height = height,
                    Width = width
                };
            }
            shape.Height = height;
            shape.Width = width;
            return shape;
        }
    }
}
