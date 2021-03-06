﻿// <auto-generated />
using System;
using Example_EF_graphql_asp.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Example_EF_graphql_asp.NET.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Example_EF_graphql_asp.NET.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("62badc05-cedb-4331-83b1-8063697a4008"),
                            Deleted = false,
                            Detail = "something just like this",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("f1f9c1b7-e429-4994-9095-14efbc755602"),
                            Deleted = false,
                            Detail = "something just like this",
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = new Guid("868531bb-4da8-48e7-923a-00063b71f41c"),
                            Deleted = false,
                            Detail = "OMG",
                            Name = "Mike Miles"
                        });
                });

            modelBuilder.Entity("Example_EF_graphql_asp.NET.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Cost")
                        .HasColumnType("bigint");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Example_EF_graphql_asp.NET.Models.Product", b =>
                {
                    b.HasOne("Example_EF_graphql_asp.NET.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
