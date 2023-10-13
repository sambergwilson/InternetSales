using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetSales.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddInternetSalesTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternetSales",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasedInternet = table.Column<bool>(type: "bit", nullable: false),
                    PurchasedPhone = table.Column<bool>(type: "bit", nullable: false),
                    PurchasedCellService = table.Column<bool>(type: "bit", nullable: false),
                    TvService = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetSales", x => x.CustomerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternetSales");
        }
    }
}
