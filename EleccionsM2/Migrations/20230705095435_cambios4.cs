using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsM2.Migrations
{
    /// <inheritdoc />
    public partial class cambios4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitsPolitics_Municipis_municipiID",
                table: "PartitsPolitics");

            migrationBuilder.RenameColumn(
                name: "municipiID",
                table: "PartitsPolitics",
                newName: "MunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitsPolitics_municipiID",
                table: "PartitsPolitics",
                newName: "IX_PartitsPolitics_MunicipiID");

            migrationBuilder.AlterColumn<long>(
                name: "MunicipiID",
                table: "PartitsPolitics",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_PartitsPolitics_Municipis_MunicipiID",
                table: "PartitsPolitics",
                column: "MunicipiID",
                principalTable: "Municipis",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitsPolitics_Municipis_MunicipiID",
                table: "PartitsPolitics");

            migrationBuilder.RenameColumn(
                name: "MunicipiID",
                table: "PartitsPolitics",
                newName: "municipiID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitsPolitics_MunicipiID",
                table: "PartitsPolitics",
                newName: "IX_PartitsPolitics_municipiID");

            migrationBuilder.AlterColumn<long>(
                name: "municipiID",
                table: "PartitsPolitics",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PartitsPolitics_Municipis_municipiID",
                table: "PartitsPolitics",
                column: "municipiID",
                principalTable: "Municipis",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
