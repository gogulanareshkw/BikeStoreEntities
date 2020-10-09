using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStoreEntities
{
    public class Store : AuditFields
    {
        public int StoreId { get; set; }
        public string Name { get; set; }

//        public Stock Stock { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}
