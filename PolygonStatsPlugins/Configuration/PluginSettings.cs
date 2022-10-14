using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStatsPlugins.Configuration
{
    public class Config
    {
        public PluginSettings Plugin { get; set; }
        public DebugSettings Debug { get; set; }
        public MysqlSettings MySql { get; set; }
        public HttpSettings Http { get; set; }

        public class PluginSettings
        {
            public bool Enabled { get; set; }
            public string PluginPath { get; set; }

        }
        public class HttpSettings
        {
            public bool Enabled { get; set; }
            public int Port { get; set; }
        }
        public class MysqlSettings
        {
            public bool Enabled { get; set; }
            public string ConnectionString { get; set; }
        }
        public class DebugSettings
        {
            public bool Debug { get; set; }
            public bool ToFiles { get; set; }
            public bool DebugMessages { get; set; }
        }
        public Config()
        {
            Plugin = new PluginSettings()
            {
                Enabled = true,
                PluginPath = @"C:\Users\colto\source\repos\polygonstats\PolygonStats\bin\Debug\net5.0\plugins\net5.0"
            };

            MySql = new MysqlSettings()
            {
                Enabled = false,
                ConnectionString = "server=localhost; port=3306; database=polygon; user=poly; password=polygon; Persist Security Info=false; Connect Timeout=300"
            };

            Debug = new DebugSettings()
            {
                Debug = true,
                ToFiles = false,
                DebugMessages = true
            };

            Http = new HttpSettings()
            {
                Enabled = true,
                Port = 8900
            };
        }
    }
}
