using Microsoft.EntityFrameworkCore.Migrations;

namespace Domotica_mysql.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iduser",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ApplicationUserId",
                table: "Usuarios",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ApplicationUserId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Iduser",
                table: "Usuarios",
                nullable: true);
        }
    }
}
