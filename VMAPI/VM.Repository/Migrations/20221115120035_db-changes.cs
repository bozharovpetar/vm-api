using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class dbchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"),
                column: "Price",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                columns: new[] { "LeftInStock", "MeasurementUnitId" },
                values: new object[] { 80, new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e") });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                column: "Price",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"),
                columns: new[] { "LeftInStock", "MeasurementUnitId", "Price" },
                values: new object[] { 80, new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), 5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d1379949-4fb2-4fcf-8fa2-b57dbeb7d6f7"),
                column: "LeftInStock",
                value: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") },
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3") },
                column: "Quantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "CoffeeToIngredient",
                keyColumns: new[] { "CoffeeId", "IngredientId" },
                keyValues: new object[] { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3") },
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"),
                column: "Price",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"),
                columns: new[] { "LeftInStock", "MeasurementUnitId" },
                values: new object[] { 2000, new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc") });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b6f56808-1101-48d3-903a-e579263ba726"),
                column: "Price",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"),
                columns: new[] { "LeftInStock", "MeasurementUnitId", "Price" },
                values: new object[] { 2000, new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"), 10 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d1379949-4fb2-4fcf-8fa2-b57dbeb7d6f7"),
                column: "LeftInStock",
                value: 100);
        }
    }
}
