using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStats.Plugins
{
    public interface IPolygonPlugin
    {
        bool Enabled { get; }
        public void Start();
        public void HandlePayload(Payload payload);
    }
}
