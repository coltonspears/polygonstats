﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokebox;

#nullable disable

namespace Pokebox.Migrations
{
    [DbContext(typeof(PokeboxContext))]
    [Migration("20230126072420_PokeboxPlugin")]
    partial class PokeboxPlugin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pokebox.Models.PokeboxEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CP")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("(UTC_TIMESTAMP)");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("(UTC_TIMESTAMP)");

                    b.Property<Guid>("ExtractId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("IndividualAttack")
                        .HasColumnType("int");

                    b.Property<int>("IndividualDefense")
                        .HasColumnType("int");

                    b.Property<int>("IndividualStamina")
                        .HasColumnType("int");

                    b.Property<bool>("IsLucky")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsShadow")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsShiny")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MaxStamina")
                        .HasColumnType("int");

                    b.Property<int>("Move1")
                        .HasColumnType("int");

                    b.Property<int>("Move2")
                        .HasColumnType("int");

                    b.Property<int>("Move3")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<ulong>("PokemonUniqueId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("PokeboxEntry");
                });
#pragma warning restore 612, 618
        }
    }
}
