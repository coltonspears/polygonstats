using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class AddPokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Snapshot",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Snapshot",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexEnum",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEnum",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexCategoryEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexCategoryEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "(UTC_TIMESTAMP)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokedexId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PokemonName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DefaultFormId = table.Column<long>(type: "bigint", nullable: true),
                    GenId = table.Column<long>(type: "bigint", nullable: true),
                    Attack = table.Column<long>(type: "bigint", nullable: true),
                    Defense = table.Column<long>(type: "bigint", nullable: true),
                    Stamina = table.Column<long>(type: "bigint", nullable: true),
                    Height = table.Column<double>(type: "double", nullable: true),
                    Weight = table.Column<double>(type: "double", nullable: true),
                    Family = table.Column<long>(type: "bigint", nullable: true),
                    FleeRate = table.Column<double>(type: "double", nullable: true),
                    CaptureRate = table.Column<double>(type: "double", nullable: true),
                    Legendary = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Mythic = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    UltraBeast = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    BuddyGroupNumber = table.Column<long>(type: "bigint", nullable: true),
                    BuddyDistance = table.Column<long>(type: "bigint", nullable: true),
                    BuddyMegaEnergy = table.Column<long>(type: "bigint", nullable: true),
                    ThirdMoveStardust = table.Column<long>(type: "bigint", nullable: true),
                    ThirdMoveCandy = table.Column<long>(type: "bigint", nullable: true),
                    GymDefenderEligible = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Tradable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Transferable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Little = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    BonusCandyCapture = table.Column<long>(type: "bigint", nullable: true),
                    BonusStardustCapture = table.Column<long>(type: "bigint", nullable: true),
                    Unreleased = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(UTC_TIMESTAMP)"),
                    DateUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(UTC_TIMESTAMP)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokedexId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Snapshot",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Snapshot",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexEnum",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEnum",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PokedexCategoryEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PokedexCategoryEntry",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "(UTC_TIMESTAMP)");
        }
    }
}
