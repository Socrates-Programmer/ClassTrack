using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassTrack.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CambioRelacion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaConocimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaConocimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titulaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titulaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Curso = table.Column<int>(type: "int", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditosTeoricos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditosPracticos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LibreConfiguracion = table.Column<bool>(type: "bit", nullable: false),
                    LimiteAdmision = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    AreaConocimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_AreaConocimientos_AreaConocimientoId",
                        column: x => x.AreaConocimientoId,
                        principalTable: "AreaConocimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaConocimientosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamentos_AreaConocimientos_AreaConocimientosId",
                        column: x => x.AreaConocimientosId,
                        principalTable: "AreaConocimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Despacho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false),
                    AreaConocimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesores_AreaConocimientos_AreaConocimientoId",
                        column: x => x.AreaConocimientoId,
                        principalTable: "AreaConocimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquivalenciaAsignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignaturaID1 = table.Column<int>(type: "int", nullable: false),
                    AsignaturaID2 = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquivalenciaAsignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquivalenciaAsignaturas_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignaturaID = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupos_Asignaturas_AsignaturaID",
                        column: x => x.AsignaturaID,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncompatibilidadAsignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignaturaID1 = table.Column<int>(type: "int", nullable: false),
                    AsignaturaID2 = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncompatibilidadAsignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncompatibilidadAsignaturas_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Docencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfesorID = table.Column<int>(type: "int", nullable: false),
                    AsignaturaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docencias_Asignaturas_AsignaturaID",
                        column: x => x.AsignaturaID,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Docencias_Profesores_ProfesorID",
                        column: x => x.ProfesorID,
                        principalTable: "Profesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HorarioConsultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfesorID = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraFin = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioConsultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorarioConsultas_Profesores_ProfesorID",
                        column: x => x.ProfesorID,
                        principalTable: "Profesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_AreaConocimientoId",
                table: "Asignaturas",
                column: "AreaConocimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_AreaConocimientosId",
                table: "Departamentos",
                column: "AreaConocimientosId");

            migrationBuilder.CreateIndex(
                name: "IX_Docencias_AsignaturaID",
                table: "Docencias",
                column: "AsignaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Docencias_ProfesorID",
                table: "Docencias",
                column: "ProfesorID");

            migrationBuilder.CreateIndex(
                name: "IX_EquivalenciaAsignaturas_AsignaturaId",
                table: "EquivalenciaAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_AsignaturaID",
                table: "Grupos",
                column: "AsignaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioConsultas_ProfesorID",
                table: "HorarioConsultas",
                column: "ProfesorID");

            migrationBuilder.CreateIndex(
                name: "IX_IncompatibilidadAsignaturas_AsignaturaId",
                table: "IncompatibilidadAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_AreaConocimientoId",
                table: "Profesores",
                column: "AreaConocimientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Docencias");

            migrationBuilder.DropTable(
                name: "EquivalenciaAsignaturas");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "HorarioConsultas");

            migrationBuilder.DropTable(
                name: "IncompatibilidadAsignaturas");

            migrationBuilder.DropTable(
                name: "Titulaciones");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "AreaConocimientos");
        }
    }
}
