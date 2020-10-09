using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class OrderItemDefinition
    {
        public static void Configure(this EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => o.OrderItemId);
            builder.HasOne(c => c.Order).WithMany(b => b.OrderItems);
        }

    }
}
