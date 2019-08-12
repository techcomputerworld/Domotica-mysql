using Microsoft.EntityFrameworkCore.Migrations;

namespace Domotica_mysql.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios");*/

            /*migrationBuilder.DropColumn(
                name: "UsuariosId",
                table: "Usuarios");*/

            /*migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);*/

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Usuarios",
                nullable: true);

            /*migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios");*/

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Usuarios");

            /*migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UsuariosId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_AspNetUsers_ApplicationUserId",
                table: "Usuarios",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);*/
        }
    }
}
