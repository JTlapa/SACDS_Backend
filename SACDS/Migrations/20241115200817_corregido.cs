using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SACDS.Migrations
{
    /// <inheritdoc />
    public partial class Corregido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDonacion",
                table: "DonacionUrgentes",
                newName: "IdTipoDonacion");

            migrationBuilder.AddColumn<int>(
                name: "TipoDonacionId",
                table: "DonacionUrgentes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DonacionUrgentes_TipoDonacionId",
                table: "DonacionUrgentes",
                column: "TipoDonacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonacionUrgentes_tipoDonacions_TipoDonacionId",
                table: "DonacionUrgentes",
                column: "TipoDonacionId",
                principalTable: "tipoDonacions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonacionUrgentes_tipoDonacions_TipoDonacionId",
                table: "DonacionUrgentes");

            migrationBuilder.DropIndex(
                name: "IX_DonacionUrgentes_TipoDonacionId",
                table: "DonacionUrgentes");

            migrationBuilder.DropColumn(
                name: "TipoDonacionId",
                table: "DonacionUrgentes");

            migrationBuilder.RenameColumn(
                name: "IdTipoDonacion",
                table: "DonacionUrgentes",
                newName: "TipoDonacion");
        }
    }
}
