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
    [Migration("20231121203144_AddingPriceToPizza")]
    partial class AddingPriceToPizza
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
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pizza Hawajska",
                            Name = "Hawajska",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Pizza Capri",
                            Name = "Capri",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pizza Boczek",
                            Name = "Boczek",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Pizza margarita",
                            Name = "Margarita",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Pizza Cztery Sery",
                            Name = "Cztery Sery",
                            Price = 19.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
