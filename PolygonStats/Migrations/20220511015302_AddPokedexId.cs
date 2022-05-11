using Microsoft.EntityFrameworkCore.Migrations;

namespace PolygonStats.Migrations
{
    public partial class AddPokedexId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PokedexId",
                table: "SessionLogEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SessionLogEntry_timestamp",
                table: "SessionLogEntry",
                column: "timestamp");

            migrationBuilder.CreateIndex(
                name: "IX_Session_EndTime",
                table: "Session",
                column: "EndTime");

            migrationBuilder.CreateIndex(
                name: "IX_Session_StartTime",
                table: "Session",
                column: "StartTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SessionLogEntry_timestamp",
                table: "SessionLogEntry");

            migrationBuilder.DropIndex(
                name: "IX_Session_EndTime",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_StartTime",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "PokedexId",
                table: "SessionLogEntry");
        }
    }
}
