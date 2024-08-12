using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradersChamp.Migrations
{
    /// <inheritdoc />
    public partial class CutomerUpdatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "User",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "User",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "User",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "User",
                newName: "CreatedDate");
        }
    }
}
