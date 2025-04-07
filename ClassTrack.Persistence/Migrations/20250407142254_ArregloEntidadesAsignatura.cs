using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassTrack.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ArregloEntidadesAsignatura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquivalenciaAsignaturas_Asignaturas_AsignaturaId",
                table: "EquivalenciaAsignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_IncompatibilidadAsignaturas_Asignaturas_AsignaturaId",
                table: "IncompatibilidadAsignaturas");

            migrationBuilder.DropIndex(
                name: "IX_IncompatibilidadAsignaturas_AsignaturaId",
                table: "IncompatibilidadAsignaturas");

            migrationBuilder.DropIndex(
                name: "IX_EquivalenciaAsignaturas_AsignaturaId",
                table: "EquivalenciaAsignaturas");

            migrationBuilder.DropColumn(
                name: "AsignaturaId",
                table: "IncompatibilidadAsignaturas");

            migrationBuilder.DropColumn(
                name: "AsignaturaId",
                table: "EquivalenciaAsignaturas");

            migrationBuilder.AddColumn<int>(
                name: "EquivalenciaAsignaturaId",
                table: "Asignaturas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IncompatibilidadAsignaturaId",
                table: "Asignaturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_EquivalenciaAsignaturaId",
                table: "Asignaturas",
                column: "EquivalenciaAsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_IncompatibilidadAsignaturaId",
                table: "Asignaturas",
                column: "IncompatibilidadAsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_EquivalenciaAsignaturas_EquivalenciaAsignaturaId",
                table: "Asignaturas",
                column: "EquivalenciaAsignaturaId",
                principalTable: "EquivalenciaAsignaturas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_IncompatibilidadAsignaturas_IncompatibilidadAsignaturaId",
                table: "Asignaturas",
                column: "IncompatibilidadAsignaturaId",
                principalTable: "IncompatibilidadAsignaturas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_EquivalenciaAsignaturas_EquivalenciaAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_IncompatibilidadAsignaturas_IncompatibilidadAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_EquivalenciaAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_IncompatibilidadAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "EquivalenciaAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "IncompatibilidadAsignaturaId",
                table: "Asignaturas");

            migrationBuilder.AddColumn<int>(
                name: "AsignaturaId",
                table: "IncompatibilidadAsignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AsignaturaId",
                table: "EquivalenciaAsignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IncompatibilidadAsignaturas_AsignaturaId",
                table: "IncompatibilidadAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_EquivalenciaAsignaturas_AsignaturaId",
                table: "EquivalenciaAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquivalenciaAsignaturas_Asignaturas_AsignaturaId",
                table: "EquivalenciaAsignaturas",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncompatibilidadAsignaturas_Asignaturas_AsignaturaId",
                table: "IncompatibilidadAsignaturas",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
