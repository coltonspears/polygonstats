using POGOProtos.Rpc;
using PolygonStats;
using PolygonStats.Common;
using PolygonStatsPlugins;
using Serilog;
using System;

namespace Pokebox
{
    public class Pokebox : Plugin, IPolygonPlugin
    {
        public LoggerConfiguration loggerConfiguration;

        private PokeboxEntryManager connectionManager = new PokeboxEntryManager();


        public void Start()
        {

        }

        public void HandlePayload(Payload payload)
        {
            switch (payload.getMethodType())
            {


                case Method.GetHoloholoInventory:
                    var holoInventory = GetHoloholoInventoryOutProto.Parser.ParseFrom(payload.getDate());
                    //Log.Debug($"Proto: {JsonSerializer.Serialize(holoInventory)}");
                    ProcessHoloInventory(payload.account_name, holoInventory);
                    break;
            }
        }
        private void ProcessHoloInventory(string accountName, GetHoloholoInventoryOutProto holoInventory)
        {
            try
            {
                if (holoInventory.InventoryDelta == null) return;
                if (holoInventory.InventoryDelta.InventoryItem.Count <= 0) return;

                int playerId = PolygonStats.MySQLConnectionManager.GetAccountId(accountName);
                //var item = holoInventory.InventoryDelta.InventoryItem.First();
                foreach (var req in holoInventory.InventoryDelta.InventoryItem)
                {
                    if (req.InventoryItemData != null)
                    {
                        var inventoryRequestType = req.InventoryItemData.TypeCase;

                        PokeboxEntryManager pokedexEntryManager = new();


                        switch (inventoryRequestType)
                        {
                            case HoloInventoryItemProto.TypeOneofCase.Pokemon:
                                Log.Information("[Pokebox] Saving Pokemon Storage...");
                                Guid extractGuid = Guid.NewGuid();
                                connectionManager.AddPokeboxToDatabase(extractGuid, holoInventory.InventoryDelta.InventoryItem);
                                Log.Information("[Pokebox] Saving Pokemon Complete.");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch(Exception e){
                Log.Information($"[Pokebox] Error Saving Storage : {e}");
            }
        }

        public override void LoadConfig()
        {
            throw new NotImplementedException();
        }
    }
}
