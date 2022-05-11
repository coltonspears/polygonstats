using PolygonStats.Plugins;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PolygonStats;
using POGOProtos.Rpc;
using System.Text.Json;
using PokedexParser;

namespace Pokedex
{
    public class Pokedex : Plugin, IPolygonPlugin
    {
        private readonly bool _enabled;
        private MySQLConnectionManager dbManager = new();

        public bool Enabled { get; private set; }
        public Dictionary<long, string> PokeDictionary = new Dictionary<long, string>();
        public void Start()
        {
            string jsonString = File.ReadAllText(@"F:\PolygonBackend\Pogo-Data-Generator\masterfile.json");
            var pokemonData = PokedexParser.PokemonData.FromJson(jsonString);
            foreach (var poke in pokemonData.Pokemon)
            {
                PokeDictionary[poke.Value.PokedexId] = poke.Value.Name;
                //Log.Information("------------------------------");
                //Log.Information($"[{poke.Value.PokedexId}]\t{poke.Value.Name}");
                //Log.Information("\t\tAvailable Forms:");
                //Log.Information("\t\t----------------");
                //foreach (var form in poke.Value.Forms)
                //{
                //    Log.Information($"\t\t{form.Value.Name}");
                //}
            }
        }
        public void HandlePayload(Payload payload)
        {
            switch (payload.getMethodType())
            {
                case Method.GetHoloholoInventory:
                    var holoInventory = GetHoloholoInventoryOutProto.Parser.ParseFrom(payload.getDate());
                    Log.Debug($"Proto: {JsonSerializer.Serialize(holoInventory)}");
                    ProcessHoloInventory(payload.account_name, holoInventory);
                    break;
                default:
                    break;
            }
        }

        private void ProcessHoloInventory(string accountName, GetHoloholoInventoryOutProto holoInventory)
        {
            if (holoInventory.InventoryDelta == null) return;
            if (holoInventory.InventoryDelta.InventoryItem.Count <= 0) return;

            var item = holoInventory.InventoryDelta.InventoryItem.First();
            if (item.InventoryItemData == null) return;

            var inventoryRequestType = item.InventoryItemData.TypeCase;
            switch (inventoryRequestType)
            {
                case HoloInventoryItemProto.TypeOneofCase.PokedexEntry:
                    var entry = item.InventoryItemData.PokedexEntry;
                    var pokedexEntry = PokedexEntry.FromJson(entry.ToString());
                    Console.WriteLine($"[POKEDEX] {pokedexEntry.PokedexEntryNumber}\t{PokeDictionary[pokedexEntry.PokedexEntryNumber]}\t{pokedexEntry.TimesCaptured}");
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PokemonFamily:
                    var pokemonFamily = item.InventoryItemData.PokemonFamily;
                    //var pokemonFamily = PokedexEntry.FromJson(_.ToString());
                    Console.WriteLine($"[FAMILY ]\t{pokemonFamily.FamilyId}\t{pokemonFamily.Candy}\t{pokemonFamily.XlCandy}");
                    break;
                case HoloInventoryItemProto.TypeOneofCase.None:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.Pokemon:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.Item:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PlayerStats:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PlayerCurrency:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PlayerCamera:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.InventoryUpgrades:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.AppliedItems:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.EggIncubators:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.Quest:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.AvatarItem:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.RaidTickets:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.Quests:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.GiftBoxes:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.BelugaIncense:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.RouteMaker:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.LimitedPurchaseSkuRecord:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.RoutePlay:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.MegaEvolveSpecies:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.Sticker:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PokemonHome:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.BadgeData:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PlayerStatsSnapshots:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.FakeData:
                    break;
                case HoloInventoryItemProto.TypeOneofCase.PokedexCategoryMilestone:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }



        }
    }
}
