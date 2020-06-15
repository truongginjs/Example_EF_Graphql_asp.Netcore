using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Example_EF_graphql_asp.NET.Models;
using Example_EF_graphql_asp.NET.Data.Configuration;

namespace Example_EF_graphql_asp.NET.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }


        public DbSet<Example_EF_graphql_asp.NET.Models.Category> Category { get; set; }

        public DbSet<Example_EF_graphql_asp.NET.Models.Product> Product { get; set; }
    }
}
