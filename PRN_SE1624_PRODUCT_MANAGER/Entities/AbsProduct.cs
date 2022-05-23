using PRN_SE1624_PRODUCT_MANAGER.Functionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_PRODUCT_MANAGER.Entities
{
    public abstract class AbsProduct
    {
        protected Product[] products;
        protected int size;

        protected AbsProduct()
        {
            this.products = new Product[Utils.InitNumberProduct];
            this.size = 0;
        }
    }
}
