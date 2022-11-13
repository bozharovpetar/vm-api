using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class configuredfluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"), "Latte" },
                    { new Guid("0aff55ba-c7e6-4e39-af74-2c8d1d845553"), "Frappe" },
                    { new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"), "Mocha" },
                    { new Guid("212e9c58-4d95-4c64-aeb2-d33dd911737c"), "Iced coffee" },
                    { new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"), "Americano" },
                    { new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"), "Machiato" },
                    { new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"), "Cappuchino" },
                    { new Guid("d2518f75-786c-485c-b671-de67303cb083"), "Black coffee" },
                    { new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"), "Espresso" }
                });

            migrationBuilder.InsertData(
                table: "MeasurementUnits",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"), "Milliliters" },
                    { new Guid("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"), "Cubes" },
                    { new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"), "Packs" },
                    { new Guid("95245bdd-c1bb-4963-87c6-fad7134a0c95"), "Shots" },
                    { new Guid("9dc227e8-7aee-4dc7-93b8-69828c61a4d8"), "Grams" },
                    { new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), "Doses" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "LeftInStock", "MeasurementUnitId", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"), 60, new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"), 5, "Sugar" },
                    { new Guid("75c17127-e3ed-4e42-bf13-27299176a457"), 40, new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e"), 15, "Creamer" },
                    { new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"), 60, new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"), 5, "Brown sugar" },
                    { new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"), 2000, new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"), 10, "Milk" },
                    { new Guid("b6f56808-1101-48d3-903a-e579263ba726"), 60, new Guid("95245bdd-c1bb-4963-87c6-fad7134a0c95"), 15, "Espresso" },
                    { new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"), 2000, new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"), 10, "Water" },
                    { new Guid("d1379949-4fb2-4fcf-8fa2-b57dbeb7d6f7"), 100, new Guid("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"), 5, "Ice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("0321f843-84d0-4006-9d36-47231e6b03b1"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("0aff55ba-c7e6-4e39-af74-2c8d1d845553"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("1c4e70cb-98d1-4719-960b-49c1a8e02322"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("212e9c58-4d95-4c64-aeb2-d33dd911737c"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("525b8dec-871d-47d0-92d1-f2007a07a22a"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("5d0a0127-d40a-4f2b-9b37-ebf9ffdeadf5"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("6c6c8d1e-6f23-4ca0-950a-f0eb8b6e8b14"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("d2518f75-786c-485c-b671-de67303cb083"));

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "Id",
                keyValue: new Guid("e541cc56-f7a4-4682-8da2-4dcd2629a257"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1b564bb8-4d0b-460f-b99b-9a207b96e32e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("75c17127-e3ed-4e42-bf13-27299176a457"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7aa3101b-718e-4a41-9b7a-61777b19a1ae"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b63bf9e8-960e-4509-b05e-a906447f5eb3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b6f56808-1101-48d3-903a-e579263ba726"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cf438737-b6ce-4a63-ba74-a46082f670f3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d1379949-4fb2-4fcf-8fa2-b57dbeb7d6f7"));

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: new Guid("9dc227e8-7aee-4dc7-93b8-69828c61a4d8"));

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: new Guid("4e482d6c-a09a-404a-b8b5-ca76c5d9e7fc"));

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: new Guid("56eacbd4-53ac-447d-8e2f-e8af3fd094c1"));

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: new Guid("596d304e-0e6b-4be1-b541-7869ef6b72fd"));

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: new Guid("95245bdd-c1bb-4963-87c6-fad7134a0c95"));

            migrationBuilder.DeleteData(
                table: "MeasurementUnits",
                keyColumn: "Id",
                keyValue: new Guid("d9c38164-1842-4b4b-a618-7b7e19b72f5e"));
        }
    }
}
