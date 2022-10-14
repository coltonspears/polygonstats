using PolygonStats;
using PolygonStats.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStatsPlugins
{
    public interface IPolygonPlugin
    {
        //public Guid GUID { get; }
        public string Name { get; }
        public string Version { get; }
        public string FullName { get; }
        public string AssemblyLocation { get; }
        public string AssemblyName { get; }

        bool Enabled { get; }
        public void Start();
        public void HandlePayload(Payload payload);
    }
}
