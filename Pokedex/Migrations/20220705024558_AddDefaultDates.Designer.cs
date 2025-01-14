﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex.Models;

namespace Pokedex.Migrations
{
    [DbContext(typeof(PokedexContext))]
    [Migration("20220705024558_AddDefaultDates")]
    partial class AddDefaultDates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Pokedex.PokedexCategoryEntry", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<bool?>("Acquired")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("Encountered")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("AccountId", "Category");

                    b.ToTable("PokedexCategoryEntry");
                });

            modelBuilder.Entity("Pokedex.PokedexEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("CapturedShiny")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("EncounteredShiny")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("EvolutionStonePieces")
                        .HasColumnType("int");

                    b.Property<int>("EvolutionStones")
                        .HasColumnType("int");

                    b.Property<int>("PokedexId")
                        .HasColumnType("int");

                    b.Property<Guid>("SnapshotId")
                        .HasColumnType("char(36)");

                    b.Property<int>("TimesCaptured")
                        .HasColumnType("int");

                    b.Property<int>("TimesEncountered")
                        .HasColumnType("int");

                    b.Property<int>("TimesLuckyReceived")
                        .HasColumnType("int");

                    b.Property<int>("TimesPurified")
                        .HasColumnType("int");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("PokedexEntry");
                });

            modelBuilder.Entity("Pokedex.PokedexEnum", b =>
                {
                    b.Property<int>("EnumValue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("EnumName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PokedexEntryId")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId1")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId2")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId3")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId4")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId5")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId6")
                        .HasColumnType("int");

                    b.Property<int?>("PokedexEntryId7")
                        .HasColumnType("int");

                    b.HasKey("EnumValue");

                    b.HasIndex("PokedexEntryId");

                    b.HasIndex("PokedexEntryId1");

                    b.HasIndex("PokedexEntryId2");

                    b.HasIndex("PokedexEntryId3");

                    b.HasIndex("PokedexEntryId4");

                    b.HasIndex("PokedexEntryId5");

                    b.HasIndex("PokedexEntryId6");

                    b.HasIndex("PokedexEntryId7");

                    b.ToTable("PokedexEnum");
                });

            modelBuilder.Entity("Pokedex.Snapshot", b =>
                {
                    b.Property<Guid>("SnapshotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("SnapshotId");

                    b.ToTable("Snapshot");
                });

            modelBuilder.Entity("Pokedex.PokedexEnum", b =>
                {
                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("CapturedCostumes")
                        .HasForeignKey("PokedexEntryId");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("CapturedForms")
                        .HasForeignKey("PokedexEntryId1");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("CapturedGenders")
                        .HasForeignKey("PokedexEntryId2");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("CapturedShinyAlignments")
                        .HasForeignKey("PokedexEntryId3");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("CapturedShinyForms")
                        .HasForeignKey("PokedexEntryId4");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("EncounteredCostumes")
                        .HasForeignKey("PokedexEntryId5");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("EncounteredForms")
                        .HasForeignKey("PokedexEntryId6");

                    b.HasOne("Pokedex.PokedexEntry", null)
                        .WithMany("EncounteredGenders")
                        .HasForeignKey("PokedexEntryId7");
                });

            modelBuilder.Entity("Pokedex.PokedexEntry", b =>
                {
                    b.Navigation("CapturedCostumes");

                    b.Navigation("CapturedForms");

                    b.Navigation("CapturedGenders");

                    b.Navigation("CapturedShinyAlignments");

                    b.Navigation("CapturedShinyForms");

                    b.Navigation("EncounteredCostumes");

                    b.Navigation("EncounteredForms");

                    b.Navigation("EncounteredGenders");
                });
#pragma warning restore 612, 618
        }
    }
}
