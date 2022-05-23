using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_PRODUCT_MANAGER.Entities
{
    public interface IProduct
    {
        void Add(Product p);
        void Remove(Product p);
        bool Update(Product p);
        Product Get(int index);
        void Display();
    }
}
