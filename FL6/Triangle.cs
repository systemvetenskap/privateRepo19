using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    class Triangle : Shape
    {
        public int Test { get; set; }
        public Triangle()
        {
            Type = "Triangel";
        }
        public override double Area()  // override = skriv över och ändra
        {
            return (Height * Width)/(double)2;
        }
    }
}
