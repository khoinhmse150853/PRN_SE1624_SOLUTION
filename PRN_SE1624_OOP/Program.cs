using System;

namespace PRN_SE1624_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lập trình tạo ra một list
            //Create a object (instance)
            Employee employee = new Employee();
            employee.Id = 15;
            employee.Name = "Khoi dep trai";
            employee.Level = "Fresher";
            employee.Salary = 15000.55f;
            Console.WriteLine(employee.ToString());

            Employee e = new Employee(25.55f, "Hello", 25, "Namm", DateTime.Now);
            Console.WriteLine(e);
            Console.WriteLine(e.ToString());
        }
    }
}
