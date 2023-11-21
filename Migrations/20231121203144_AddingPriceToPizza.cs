using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaShop.Migrations
{
    /// <inheritdoc />
    public partial class AddingPriceToPizza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pizza",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Pizza",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 19.99m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pizza");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pizza",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
