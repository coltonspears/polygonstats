using System;
using Microsoft.EntityFrameworkCore;
using PolygonStatsPlugins.Configuration;

namespace PolygonStatsPlugins
{
    public class MySQLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnectionString = PluginConfigurationManager.Shared.Config.MySql.ConnectionString;
            optionsBuilder.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString), options => options.EnableRetryOnFailure());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
