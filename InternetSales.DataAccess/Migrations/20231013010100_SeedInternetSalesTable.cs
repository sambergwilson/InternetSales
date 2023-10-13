using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InternetSales.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedInternetSalesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InternetSales",
                columns: new[] { "CustomerId", "BusinessAddress", "BusinessName", "BusinessOwner", "PurchasedCellService", "PurchasedInternet", "PurchasedPhone", "TvService" },
                values: new object[,]
                {
                    { 1, "123 Happy Street", "Alltel", "John Doe", false, false, false, false },
                    { 2, "123 Other Street", "360 Communications", "John Wilson", true, true, true, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InternetSales",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InternetSales",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
