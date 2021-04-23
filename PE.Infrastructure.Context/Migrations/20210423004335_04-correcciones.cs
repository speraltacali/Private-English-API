using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Infrastructure.Context.Migrations
{
    public partial class _04correcciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumno_Usuario_UsuarioId",
                table: "Alumno");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Usuario_UsuarioId",
                table: "Profesor");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Profesor_UsuarioId",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Alumno_UsuarioId",
                table: "Alumno");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Alumno");

            migrationBuilder.AlterColumn<long>(
                name: "PersonaId",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario");

            migrationBuilder.AlterColumn<long>(
                name: "PersonaId",
                table: "Usuario",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "UsuarioId",
                table: "Profesor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UsuarioId",
                table: "Alumno",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_UsuarioId",
                table: "Profesor",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_UsuarioId",
                table: "Alumno",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumno_Usuario_UsuarioId",
                table: "Alumno",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Usuario_UsuarioId",
                table: "Profesor",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Persona_PersonaId",
                table: "Usuario",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
