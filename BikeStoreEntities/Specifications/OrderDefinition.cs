using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class OrderDefinition
    {
        public static void Configure(this EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.OrderId);
            builder.HasOne(s => s.Staff).WithOne();
            builder.HasOne(s => s.Store).WithMany(b => b.Orders);
            builder.HasOne(c => c.Customer).WithMany(b => b.Orders);
            //builder.Property(o => o.OrderStatus).HasConversion(
            //    v => v.ToString(),
            //    v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v)
            //    );
        }

    }
}
