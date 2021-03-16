using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherLogger.Data.Migrations
{
    public partial class add_measure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MeasuredAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Temperature = table.Column<decimal>(type: "TEXT", nullable: false),
                    Humidity = table.Column<decimal>(type: "TEXT", nullable: false),
                    WindSpeed = table.Column<decimal>(type: "TEXT", nullable: false),
                    WindDirection = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measures");
        }
    }
}
