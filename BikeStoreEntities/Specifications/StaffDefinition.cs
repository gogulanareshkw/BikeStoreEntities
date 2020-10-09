using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BikeStoreEntities.Specifications
{
    public static class StaffDefinition
    {
        public static void Configure(this EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(s => s.StaffId);
        }

    }
}
