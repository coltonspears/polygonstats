using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace PolygonStats.Plugins
{
    public class Plugin
    {
        public string PluginName { get; set; }

        public Plugin()
        {
            LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/main.log", rollingInterval: RollingInterval.Day);

            Log.Logger = loggerConfiguration.CreateLogger();

            PluginName = this.GetType().Name;
            Log.Information($"Initializing {PluginName} plugin...");
        }
    }
}
