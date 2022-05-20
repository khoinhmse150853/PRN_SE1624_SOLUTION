using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_OOP.abstract_class
{
    public abstract class Shape
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            Color = color;
        }

        protected Shape()
        {
        }

        public abstract double GetArea();
        public abstract double GetPerimetter();

        public virtual void Display()
        {
            Console.WriteLine($"Color is: {Color}");
        }
    }
}
