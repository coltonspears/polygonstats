using Microsoft.EntityFrameworkCore;
using PolygonStatsPlugins.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PolygonStatsPlugins
{
    public sealed class PluginManager
    {
        public PluginManager() { }

        private static readonly Lazy<PluginManager> _shared = new(() => new PluginManager());
        public static PluginManager Shared => _shared.Value;

        public Dictionary<string, IPolygonPlugin> Plugins { get; private set; } = new Dictionary<string, IPolygonPlugin>();
        public Dictionary<Type, List<object>> PluginDBContexts = new Dictionary<Type, List<object>>();
        public static string PluginPath => PluginConfigurationManager.Shared.PluginConfig.PluginPath;
        
        public void LoadPlugins()
        {
            foreach(var dll in Directory.GetFiles(PluginPath, "*.dll"))
            {
                Assembly assembly = Assembly.LoadFile(dll);
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsSubclassOf(typeof(Plugin)) && type.IsAbstract == false)
                    {
                        IPolygonPlugin plugin = Activator.CreateInstance(type) as IPolygonPlugin;
                        Plugins.Add(Path.GetFileNameWithoutExtension(dll), plugin);
                    }
                    if (type.IsSubclassOf(typeof(DbContext)))
                    {
                        // Instantiate DbContext:
                        var context = type.GetConstructor(Array.Empty<Type>()).Invoke(Array.Empty<object>());

                        // Find method to get entities:
                        var model = type.GetProperty("Model");
                        var searchMethod = model.PropertyType.GetMethod("GetEntityTypes");

                        // Get registered entities:
                        var entities = searchMethod.Invoke(model.GetValue(context, null), null) as List<object>;

                        PluginDBContexts[type] = entities;
                    }
                }

            }
        }
        public void HandlePayload(Payload payload)
        {
            foreach (IPolygonPlugin plugin in Shared.Plugins.Values)
            {
                plugin.HandlePayload(payload);
            }
        }
        public Dictionary<Type, List<object>> FindDbContextsInAssemblies()
        {
            var dbContexts = new Dictionary<Type, List<object>>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsSubclassOf(typeof(DbContext)))
                    {
                        // Instantiate DbContext:
                        var context = type.GetConstructor(Array.Empty<Type>()).Invoke(Array.Empty<object>());

                        // Find method to get entities:
                        var model = type.GetProperty("Model");
                        var searchMethod = model.PropertyType.GetMethod("GetEntityTypes");

                        // Get registered entities:
                        var entities = searchMethod.Invoke(model.GetValue(context, null), null) as List<object>;

                        var optionsBuilderType = typeof(DbContextOptionsBuilder<>).MakeGenericType(type);
                        var optionsBuilder = (DbContextOptionsBuilder)Activator.CreateInstance(optionsBuilderType);
                        var dbCtx = (DbContext)Activator.CreateInstance(type);
                        dbContexts[type] = entities;
                    }
                }
            }

            return dbContexts;
        }
    }
}
