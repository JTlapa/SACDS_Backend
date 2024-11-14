using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SACDS.Migrations
{
    /// <inheritdoc />
    public partial class ModificadoCita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiasReposo",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasReposo",
                table: "Citas");
        }
    }
}
