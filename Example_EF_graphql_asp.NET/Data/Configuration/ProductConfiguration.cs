using Example_EF_graphql_asp.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id=Guid.NewGuid(),
                    Name= "quan",
                    Detail= "test1",
                    Category=new Category { Id = Guid.NewGuid(),Name="test1",Detail="test1" }
                }
                );
        }
    }
}
