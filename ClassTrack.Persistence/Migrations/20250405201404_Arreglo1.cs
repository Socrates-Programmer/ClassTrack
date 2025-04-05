using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassTrack.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Arreglo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaID",
                table: "Profesores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Profesores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
