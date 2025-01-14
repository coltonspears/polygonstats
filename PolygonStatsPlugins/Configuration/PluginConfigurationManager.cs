﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Serilog;
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

        public Config Config { get; set; } = new Config();
        private PluginConfigurationManager()
        {
            ConfigurationBuilder configurationBuilder = new();
            _ = configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            _ = configurationBuilder.AddJsonFile(CONFIG_NAME, true, false);
            IConfiguration builtConfig = configurationBuilder.Build();

            builtConfig.Bind(Config);

            if (!File.Exists(_JsonSource))
            {
                Save();
            }

            Log.Information("[Plugin Manager] Config was loaded!");
        }
        public void Save()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };
            // open config file
            string json = JsonSerializer.Serialize(Config, options);
            //write string to file
            File.WriteAllText(_JsonSource, json);

            Console.WriteLine("Config was created!");
        }
    }
}
