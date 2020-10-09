using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class StockDefinition
    {
        public static void Configure(this EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(s => new { s.StoreId, s.ProductId });
        }
    }
}
