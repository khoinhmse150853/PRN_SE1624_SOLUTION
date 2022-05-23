using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_PRODUCT_MANAGER.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Desc { get; set; }
        public double UnitPrice { get; set; }
        public DateTime? CreateDate { get; set; }

        public Product(int id, string productName, string desc, double unitPrice, DateTime? createDate)
        {
            Id = id;
            ProductName = productName;
            Desc = desc;
            UnitPrice = unitPrice;
            CreateDate = createDate;
        }

        public Product()
        {
        }

        public override string? ToString() => $"ID = {Id}, Product Name = {ProductName}, Unit Price = {UnitPrice}, Create Date = {CreateDate}";
        
    }
}
