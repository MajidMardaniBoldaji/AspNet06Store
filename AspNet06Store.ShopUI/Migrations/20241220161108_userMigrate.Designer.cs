﻿// <auto-generated />
using System;
using AspNet06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNet06Store.ShopUI.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20241220161108_userMigrate")]
    partial class userMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AspNet06Store.ShopUI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AspNet06Store.ShopUI.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("AspNet06Store.ShopUI.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Category = "Iphone",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Apple 16",
                            Price = 100
                        },
                        new
                        {
                            ID = 2,
                            Category = "Samsung",
                            Description = "",
                            Name = "A70",
                            Price = 6000
                        },
                        new
                        {
                            ID = 3,
                            Category = "Iphone",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Iphone 12",
                            Price = 47000
                        },
                        new
                        {
                            ID = 4,
                            Category = "Iphone",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Iphone13",
                            Price = 0
                        },
                        new
                        {
                            ID = 5,
                            Category = "Samsung",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Samsung A20",
                            Price = 43000
                        },
                        new
                        {
                            ID = 6,
                            Category = "Samsung",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Samsung A18",
                            Price = 56000
                        },
                        new
                        {
                            ID = 7,
                            Category = "Iphone",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Iphone11",
                            Price = 340000
                        },
                        new
                        {
                            ID = 8,
                            Category = "Nokia",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Nokia SS2",
                            Price = 34000
                        },
                        new
                        {
                            ID = 9,
                            Category = "Iphone",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Iphone14",
                            Price = 50000
                        },
                        new
                        {
                            ID = 10,
                            Category = "Nokia",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Nokia500",
                            Price = 30000
                        },
                        new
                        {
                            ID = 11,
                            Category = "Samsung",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "SamsungA60",
                            Price = 30000
                        },
                        new
                        {
                            ID = 12,
                            Category = "Apple",
                            Description = "This is the best phone and with good camera with 50px and its very beautiful.",
                            Name = "Apple12",
                            Price = 30000
                        });
                });

            modelBuilder.Entity("AspNet06Store.ShopUI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tell")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AspNet06Store.ShopUI.Models.OrderDetail", b =>
                {
                    b.HasOne("AspNet06Store.ShopUI.Models.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("AspNet06Store.ShopUI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AspNet06Store.ShopUI.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
