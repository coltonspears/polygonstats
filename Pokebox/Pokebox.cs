using PolygonStats;
using PolygonStats.Plugins;
using System;

namespace Pokebox
{
    public class Pokebox : Plugin, IPolygonPlugin
    {
        public bool Enabled { get; private set; }

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
    }
}
