using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class completedcoffeeslist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("cd5ba979-52cc-4f73-9eb1-13cb54337605"), "Turkish" },
                    { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), "Basic" }
                });

            migrationBuilder.InsertData(
                table: "CoffeeToIngredient",
                columns: new[] { "CoffeeId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("cd5ba979-52cc-4f73-9eb1-13cb54337605"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 3 },
                    { new Guid("cd5ba979-52cc-4f73-9eb1-13cb54337605"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"), 2 },
                    { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 1 },
                    { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 3 },
                    { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("cd5ba979-52cc-4f73-9eb1-13cb54337605"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("cd5ba979-52cc-4f73-9eb1-13cb54337605"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") });

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("cd5ba979-52cc-4f73-9eb1-13cb54337605"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("f388670c-9f0c-4c3a-a426-51e749197f21"));
        }
    }
}
