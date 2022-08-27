using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Models
{

    public class PokedexContext : DbContext
    {

        public PokedexContext()
        {
        }

        public DbSet<PokedexEntry> PokedexEntries { get; set; }
        public DbSet<PokedexCategoryEntry> PokedexCategoryEntry { get; set; }
        public DbSet<Snapshot> Snapshot { get; set; }
        public DbSet<PolygonStats.Plugins.Data.Pokemon> Pokemon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnectionString = "server=localhost; port=3306; database=pplugin; user=poly; password=polygon; Persist Security Info=false; Connect Timeout=300";
            optionsBuilder.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString), options => options.EnableRetryOnFailure());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PokedexEntry>().Property<DateTime>("DateCreated").HasDefaultValue("getutcdate()");
            //modelBuilder.Entity<PokedexEntry>().Property<DateTime>("UpdatedDate");
            modelBuilder.Entity<PokedexCategoryEntry>().HasKey(x => new
            {
                x.AccountId, x.Category
            });

            var allEntities = modelBuilder.Model.GetEntityTypes();

            foreach (var entity in allEntities)
            {
                entity.AddProperty("DateCreated", typeof(DateTime)).SetDefaultValueSql("(UTC_TIMESTAMP)");
                entity.AddProperty("DateUpdated", typeof(DateTime)).SetDefaultValueSql("(UTC_TIMESTAMP)");
            }
            
        }
    }

    
}
