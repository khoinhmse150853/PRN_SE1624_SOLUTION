using PRN_SE1624_OOP.abstract_class;
using System;
using System.Collections;

namespace PRN_SE1624_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lập trình tạo ra một list
            //Create a object (instance)
            //Employee employee = new Employee();
            //employee.Id = 15;
            //employee.Name = "Khoi dep trai";
            //employee.Level = "Fresher";
            //employee.Salary = 15000.55f;
            //Console.WriteLine(employee.ToString());

            //Employee e = new Employee(25.55f, "Hello", 25, "Namm", DateTime.Now);
            //Console.WriteLine(e);
            //Console.WriteLine(e.ToString());

            //ArrayList lstEmps = new ArrayList();
            //lstEmps.Add(e);
            //lstEmps.Add(new Employee(25.55f, "Manager", 2, "Khoi", DateTime.Now));
            //lstEmps.Add(new Employee(45.55f, "Manager", 3, "Khoi", DateTime.Now));
            //lstEmps.Add(new Employee(234.55f, "Manager", 4, "Khoi", DateTime.Now));
            //lstEmps.Add(new Employee(25.55f, "Manager", 5, "Khoi", DateTime.Now));
            //Display(lstEmps);

            Circle c = new Circle(1525d, "Red");

            Shape s = new Circle(15d,"Yellow");
            s.Display();

            IShape s2 = new Rectangle() { Width = 124, Height = 456 };
            Console.WriteLine(s2.GetArea());

            Console.WriteLine(c);
        }

        public static void Display(ArrayList lstData)
        {
            foreach (Employee e in lstData)
            {
                Console.WriteLine(e);
            }
        }
    }
}
