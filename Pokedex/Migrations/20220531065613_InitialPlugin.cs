using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class InitialPlugin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokedexEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BatchID = table.Column<Guid>(type: "char(36)", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PokedexEntryNumber = table.Column<int>(type: "int", nullable: false),
                    TimesEncountered = table.Column<int>(type: "int", nullable: false),
                    TimesCaptured = table.Column<int>(type: "int", nullable: false),
                    EvolutionStonePieces = table.Column<int>(type: "int", nullable: false),
                    EvolutionStones = table.Column<int>(type: "int", nullable: false),
                    CapturedShiny = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EncounteredShiny = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TimesLuckyReceived = table.Column<int>(type: "int", nullable: false),
                    TimesPurified = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokedexEntry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokedexEnum",
                columns: table => new
                {
                    EnumValue = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnumName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PokedexEntryId = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId1 = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId2 = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId3 = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId4 = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId5 = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId6 = table.Column<int>(type: "int", nullable: true),
                    PokedexEntryId7 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokedexEnum", x => x.EnumValue);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId",
                        column: x => x.PokedexEntryId,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId1",
                        column: x => x.PokedexEntryId1,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId2",
                        column: x => x.PokedexEntryId2,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId3",
                        column: x => x.PokedexEntryId3,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId4",
                        column: x => x.PokedexEntryId4,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId5",
                        column: x => x.PokedexEntryId5,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId6",
                        column: x => x.PokedexEntryId6,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokedexEnum_PokedexEntry_PokedexEntryId7",
                        column: x => x.PokedexEntryId7,
                        principalTable: "PokedexEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId",
                table: "PokedexEnum",
                column: "PokedexEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId1",
                table: "PokedexEnum",
                column: "PokedexEntryId1");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId2",
                table: "PokedexEnum",
                column: "PokedexEntryId2");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId3",
                table: "PokedexEnum",
                column: "PokedexEntryId3");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId4",
                table: "PokedexEnum",
                column: "PokedexEntryId4");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId5",
                table: "PokedexEnum",
                column: "PokedexEntryId5");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId6",
                table: "PokedexEnum",
                column: "PokedexEntryId6");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexEnum_PokedexEntryId7",
                table: "PokedexEnum",
                column: "PokedexEntryId7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokedexEnum");

            migrationBuilder.DropTable(
                name: "PokedexEntry");
        }
    }
}
