using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class CustomerDefinition
    {
        public static void Configure(this EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);
        }

    }
}
