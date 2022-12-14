using Microsoft.EntityFrameworkCore;
using VM.Domain.Models;

namespace VM.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CoffeeToIngredient>().HasKey(x => new { x.CoffeeId, x.IngredientId });
            builder.Entity<OrderToIngredient>().HasKey(x => new { x.OrderId, x.IngredientId });

            #region Configuring fluentAPI relationships
            builder.Entity<Ingredient>().HasOne(x => x.MeasurementUnit).WithMany(x => x.Ingredients).HasForeignKey(x => x.MeasurementUnitId);
            builder.Entity<Order>().HasOne(x => x.Coffee).WithMany(x => x.Orders).HasForeignKey(x => x.CoffeeId);

            builder.Entity<CoffeeToIngredient>().HasOne(x => x.Coffee).WithMany(x => x.Ingredients).HasForeignKey(x => x.CoffeeId);
            builder.Entity<CoffeeToIngredient>().HasOne(x => x.Ingredient).WithMany(x => x.Coffees).HasForeignKey(x => x.IngredientId);

            builder.Entity<OrderToIngredient>().HasOne(x => x.Order).WithMany(x => x.Ingredients).HasForeignKey(x => x.OrderId);
            builder.Entity<OrderToIngredient>().HasOne(x => x.Ingredient).WithMany(x => x.Orders).HasForeignKey(x => x.IngredientId);
            #endregion

            #region Seeding coffees
            builder.Entity<Coffee>().HasData(
                new Coffee { Id = Guid.Parse("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), Title = "Machiato" },
                new Coffee { Id = Guid.Parse("e541cc56-f7a4-4682-8da2-4dcd2629a257"), Title = "Espresso" },
                new Coffee { Id = Guid.Parse("525b8dec-871d-47d0-92d1-f2007a07a22a"), Title = "Americano" },
                new Coffee { Id = Guid.Parse("0321f843-84d0-4006-9d36-47231e6b03b1"), Title = "Latte" },
                new Coffee { Id = Guid.Parse("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), Title = "Cappuchino" },
                new Coffee { Id = Guid.Parse("1c4e70cb-98d1-4719-960b-49c1a8e02322"), Title = "Mocha" },
                new Coffee { Id = Guid.Parse("cd5ba979-52cc-4f73-9eb1-13cb54337605"), Title = "Turkish" },
                new Coffee { Id = Guid.Parse("f388670c-9f0c-4c3a-a426-51e749197f21"), Title = "Basic" }
            );
            #endregion

            #region Seeding measurement units
            builder.Entity<MeasurementUnit>().HasData(
                new MeasurementUnit { Id = Guid.Parse("9dc227e8-7aee-4dc7-93b8-69828c61a4d8"), Title = "Grams" },
                new MeasurementUnit { Id = Guid.Parse("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"), Title = "Milliliters" },
                new MeasurementUnit { Id = Guid.Parse("596d304e-0e6b-4be1-b541-7869ef6b72fd"), Title = "Packs" },
                new MeasurementUnit { Id = Guid.Parse("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), Title = "Doses" },
                new MeasurementUnit { Id = Guid.Parse("95245bdd-c1bb-4963-87c6-fad7134a0c95"), Title = "Shots" },
                new MeasurementUnit { Id = Guid.Parse("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"), Title = "Cubes" }
            );
            #endregion

            #region Seeding ingredients
            builder.Entity<Ingredient>().HasData(
                new Ingredient { Id = Guid.Parse("b63bf9e8-960e-4509-b05e-a906447f5eb3"), LeftInStock = 80, Title = "Milk", MeasurementUnitId = Guid.Parse("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), Price = 10 },
                new Ingredient { Id = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), LeftInStock = 60, Title = "Sugar", MeasurementUnitId = Guid.Parse("596d304e-0e6b-4be1-b541-7869ef6b72fd"), Price = 5 },
                new Ingredient { Id = Guid.Parse("cf438737-b6ce-4a63-ba74-a46082f670f3"), LeftInStock = 80, Title = "Water", MeasurementUnitId = Guid.Parse("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), Price = 5 },
                new Ingredient { Id = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), LeftInStock = 60, Title = "Espresso", MeasurementUnitId = Guid.Parse("95245bdd-c1bb-4963-87c6-fad7134a0c95"), Price = 5 },
                new Ingredient { Id = Guid.Parse("7aa3101b-718e-4a41-9b7a-61777b19a1ae"), LeftInStock = 60, Title = "Brown sugar", MeasurementUnitId = Guid.Parse("596d304e-0e6b-4be1-b541-7869ef6b72fd"), Price = 10 },
                new Ingredient { Id = Guid.Parse("75c17127-e3ed-4e42-bf13-27299176a457"), LeftInStock = 40, Title = "Creamer", MeasurementUnitId = Guid.Parse("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), Price = 15 },
                new Ingredient { Id = Guid.Parse("d1379949-4fb2-4fcf-8fa2-b57dbeb7d6f7"), LeftInStock = 50, Title = "Ice", MeasurementUnitId = Guid.Parse("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"), Price = 5 }
            );
            #endregion

            #region Seeding CoffeeToIngredients
            builder.Entity<CoffeeToIngredient>().HasData(
                  // Machiato
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), IngredientId = Guid.Parse("b63bf9e8-960e-4509-b05e-a906447f5eb3"), Quantity = 5 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 1 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 2 },
                  // Espresso
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("e541cc56-f7a4-4682-8da2-4dcd2629a257"), IngredientId = Guid.Parse("cf438737-b6ce-4a63-ba74-a46082f670f3"), Quantity = 5 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("e541cc56-f7a4-4682-8da2-4dcd2629a257"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 1 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("e541cc56-f7a4-4682-8da2-4dcd2629a257"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 2 },
                  // Americano
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("525b8dec-871d-47d0-92d1-f2007a07a22a"), IngredientId = Guid.Parse("cf438737-b6ce-4a63-ba74-a46082f670f3"), Quantity = 5 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("525b8dec-871d-47d0-92d1-f2007a07a22a"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 2 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("525b8dec-871d-47d0-92d1-f2007a07a22a"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 2 },
                  // Latte
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("0321f843-84d0-4006-9d36-47231e6b03b1"), IngredientId = Guid.Parse("b63bf9e8-960e-4509-b05e-a906447f5eb3"), Quantity = 5 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("0321f843-84d0-4006-9d36-47231e6b03b1"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 1 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("0321f843-84d0-4006-9d36-47231e6b03b1"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 2 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("0321f843-84d0-4006-9d36-47231e6b03b1"), IngredientId = Guid.Parse("75c17127-e3ed-4e42-bf13-27299176a457"), Quantity = 2 },
                  // Cappuchino
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), IngredientId = Guid.Parse("b63bf9e8-960e-4509-b05e-a906447f5eb3"), Quantity = 5 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 2 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 3 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), IngredientId = Guid.Parse("75c17127-e3ed-4e42-bf13-27299176a457"), Quantity = 3 },
                  // Mocha
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("1c4e70cb-98d1-4719-960b-49c1a8e02322"), IngredientId = Guid.Parse("b63bf9e8-960e-4509-b05e-a906447f5eb3"), Quantity = 5 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("1c4e70cb-98d1-4719-960b-49c1a8e02322"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 2 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("1c4e70cb-98d1-4719-960b-49c1a8e02322"), IngredientId = Guid.Parse("7aa3101b-718e-4a41-9b7a-61777b19a1ae"), Quantity = 3 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("1c4e70cb-98d1-4719-960b-49c1a8e02322"), IngredientId = Guid.Parse("75c17127-e3ed-4e42-bf13-27299176a457"), Quantity = 3 },
                  // Turkish
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("cd5ba979-52cc-4f73-9eb1-13cb54337605"), IngredientId = Guid.Parse("cf438737-b6ce-4a63-ba74-a46082f670f3"), Quantity = 2 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("cd5ba979-52cc-4f73-9eb1-13cb54337605"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 3 },
                  // Basic
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("f388670c-9f0c-4c3a-a426-51e749197f21"), IngredientId = Guid.Parse("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), Quantity = 1 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("f388670c-9f0c-4c3a-a426-51e749197f21"), IngredientId = Guid.Parse("cf438737-b6ce-4a63-ba74-a46082f670f3"), Quantity = 2 },
                  new CoffeeToIngredient { CoffeeId = Guid.Parse("f388670c-9f0c-4c3a-a426-51e749197f21"), IngredientId = Guid.Parse("b6f56808-1101-48d3-903a-e579263ba726"), Quantity = 3 }
            );
            #endregion
        }

        public virtual DbSet<Coffee> Coffees { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public virtual DbSet<CoffeeToIngredient> CoffeeToIngredient { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderToIngredient> OrderToIngredient { get; set; }


    }
}
