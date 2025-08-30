using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeMgtSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_Employee",
                columns: new[] { "Id", "Department", "Email", "HireDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "jane.smith@example.com", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 40000m },
                    { 2, 2, "michael.j@example.com", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Johnson", 50000m },
                    { 3, 3, "emily.davis@example.com", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", 38000m },
                    { 4, 0, "david.wilson@example.com", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Wilson", 60000m },
                    { 5, 1, "sophia.brown@example.com", new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia Brown", 42000m },
                    { 6, 2, "james.taylor@example.com", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Taylor", 55000m },
                    { 7, 3, "olivia.anderson@example.com", new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia Anderson", 47000m },
                    { 8, 0, "daniel.thomas@example.com", new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel Thomas", 52000m },
                    { 9, 2, "ava.martinez@example.com", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ava Martinez", 48000m },
                    { 10, 0, "sohel048@gmail.com", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sohel Shaikh", 45000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tbl_Employee",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
