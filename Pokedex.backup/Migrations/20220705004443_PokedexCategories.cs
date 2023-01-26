using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class PokedexCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PokedexEntryNumber",
                table: "PokedexEntry",
                newName: "PokedexId");

            migrationBuilder.RenameColumn(
                name: "BatchID",
                table: "PokedexEntry",
                newName: "SnapshotId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "PokedexCategoryEntry",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Encountered = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Acquired = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokedexCategoryEntry", x => new { x.AccountId, x.Category });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokedexCategoryEntry");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PokedexEntry");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PokedexEntry");

            migrationBuilder.RenameColumn(
                name: "SnapshotId",
                table: "PokedexEntry",
                newName: "BatchID");

            migrationBuilder.RenameColumn(
                name: "PokedexId",
                table: "PokedexEntry",
                newName: "PokedexEntryNumber");
        }
    }
}
