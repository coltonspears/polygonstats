using Microsoft.EntityFrameworkCore;
using Pokebox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebox
{
    public class PokeboxContext : DbContext
    {
        public PokeboxContext() { }
        public DbSet<PokeboxEntry> PokeboxEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnectionString = "server=localhost; port=3306; database=pplugin; user=poly; password=polygon; Persist Security Info=false; Connect Timeout=300";
            optionsBuilder.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString), options => options.EnableRetryOnFailure());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PokedexEntry>().Property<DateTime>("DateCreated").HasDefaultValue("getutcdate()");
            //modelBuilder.Entity<PokedexEntry>().Property<DateTime>("UpdatedDate");
            //modelBuilder.Entity<PokedexCategoryEntry>().HasKey(x => new
            //{
            //    x.AccountId,
            //    x.Category
            //});

            var allEntities = modelBuilder.Model.GetEntityTypes();

            foreach (var entity in allEntities)
            {
                entity.AddProperty("DateCreated", typeof(DateTime)).SetDefaultValueSql("(UTC_TIMESTAMP)");
                entity.AddProperty("DateUpdated", typeof(DateTime)).SetDefaultValueSql("(UTC_TIMESTAMP)");
            }

        }
    }


}
