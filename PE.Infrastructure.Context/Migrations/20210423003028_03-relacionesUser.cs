using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Infrastructure.Context.Migrations
{
    public partial class _03relacionesUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Legajo",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Profesor_Eliminado",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Profesor_Legajo",
                table: "Persona");

            migrationBuilder.AlterColumn<long>(
                name: "PersonaId",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInscripcion = table.Column<DateTime>(nullable: false),
                    Legajo = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    PersonaId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumno_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alumno_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Legajo = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    PersonaId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesor_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profesor_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_PersonaId",
                table: "Alumno",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_UsuarioId",
                table: "Alumno",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_PersonaId",
                table: "Profesor",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_UsuarioId",
                table: "Profesor",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.AlterColumn<long>(
                name: "PersonaId",
                table: "Usuario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Persona",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Persona",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Legajo",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Profesor_Eliminado",
                table: "Persona",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profesor_Legajo",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
