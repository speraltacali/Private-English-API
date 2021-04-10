using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Infrastructure.Context.Migrations
{
    public partial class PruebaDeProfesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EmpresaId",
                table: "Usuario",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Cuit",
                table: "Empresa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Empresa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaAlta",
                table: "Empresa",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Galeria",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Imagen = table.Column<byte[]>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmpresaId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galeria_Empresa_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    SubTitulo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmpresaId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Novedades_Empresa_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilHome",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    EmpresaId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilHome", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilHome_Empresa_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EmpresaId",
                table: "Usuario",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Galeria_EmpresaId1",
                table: "Galeria",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_EmpresaId1",
                table: "Novedades",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilHome_EmpresaId1",
                table: "PerfilHome",
                column: "EmpresaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Empresa_EmpresaId",
                table: "Usuario",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Empresa_EmpresaId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Galeria");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "PerfilHome");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_EmpresaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cuit",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "FechaAlta",
                table: "Empresa");
        }
    }
}
