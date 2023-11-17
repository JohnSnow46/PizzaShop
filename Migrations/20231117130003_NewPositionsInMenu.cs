using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaShop.Migrations
{
    /// <inheritdoc />
    public partial class NewPositionsInMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizza",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 4, "Pizza margarita", "Margarita" },
                    { 5, "Pizza Cztery Sery", "Cztery Sery" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
