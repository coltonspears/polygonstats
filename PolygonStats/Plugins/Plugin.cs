using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Microsoft.EntityFrameworkCore;
using System.IO;
using PolygonStats.Plugins.Data;
using PolygonStats.Configuration;

namespace PolygonStats.Plugins
{
    public class Plugin
    {
        public string PluginName { get; set; }
        public DbContext PluginContext { get; set; }
        public GameMasterData MasterData { get; set; }
        public MySQLConnectionManager PolygonContextManager { get; set; }

        public Plugin()
        {
            MasterData = GameMasterData.Default;

            PluginName = this.GetType().Name;
            //PluginContext = this.GetType().Get
            Log.Information($"Initializing {PluginName} plugin...");
        }
        public void InitializeDBContext(DbContext context)
        {
            PluginContext = context;
            if (ConfigurationManager.Shared.Config.MySql.Enabled)
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
            Data = Plugins.PokemonData.FromJson(jsonString);
            FullData = Plugins.Data.PokemonGameMaster.FromJson(File.ReadAllText(@"F:\PolygonBackend\Pogo-Data-Generator\master-latest-raw.json"));
            foreach (var poke in Data.Pokemon)
            {
                PokeDictionary[poke.Value.PokedexId] = poke.Value;
            }
        }
    }
}
