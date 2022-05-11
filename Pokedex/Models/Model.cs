using System;
using System.Collections.Generic;
using PolygonStats.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POGOProtos.Rpc;
using PolygonStats;

namespace Pokedex.Models
{
  public class PokedexContext : DbContext
  {
    
    public PokedexContext()
    {
    }

    public DbSet<PokedexEntry> PokedexEntries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      string dbConnectionString = "server=localhost; port=3306; database=pplugin; user=poly; password=polygon; Persist Security Info=false; Connect Timeout=300";
      optionsBuilder.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString), options => options.EnableRetryOnFailure());
    }
    //public static void OnModelCreating<TBase>(ModelBuilder builder)
    //  where TBase : class, IBase
    //{
    //  builder.Entity<TBase>().HasKey(_base => _base.Id);
    //}
  }

  //public class PluginDatabaseManager
  //{
  //  public PokedexContext GetContext()
  //  {
  //    return new PokedexContext();
  //  }
  //}

  //public interface IBase
  //{

  //  static void OnModelCreating<TBase>(ModelBuilder builder);
  //}
  //public abstract partial class Base : IBase
  //{
  //  public virtual int Id { get; }

  //  public static void OnModelCreating<TBase>(ModelBuilder builder)
  //  where TBase : class, IBase
  //  {
  //    builder.Entity<TBase>().HasKey(_base => _base.Id);
  //  }
  //}
}
