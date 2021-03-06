﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    /// <summary>
    /// Basklass som hanterar våra figurer
    /// Vår förälder
    /// </summary>
    class Shape 
    {

        public int NumberOfCorners { get; set; }


        public double Height { get; set; }
        public double Width { get; set; }
        public string Type { get; protected set; }

        // skapa en grundmetod. Använd om du vill, ändra om du måste
        // polymorfism = att en och samma metod kan ha olika skepnader
        public virtual double Area()  // lägg till ordet virtual
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"{Type}: {Area()} kvm";
        }
    }
}
