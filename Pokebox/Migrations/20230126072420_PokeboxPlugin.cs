using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokebox.Migrations
{
    /// <inheritdoc />
    public partial class PokeboxPlugin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PokeboxEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExtractId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PokemonUniqueId = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                    PokemonId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CP = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    MaxStamina = table.Column<int>(type: "int", nullable: false),
                    Move1 = table.Column<int>(type: "int", nullable: false),
                    Move2 = table.Column<int>(type: "int", nullable: false),
                    Move3 = table.Column<int>(type: "int", nullable: false),
                    IndividualAttack = table.Column<int>(type: "int", nullable: false),
                    IndividualDefense = table.Column<int>(type: "int", nullable: false),
                    IndividualStamina = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsShiny = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsLucky = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsShadow = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(UTC_TIMESTAMP)"),
                    DateUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "(UTC_TIMESTAMP)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeboxEntry", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokeboxEntry");
        }
    }
}
