using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_OOP.abstract_class
{
    class Rectangle:IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle()
        {
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimetter()
        {
            return (Width + Height) * 2;
        }
    }
}
