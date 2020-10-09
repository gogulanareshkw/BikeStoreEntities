using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStoreEntities.Specifications
{
    public static class BrandDefinition
    {
        public static void Configure(this EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.BrandId);
        }
    }
}
