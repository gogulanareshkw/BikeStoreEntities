﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStoreEntities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public int StoreId { get; set; }
        public int? ManagerId { get; set; }
//        public ICollection<Order> Orders { get; set; }
        public Store Store { get; set; }

    }
}
