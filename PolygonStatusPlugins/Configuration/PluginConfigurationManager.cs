using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text.Json;

namespace PolygonStatsPlugins.Configuration
{
    public class PluginConfigurationManager
    {
        private const string CONFIG_NAME = "PluginConfig.json";

        private string _JsonSource { get; set; } = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}{CONFIG_NAME}";
        private static readonly Lazy<PluginConfigurationManager> _shared = new(() => new PluginConfigurationManager());
        public static PluginConfigurationManager Shared => _shared.Value;

        public PluginConfig PluginConfig { get; set; } = new PluginConfig();
        private PluginConfigurationManager()
        {
            ConfigurationBuilder configurationBuilder = new();
            _ = configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            _ = configurationBuilder.AddJsonFile(CONFIG_NAME, true, false);
            IConfiguration builtConfig = configurationBuilder.Build();

            builtConfig.Bind(PluginConfig);

            if (!File.Exists(_JsonSource))
            {
                Save();
            }

            Console.WriteLine("Config was loaded!");
        }
        public void Save()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };
            // open config file
            string json = JsonSerializer.Serialize(PluginConfig, options);
            //write string to file
            File.WriteAllText(_JsonSource, json);

            Console.WriteLine("Config was created!");
        }
    }
}
