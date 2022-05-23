using PRN_SE1624_PRODUCT_MANAGER.Entities;
using PRN_SE1624_PRODUCT_MANAGER.Functionals;
using System;

namespace PRN_SE1624_PRODUCT_MANAGER
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            Product p = new Product(1, "Dell 15inches", "Dell moi nhat 2022", 1520d, new DateTime(year: 2022, month: 5, day:22));
            productManager.Add(p);
            productManager.Add(new Product(2, "Macbook pro 2021", "Mac moi nhat 2022", 2500d, DateTime.Now));
            productManager.Add(new Product(3, "Macbook pro 2022", "Mac moi nhat 2022", 2500d, DateTime.Now));
            productManager.Add(new Product(4, "Macbook pro 2023", "Mac moi nhat 2022", 2500d, DateTime.Now));
            //Console.WriteLine(p);
            productManager.Display();
            Console.WriteLine(productManager.Get(1));
        }
    }
}
