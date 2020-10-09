using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class CategoryDefinition
    {
        public static void Configure(this EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
        }

    }
}
