using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradersChamp.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Car",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Car");
        }
    }
}
