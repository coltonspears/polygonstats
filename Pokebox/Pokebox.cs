using PolygonStats.Common;
using PolygonStatsPlugins;
using System;

namespace Pokebox
{
    public class Pokebox : Plugin, IPolygonPlugin
    {

        //public Pokebox(Plugin plugin) : base(plugin)
        //{
        //    Enabled = false;
        //}
        public void Start()
        {
            
        }

        public void HandlePayload(Payload payload)
        {
            
        }

        public override void LoadConfig()
        {
            throw new NotImplementedException();
        }
    }
}
