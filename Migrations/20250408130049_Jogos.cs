using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetosJogosAPI.Migrations
{
    /// <inheritdoc />
    public partial class Jogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    jogoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeDoJogo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Plataforma = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.jogoID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    NickName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    JogoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                    table.ForeignKey(
                        name: "FK_Usuario_Jogo_JogoID",
                        column: x => x.JogoID,
                        principalTable: "Jogo",
                        principalColumn: "jogoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_NomeDoJogo",
                table: "Jogo",
                column: "NomeDoJogo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_JogoID",
                table: "Usuario",
                column: "JogoID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_NickName",
                table: "Usuario",
                column: "NickName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}
