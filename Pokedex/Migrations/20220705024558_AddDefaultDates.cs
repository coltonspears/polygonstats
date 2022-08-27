using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class AddDefaultDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEnum",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexEnum",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexCategoryEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexCategoryEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.CreateTable(
                name: "Snapshot",
                columns: table => new
                {
                    SnapshotId = table.Column<Guid>(type: "char(36)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(UTC_TIMESTAMP)"),
                    DateUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(UTC_TIMESTAMP)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snapshot", x => x.SnapshotId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snapshot");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PokedexEnum");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "PokedexEnum");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PokedexEntry");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "PokedexEntry");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "PokedexCategoryEntry");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "PokedexCategoryEntry");

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
        }
    }
}
