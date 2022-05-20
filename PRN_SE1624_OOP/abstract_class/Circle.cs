using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_OOP.abstract_class
{
    public class Circle:Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public Circle()
        {
        }

        public Circle(double radius, string color):base(color)
        {
            _radius = radius;
        }

        public double Radius { get => _radius; set => _radius = value; }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);


        public override double GetPerimetter() => 2 * Math.PI * _radius;

        public override string ToString()
        {
            return $"The circle has radius = {Radius}, Area = {GetArea()}, Perimetter = {GetPerimetter()} and Color = {Color}";
        }

        public override void Display()
        {
            Console.WriteLine("abc");
        }
    }
}
