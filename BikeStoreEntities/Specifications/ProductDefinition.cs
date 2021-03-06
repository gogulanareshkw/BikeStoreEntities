﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStoreEntities.Specifications
{
    public static class ProductDefinition
    {
        public static void Configure(this EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(b => b.ProductId);
        }
    }
}
