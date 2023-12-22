using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsM2.Migrations
{
    /// <inheritdoc />
    public partial class proba1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.DropIndex(
                name: "IX_TaulesElectorals_resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.DropColumn(
                name: "resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.AddColumn<long>(
                name: "taulaElectoralId",
                table: "ResultatsTaules",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultatsTaules_taulaElectoralId",
                table: "ResultatsTaules",
                column: "taulaElectoralId",
                unique: true,
                filter: "[taulaElectoralId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultatsTaules_TaulesElectorals_taulaElectoralId",
                table: "ResultatsTaules",
                column: "taulaElectoralId",
                principalTable: "TaulesElectorals",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultatsTaules_TaulesElectorals_taulaElectoralId",
                table: "ResultatsTaules");

            migrationBuilder.DropIndex(
                name: "IX_ResultatsTaules_taulaElectoralId",
                table: "ResultatsTaules");

            migrationBuilder.DropColumn(
                name: "taulaElectoralId",
                table: "ResultatsTaules");

            migrationBuilder.AddColumn<long>(
                name: "resultatsTaulaID",
                table: "TaulesElectorals",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaulesElectorals_resultatsTaulaID",
                table: "TaulesElectorals",
                column: "resultatsTaulaID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals",
                column: "resultatsTaulaID",
                principalTable: "ResultatsTaules",
                principalColumn: "ID");
        }
    }
}
