using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetSales.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerInformationToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "InternetSales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "InternetSales",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "PhoneNumber",
                value: 1234567890);

            migrationBuilder.UpdateData(
                table: "InternetSales",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "PhoneNumber",
                value: 1234567890);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "InternetSales");
        }
    }
}
