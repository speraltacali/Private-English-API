using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Infrastructure.Context.Migrations
{
    public partial class asignandoProfesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProfesorId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true),
                    Cuil = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    EMail = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ProfesorId",
                table: "Usuario",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Profesor_ProfesorId",
                table: "Usuario",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Profesor_ProfesorId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ProfesorId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Usuario");
        }
    }
}
