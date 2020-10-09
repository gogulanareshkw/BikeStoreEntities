using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStoreEntities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ModelYear { get; set; }
        public decimal ListPrice { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
//        public Stock Stock { get; set; }
//        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
