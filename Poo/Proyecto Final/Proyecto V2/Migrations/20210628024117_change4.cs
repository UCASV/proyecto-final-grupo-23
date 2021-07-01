using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_V2.Migrations
{
    public partial class change4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DUI_pacient",
                table: "vaccination",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "DUI_pacient1",
                table: "vaccination",
                column: "DUI_pacient");

            migrationBuilder.AddForeignKey(
                name: "vaccination_ibfk_3",
                table: "vaccination",
                column: "DUI_pacient",
                principalTable: "pacient",
                principalColumn: "DUI",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "vaccination_ibfk_3",
                table: "vaccination");

            migrationBuilder.DropIndex(
                name: "DUI_pacient1",
                table: "vaccination");

            migrationBuilder.DropColumn(
                name: "DUI_pacient",
                table: "vaccination");
        }
    }
}
