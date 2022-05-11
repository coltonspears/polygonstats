using PolygonStats.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PolygonStats.Plugins
{
    public class PluginManager
    {
        public Dictionary<string, IPolygonPlugin> Plugins { get; private set; }
        public string PluginPath { get; set; }
        public PluginManager()
        {
            Plugins = new Dictionary<string, IPolygonPlugin>();
            PluginPath = ConfigurationManager.Shared.Config.Plugin.PluginPath;
        }
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
                }
            }
        }
        public void HandlePayload(Payload payload)
        {
            foreach (IPolygonPlugin plugin in Plugins.Values)
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

                        dbContexts[type] = entities;
                    }
                }
            }

            return dbContexts;
        }
    }
}
