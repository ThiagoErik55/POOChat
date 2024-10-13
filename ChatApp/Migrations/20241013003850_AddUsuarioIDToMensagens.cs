using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuarioIDToMensagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Mensagens",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuarioID",
                table: "Mensagens",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioID",
                table: "Mensagens",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensagens_Usuarios_UsuarioID",
                table: "Mensagens");

            migrationBuilder.DropIndex(
                name: "IX_Mensagens_UsuarioID",
                table: "Mensagens");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Mensagens");
        }
    }
}
