using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreEntityFrameworkCore.Persistence
{
    public static class DemoDbConfiguration
    {
        public static EntityTypeBuilder<CustomerEntity> Configure(this EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(customer => customer.Id);

            builder.Property(customer => customer.Id)
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(customer => customer.Name)
                   .IsRequired();

            return builder;
        }
    }
}
