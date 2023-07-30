using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsM2.Migrations
{
    /// <inheritdoc />
    public partial class changeResultats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "votsTotals",
                table: "ResultatsTaules",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "votsTotals",
                table: "ResultatsTaules");
        }
    }
}
