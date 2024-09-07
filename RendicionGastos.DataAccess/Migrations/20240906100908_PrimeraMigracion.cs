using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RendicionGastos.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentroCosto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EliminadoBD = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioActualizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroCosto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Concepto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EliminadoBD = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioActualizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concepto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroDNI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    FechaIngreso = table.Column<DateOnly>(type: "date", nullable: false),
                    EliminadoBD = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioActualizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rendicion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    FechaRendicion = table.Column<DateOnly>(type: "date", nullable: false),
                    Glosa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MontoAsignado = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    EliminadoBD = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioActualizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rendicion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rendicion_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RendicionDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RendicionId = table.Column<int>(type: "int", nullable: false),
                    FechaDocumento = table.Column<DateOnly>(type: "date", nullable: false),
                    TipoDoc = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConceptoId = table.Column<int>(type: "int", nullable: false),
                    GlosaDetalle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    EliminadoBD = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioActualizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendicionDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RendicionDetalle_Concepto_ConceptoId",
                        column: x => x.ConceptoId,
                        principalTable: "Concepto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RendicionDetalle_Rendicion_RendicionId",
                        column: x => x.RendicionId,
                        principalTable: "Rendicion",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CentroCosto",
                columns: new[] { "Id", "Descripcion", "EliminadoBD", "FechaActualizacion", "FechaCreacion", "UsuarioActualizacion", "UsuarioCreacion" },
                values: new object[,]
                {
                    { 1, "Produccion", false, null, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin" },
                    { 2, "Administracion", false, null, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin" },
                    { 3, "Ventas", false, null, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin" },
                    { 4, "Finanzas", false, null, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_NroDNI",
                table: "Empleado",
                column: "NroDNI");

            migrationBuilder.CreateIndex(
                name: "IX_Rendicion_EmpleadoId",
                table: "Rendicion",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_RendicionDetalle_ConceptoId",
                table: "RendicionDetalle",
                column: "ConceptoId");

            migrationBuilder.CreateIndex(
                name: "IX_RendicionDetalle_RendicionId",
                table: "RendicionDetalle",
                column: "RendicionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CentroCosto");

            migrationBuilder.DropTable(
                name: "RendicionDetalle");

            migrationBuilder.DropTable(
                name: "Concepto");

            migrationBuilder.DropTable(
                name: "Rendicion");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
