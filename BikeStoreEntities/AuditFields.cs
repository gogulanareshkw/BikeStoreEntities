using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities
{
    public abstract class AuditFields
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
