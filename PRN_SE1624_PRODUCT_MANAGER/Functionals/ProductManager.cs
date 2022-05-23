using PRN_SE1624_PRODUCT_MANAGER.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_PRODUCT_MANAGER.Functionals
{
    public class ProductManager : AbsProduct,IProduct
    {

        public ProductManager()
        {

        }
        public void Add(Product p)
        {
            if(this.size >= this.products.Length)
            {
                Product[] tmp = new Product[this.size * 2];
                for(int i = 0; i < this.size; i++)
                {
                    tmp[i] = this.products[i];
                }
                this.products = tmp;
            }
            this.products[this.size++] = p;
        }

        public void Display()
        {
            foreach(Product p in this.products)
            {
                if(p is Product)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }

        public Product Get(int index)
        {
            if(index < 0 || index >= this.products.Length)
            {
                return null;
            }
            else
            {
                return this.products[index];
            }
        }

        public void Remove(Product p)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
