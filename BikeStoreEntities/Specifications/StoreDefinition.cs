using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class StoreDefinition
    {
        public static void Configure(this EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(s => s.StoreId);
        }

    }
}
