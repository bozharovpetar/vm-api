using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class seedv20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("0aff55ba-c7e6-4e39-af74-2c8d1d845553"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("212e9c58-4d95-4c64-aeb2-d33dd911737c"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("d2518f75-786c-485c-b671-de67303cb083"));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderToIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "CoffeeToIngredient",
                columns: new[] { "CoffeeId", "IngredientId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 1 },
                    { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("75c17127-e3ed-4e42-bf13-27299176a457"), 2 },
                    { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"), 50 },
                    { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 2 },
                    { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 2 },
                    { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("75c17127-e3ed-4e42-bf13-27299176a457"), 3 },
                    { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"), 3 },
                    { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"), 50 },
                    { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 2 },
                    { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 2 },
                    { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"), 50 },
                    { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 1 },
                    { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"), 50 },
                    { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 2 },
                    { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 2 },
                    { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("75c17127-e3ed-4e42-bf13-27299176a457"), 3 },
                    { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"), 50 },
                    { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 3 },
                    { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 1 },
                    { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 2 },
                    { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"), 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("75c17127-e3ed-4e42-bf13-27299176a457") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("75c17127-e3ed-4e42-bf13-27299176a457") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("75c17127-e3ed-4e42-bf13-27299176a457") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("b6f56808-1101-48d3-903a-e579263ba726") });

            migrationBuilder.DeleteData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") });

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderToIngredient");

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0aff55ba-c7e6-4e39-af74-2c8d1d845553"), "Frappe" },
                    { new Guid("212e9c58-4d95-4c64-aeb2-d33dd911737c"), "Iced coffee" },
                    { new Guid("d2518f75-786c-485c-b671-de67303cb083"), "Black coffee" }
                });
        }
    }
}
