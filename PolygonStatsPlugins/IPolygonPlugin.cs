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
        string Name { get; }
        string Version { get; }
        string FullName { get; }
        string AssemblyLocation { get; }
        string AssemblyName { get; }
        public void Start();
        public void HandlePayload(Payload payload);
    }
}
