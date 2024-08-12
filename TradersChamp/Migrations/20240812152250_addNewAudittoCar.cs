using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradersChamp.Migrations
{
    /// <inheritdoc />
    public partial class addNewAudittoCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Car",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Car",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Car");
        }
    }
}
