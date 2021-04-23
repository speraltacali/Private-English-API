using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Infrastructure.Context.Migrations
{
    public partial class _002relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Legajo",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Profesor_Eliminado",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profesor_Legajo",
                table: "Persona",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
