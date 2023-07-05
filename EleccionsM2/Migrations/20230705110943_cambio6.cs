using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsM2.Migrations
{
    /// <inheritdoc />
    public partial class cambio6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitsPolitics_PartitMunicipiID",
                table: "Candidat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidat",
                table: "Candidat");

            migrationBuilder.RenameTable(
                name: "Candidat",
                newName: "Candidats");

            migrationBuilder.RenameIndex(
                name: "IX_Candidat_PartitMunicipiID",
                table: "Candidats",
                newName: "IX_Candidats_PartitMunicipiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidats",
                table: "Candidats",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidats_PartitsPolitics_PartitMunicipiID",
                table: "Candidats",
                column: "PartitMunicipiID",
                principalTable: "PartitsPolitics",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidats_PartitsPolitics_PartitMunicipiID",
                table: "Candidats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidats",
                table: "Candidats");

            migrationBuilder.RenameTable(
                name: "Candidats",
                newName: "Candidat");

            migrationBuilder.RenameIndex(
                name: "IX_Candidats_PartitMunicipiID",
                table: "Candidat",
                newName: "IX_Candidat_PartitMunicipiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidat",
                table: "Candidat",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidat_PartitsPolitics_PartitMunicipiID",
                table: "Candidat",
                column: "PartitMunicipiID",
                principalTable: "PartitsPolitics",
                principalColumn: "ID");
        }
    }
}
