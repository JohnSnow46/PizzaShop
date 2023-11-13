﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaShop.Data;

#nullable disable

namespace PizzaShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231112221836_DescritpionIntToStringAndSeedTheData")]
    partial class DescritpionIntToStringAndSeedTheData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PizzaShop.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pizza Hawajska",
                            Name = "Hawajska"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Pizza Capri",
                            Name = "Capri"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pizza Boczek",
                            Name = "Boczek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
