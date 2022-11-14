﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VM.Repository;

#nullable disable

namespace VM.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VM.Domain.Models.Coffee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coffees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"),
                            Title = "Machiato"
                        },
                        new
                        {
                            Id = new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"),
                            Title = "Espresso"
                        },
                        new
                        {
                            Id = new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"),
                            Title = "Americano"
                        },
                        new
                        {
                            Id = new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"),
                            Title = "Latte"
                        },
                        new
                        {
                            Id = new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"),
                            Title = "Cappuchino"
                        },
                        new
                        {
                            Id = new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"),
                            Title = "Mocha"
                        });
                });

            modelBuilder.Entity("VM.Domain.Models.CoffeeToIngredient", b =>
                {
                    b.Property<Guid>("CoffeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CoffeeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("CoffeeToIngredient");

                    b.HasData(
                        new
                        {
                            CoffeeId = new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"),
                            IngredientId = new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                            Quantity = 50
                        },
                        new
                        {
                            CoffeeId = new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"),
                            IngredientId = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            Quantity = 1
                        },
                        new
                        {
                            CoffeeId = new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"),
                            IngredientId = new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"),
                            IngredientId = new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"),
                            Quantity = 10
                        },
                        new
                        {
                            CoffeeId = new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"),
                            IngredientId = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            Quantity = 1
                        },
                        new
                        {
                            CoffeeId = new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"),
                            IngredientId = new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"),
                            IngredientId = new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"),
                            Quantity = 50
                        },
                        new
                        {
                            CoffeeId = new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"),
                            IngredientId = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"),
                            IngredientId = new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"),
                            IngredientId = new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                            Quantity = 50
                        },
                        new
                        {
                            CoffeeId = new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"),
                            IngredientId = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            Quantity = 1
                        },
                        new
                        {
                            CoffeeId = new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"),
                            IngredientId = new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"),
                            IngredientId = new Guid("75c17127-e3ed-4e42-bf13-27299176a457"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"),
                            IngredientId = new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                            Quantity = 50
                        },
                        new
                        {
                            CoffeeId = new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"),
                            IngredientId = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"),
                            IngredientId = new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                            Quantity = 3
                        },
                        new
                        {
                            CoffeeId = new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"),
                            IngredientId = new Guid("75c17127-e3ed-4e42-bf13-27299176a457"),
                            Quantity = 3
                        },
                        new
                        {
                            CoffeeId = new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"),
                            IngredientId = new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                            Quantity = 50
                        },
                        new
                        {
                            CoffeeId = new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"),
                            IngredientId = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            Quantity = 2
                        },
                        new
                        {
                            CoffeeId = new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"),
                            IngredientId = new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"),
                            Quantity = 3
                        },
                        new
                        {
                            CoffeeId = new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"),
                            IngredientId = new Guid("75c17127-e3ed-4e42-bf13-27299176a457"),
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("VM.Domain.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LeftInStock")
                        .HasColumnType("int");

                    b.Property<Guid>("MeasurementUnitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MeasurementUnitId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                            LeftInStock = 2000,
                            MeasurementUnitId = new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"),
                            Price = 10,
                            Title = "Milk"
                        },
                        new
                        {
                            Id = new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"),
                            LeftInStock = 60,
                            MeasurementUnitId = new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"),
                            Price = 5,
                            Title = "Sugar"
                        },
                        new
                        {
                            Id = new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"),
                            LeftInStock = 2000,
                            MeasurementUnitId = new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"),
                            Price = 10,
                            Title = "Water"
                        },
                        new
                        {
                            Id = new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                            LeftInStock = 60,
                            MeasurementUnitId = new Guid("95245bdd-c1bb-4963-87c6-fad7134a0c95"),
                            Price = 15,
                            Title = "Espresso"
                        },
                        new
                        {
                            Id = new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"),
                            LeftInStock = 60,
                            MeasurementUnitId = new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"),
                            Price = 5,
                            Title = "Brown sugar"
                        },
                        new
                        {
                            Id = new Guid("75c17127-e3ed-4e42-bf13-27299176a457"),
                            LeftInStock = 40,
                            MeasurementUnitId = new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e"),
                            Price = 15,
                            Title = "Creamer"
                        },
                        new
                        {
                            Id = new Guid("d1379949-4fb2-4fcf-8fa2-b57dbeb7d6f7"),
                            LeftInStock = 100,
                            MeasurementUnitId = new Guid("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"),
                            Price = 5,
                            Title = "Ice"
                        });
                });

            modelBuilder.Entity("VM.Domain.Models.MeasurementUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeasurementUnits");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9dc227e8-7aee-4dc7-93b8-69828c61a4d8"),
                            Title = "Grams"
                        },
                        new
                        {
                            Id = new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"),
                            Title = "Milliliters"
                        },
                        new
                        {
                            Id = new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"),
                            Title = "Packs"
                        },
                        new
                        {
                            Id = new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e"),
                            Title = "Doses"
                        },
                        new
                        {
                            Id = new Guid("95245bdd-c1bb-4963-87c6-fad7134a0c95"),
                            Title = "Shots"
                        },
                        new
                        {
                            Id = new Guid("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"),
                            Title = "Cubes"
                        });
                });

            modelBuilder.Entity("VM.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CoffeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoffeeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("VM.Domain.Models.OrderToIngredient", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("OrderToIngredient");
                });

            modelBuilder.Entity("VM.Domain.Models.CoffeeToIngredient", b =>
                {
                    b.HasOne("VM.Domain.Models.Coffee", "Coffee")
                        .WithMany("Ingredients")
                        .HasForeignKey("CoffeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VM.Domain.Models.Ingredient", "Ingredient")
                        .WithMany("Coffees")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coffee");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("VM.Domain.Models.Ingredient", b =>
                {
                    b.HasOne("VM.Domain.Models.MeasurementUnit", "MeasurementUnit")
                        .WithMany("Ingredients")
                        .HasForeignKey("MeasurementUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeasurementUnit");
                });

            modelBuilder.Entity("VM.Domain.Models.Order", b =>
                {
                    b.HasOne("VM.Domain.Models.Coffee", "Coffee")
                        .WithMany("Orders")
                        .HasForeignKey("CoffeeId");

                    b.Navigation("Coffee");
                });

            modelBuilder.Entity("VM.Domain.Models.OrderToIngredient", b =>
                {
                    b.HasOne("VM.Domain.Models.Ingredient", "Ingredient")
                        .WithMany("Orders")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VM.Domain.Models.Order", "Order")
                        .WithMany("Ingredients")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("VM.Domain.Models.Coffee", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("VM.Domain.Models.Ingredient", b =>
                {
                    b.Navigation("Coffees");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("VM.Domain.Models.MeasurementUnit", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("VM.Domain.Models.Order", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
