using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsM2.Migrations
{
    /// <inheritdoc />
    public partial class canvivots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.AddColumn<long>(
                name: "PartitID",
                table: "VotsPerLlista",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "resultatsTaulaID",
                table: "TaulesElectorals",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_VotsPerLlista_PartitID",
                table: "VotsPerLlista",
                column: "PartitID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals",
                column: "resultatsTaulaID",
                principalTable: "ResultatsTaules",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VotsPerLlista_PartitsPolitics_PartitID",
                table: "VotsPerLlista",
                column: "PartitID",
                principalTable: "PartitsPolitics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.DropForeignKey(
                name: "FK_VotsPerLlista_PartitsPolitics_PartitID",
                table: "VotsPerLlista");

            migrationBuilder.DropIndex(
                name: "IX_VotsPerLlista_PartitID",
                table: "VotsPerLlista");

            migrationBuilder.DropColumn(
                name: "PartitID",
                table: "VotsPerLlista");

            migrationBuilder.AlterColumn<long>(
                name: "resultatsTaulaID",
                table: "TaulesElectorals",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals",
                column: "resultatsTaulaID",
                principalTable: "ResultatsTaules",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
