using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsM2.Migrations
{
    /// <inheritdoc />
    public partial class estructura1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipis",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomMunicipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroRegidors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ResultatsTaules",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    votsBlanc = table.Column<int>(type: "int", nullable: false),
                    votsNul = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultatsTaules", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartitsPolitics",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomPartit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    municipiID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitsPolitics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartitsPolitics_Municipis_municipiID",
                        column: x => x.municipiID,
                        principalTable: "Municipis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaulesElectorals",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomTaula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    censTaula = table.Column<int>(type: "int", nullable: false),
                    resultatsTaulaID = table.Column<long>(type: "bigint", nullable: false),
                    MunicipiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaulesElectorals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaulesElectorals_Municipis_MunicipiID",
                        column: x => x.MunicipiID,
                        principalTable: "Municipis",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                        column: x => x.resultatsTaulaID,
                        principalTable: "ResultatsTaules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VotsPerLlista",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroVotsLlista = table.Column<int>(type: "int", nullable: false),
                    ResultatsTaulaID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotsPerLlista", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VotsPerLlista_ResultatsTaules_ResultatsTaulaID",
                        column: x => x.ResultatsTaulaID,
                        principalTable: "ResultatsTaules",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Candidat",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomCandidat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartitMunicipiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Candidat_PartitsPolitics_PartitMunicipiID",
                        column: x => x.PartitMunicipiID,
                        principalTable: "PartitsPolitics",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidat_PartitMunicipiID",
                table: "Candidat",
                column: "PartitMunicipiID");

            migrationBuilder.CreateIndex(
                name: "IX_PartitsPolitics_municipiID",
                table: "PartitsPolitics",
                column: "municipiID");

            migrationBuilder.CreateIndex(
                name: "IX_TaulesElectorals_MunicipiID",
                table: "TaulesElectorals",
                column: "MunicipiID");

            migrationBuilder.CreateIndex(
                name: "IX_TaulesElectorals_resultatsTaulaID",
                table: "TaulesElectorals",
                column: "resultatsTaulaID");

            migrationBuilder.CreateIndex(
                name: "IX_VotsPerLlista_ResultatsTaulaID",
                table: "VotsPerLlista",
                column: "ResultatsTaulaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidat");

            migrationBuilder.DropTable(
                name: "TaulesElectorals");

            migrationBuilder.DropTable(
                name: "VotsPerLlista");

            migrationBuilder.DropTable(
                name: "PartitsPolitics");

            migrationBuilder.DropTable(
                name: "ResultatsTaules");

            migrationBuilder.DropTable(
                name: "Municipis");
        }
    }
}
