using System;

namespace PRN_SE1624_PRO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Hello con cặc");
            ////int x = 10, y = 20;
            ////var data = GetDataAPIs("https://abc.com.vn/getCustomers");

            //Console.WriteLine($"Enter value for x and y: ");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Total of x = {x} and y = {y} is: {Sum(x,y)}");
            //Console.ReadLine();

            int x = 10, y = 20, z = 30;
            DemoRefAndOutValue.MyMethod(x, ref y, out z);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"x = {x}; y = {y}; z = {z}");
            int? a = null;
            if(a is null)
            {
                Console.WriteLine("Nam mat lon");
            }
            Console.ReadLine();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
