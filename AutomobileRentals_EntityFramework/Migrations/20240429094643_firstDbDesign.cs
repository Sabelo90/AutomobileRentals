using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomobileRentals_EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class firstDbDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    per_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    per_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    per_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    per_passwordhash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    per_idno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.per_id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    veh_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    veh_brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    veh_model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    veh_year = table.Column<int>(type: "int", nullable: false),
                    veh_priceperday = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    is_available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vehicle", x => x.veh_id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bok_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bok_ref_person = table.Column<int>(type: "int", nullable: false),
                    bok_ref_vehicle = table.Column<int>(type: "int", nullable: false),
                    bok_startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bok_enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bok_totalprice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    bok_isconfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_booking", x => x.bok_id);
                    table.ForeignKey(
                        name: "FK_Bookings_People_bok_ref_person",
                        column: x => x.bok_ref_person,
                        principalTable: "People",
                        principalColumn: "per_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Vehicles_bok_ref_vehicle",
                        column: x => x.bok_ref_vehicle,
                        principalTable: "Vehicles",
                        principalColumn: "veh_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_bok_ref_person",
                table: "Bookings",
                column: "bok_ref_person");

            migrationBuilder.CreateIndex(
                name: "ix_bok_ref_vehicle",
                table: "Bookings",
                column: "bok_ref_vehicle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
