using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    class Polygon : Shape
    {
        public Polygon(int numberOfCorners)
        {
           NumberOfCorners = numberOfCorners;
        }
        public Polygon() { }
    }
}
