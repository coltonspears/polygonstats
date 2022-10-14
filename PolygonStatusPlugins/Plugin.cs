using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Serilog;
using PolygonStatsPlugins.Configuration;
using PolygonStatsPlugins.Data;

namespace PolygonStatsPlugins
{
    public abstract class Plugin
    {
        public virtual string Name { get => this.GetType().Name; }
        public virtual string Version { get => this.GetType().Assembly.GetName().Version.ToString(); }
        public virtual string FullName { get => this.GetType().FullName; }
        public virtual string AssemblyLocation { get => this.GetType().Assembly.Location; }
        public virtual string AssemblyName { get => this.GetType().Module.Name; }
        public DbContext PluginContext { get; set; }
        public GameMasterData MasterData { get; set; }
        public MySQLConnectionManager PolygonContextManager { get; set; }
        public virtual bool Enabled { get; set; }

        //public abstract void SetEnabled();

        //public Plugin(Plugin other)
        //{
        //    Enabled = other.Enabled;
        //}

        public Plugin()
        {
            MasterData = GameMasterData.Default;

            //PluginContext = this.GetType().Get
            Log.Information($"[{Name}] Initializing plugin");
        }
        public void InitializeDBContext(DbContext context)
        {
            PluginContext = context;
            if (PluginConfigurationManager.Shared.PluginConfig.MySql.Enabled)
            {
                PolygonContextManager = new MySQLConnectionManager();
            }
        
        }
    }
    public class GameMasterData
    {
        private static readonly Lazy<GameMasterData> _default = new(() => new GameMasterData());
        public static GameMasterData Default => _default.Value;

        public string Version = "0.0.1";
        public Dictionary<long, Pokemon> PokeDictionary { get; set; } = new Dictionary<long, Pokemon>();
        public PokemonData Data { get; set; }
        public PokemonGameMaster FullData { get; set; }

        public GameMasterData()
        {
            string jsonString = File.ReadAllText(@"F:\PolygonBackend\Pogo-Data-Generator\masterfile.json");
            Data = PokemonData.FromJson(jsonString);
            FullData = PokemonGameMaster.FromJson(File.ReadAllText(@"F:\PolygonBackend\Pogo-Data-Generator\master-latest-raw.json"));
            foreach (var poke in Data.Pokemon)
            {
                PokeDictionary[poke.Value.PokedexId] = poke.Value;
            }
        }
    }
}
