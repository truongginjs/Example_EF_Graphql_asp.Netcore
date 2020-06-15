using Example_EF_graphql_asp.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Data.Configuration
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasData
            (
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Detail = "something just like this"

                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Doe",
                    Detail = "something just like this"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Mike Miles",
                    Detail = "OMG"
                }
            );
        }
    }
}
