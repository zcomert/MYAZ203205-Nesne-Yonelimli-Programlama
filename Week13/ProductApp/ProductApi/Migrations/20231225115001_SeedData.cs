using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AtCreatedDate", "ProductId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 25, 11, 50, 1, 16, DateTimeKind.Utc).AddTicks(1976), 1, "Harika bir ürün." },
                    { 2, new DateTime(2023, 12, 25, 11, 50, 1, 16, DateTimeKind.Utc).AddTicks(1979), 1, "Berbat bir ürün." },
                    { 3, new DateTime(2023, 12, 25, 11, 50, 1, 16, DateTimeKind.Utc).AddTicks(1980), 1, "Hızlı kargo, güvenilir satıcı." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 27000m, "HP Laptop" },
                    { 2, 7000m, "Kulaklık" },
                    { 3, 1000m, "Keyboard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
