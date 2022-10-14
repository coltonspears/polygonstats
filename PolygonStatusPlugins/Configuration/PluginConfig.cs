using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStatsPlugins.Configuration
{
    public class PluginConfig
    {
        public bool Enabled { get; set; }
        public string PluginPath { get; set; }
        public DebugSettings Debug { get; set; }
        public MysqlSettings MySql { get; set; }
        public HttpSettings HttpSettings { get; set; }
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
}
