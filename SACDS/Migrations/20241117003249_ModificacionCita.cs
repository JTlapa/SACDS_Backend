using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SACDS.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionCita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Atendida",
                table: "Citas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atendida",
                table: "Citas");
        }
    }
}
