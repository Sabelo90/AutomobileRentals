using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomobileRentals_EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class columntype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "veh_priceperday",
                table: "Vehicles",
                type: "decimal(19,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "bok_totalprice",
                table: "Bookings",
                type: "decimal(19,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "veh_priceperday",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "bok_totalprice",
                table: "Bookings",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,5)");
        }
    }
}
