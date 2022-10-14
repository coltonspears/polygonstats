using PolygonStatsPlugins;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PokedexParser;
using Pokedex.Models;
using PolygonStats.Configuration;
using PolygonStats.Common;
using PolygonStats.Common.Proto;

namespace Pokedex
{
    public class Pokedex : Plugin, IPolygonPlugin
    {
        public bool Enabled { get; private set; }

        //public Pokedex(Plugin plugin) : base(plugin)
        //{
        //    Enabled = true;
        //}
        //private readonly bool _enabled;

        public LoggerConfiguration loggerConfiguration;

        public void Start()
        {
            //LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
            //    .WriteTo.Console()
            //    .WriteTo.Seq("http://localhost:5432")
            //    .WriteTo.File("logs/main.log", rollingInterval: RollingInterval.Day);

            //if (ConfigurationManager.Shared.Config.Debug.Debug)
            //{
            //    loggerConfiguration = loggerConfiguration.MinimumLevel.Debug();
            //}
            //else
            //{
            //    loggerConfiguration = loggerConfiguration.MinimumLevel.Information();
            //}
            //Log.Logger = loggerConfiguration.CreateLogger();
            Enabled = true;
            base.InitializeDBContext(new PokedexContext());
            PokedexEntryManager.GetAllForms();
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
                case Method.GetQuestDetails:
                    var questDetails = GetQuestDetailsOutProto.Parser.ParseFrom(payload.getDate());
                    //Log.Debug($"Proto: {JsonSerializer.Serialize(holoInventory)}");
                    ProcessQuestDetails(payload.account_name, questDetails);
                    break;
                case Method.CompleteQuest:
                    var mCompleteQuestOutProto = CompleteQuestOutProto.Parser.ParseFrom(payload.getDate());

                    GetCompleteQuest(payload.account_name, mCompleteQuestOutProto);
                    break;
                case Method.GetCombatPlayerProfile:
                    var mGetCombatPlayerProfileOutProto = GetCombatPlayerProfileOutProto.Parser.ParseFrom(payload.getDate());

                    GetCombatPlayerProfile(payload.account_name, mGetCombatPlayerProfileOutProto);
                    break;
                case Method.GetPlayerProfile:
                    var mPlayerProfileOutProto = PlayerProfileOutProto.Parser.ParseFrom(payload.getDate());

                    GetCombatPlayerProfile(payload.account_name, mPlayerProfileOutProto);
                    break;
                case Method.GetPlayer:
                    var mGetPlayerOutProto = GetPlayerOutProto.Parser.ParseFrom(payload.getDate());

                    GetPlayer(payload.account_name, mGetPlayerOutProto);
                    break;
                case Method.ProbeData:
                    var mProbeProtoe = ProbeProto.Parser.ParseFrom(payload.getDate());

                    GetProbe(payload.account_name, mProbeProtoe);
                    break;
                case Method.ProgressQuest:
                    var mProgressQuestOutProto = ProgressQuestOutProto.Parser.ParseFrom(payload.getDate());

                    GetProgressQuest(payload.account_name, mProgressQuestOutProto);
                    break;
                case Method.CheckAwardedBadges:
                    var mBadgeSettingsProto = BadgeSettingsProto.Parser.ParseFrom(payload.getDate());
                    var mBadgeSettingsProto2 = CheckAwardedBadgesOutProto.Parser.ParseFrom(payload.getDate());
                    CheckAwardedBadges(payload.account_name, mBadgeSettingsProto);
                    break;
                case Method.DownloadSettings:
                    var mDownloadSettingsActionProto = DownloadSettingsActionProto.Parser.ParseFrom(payload.getDate());
                    var mDownloadSettingsResponseProto = DownloadSettingsResponseProto.Parser.ParseFrom(payload.getDate());
                    DownloadSettings(payload.account_name, mDownloadSettingsActionProto, mDownloadSettingsResponseProto);
                    break;
                case Method.GetAssetDigest:
                    var mAssetDigestOutProto = AssetDigestOutProto.Parser.ParseFrom(payload.getDate());
                    var mAssetDigestEntryProto = AssetDigestEntryProto.Parser.ParseFrom(payload.getDate());
                    //GetAssetDigest(payload.account_name, mAssetDigestOutProto);
                    break;
                default:
                    break;
            }
        }
        private void DownloadSettings(string accountName, DownloadSettingsActionProto proto, DownloadSettingsResponseProto proto2)
        {
            if (proto == null) return;
            var v = proto;
        }
        private void CheckAwardedBadges(string accountName, BadgeSettingsProto proto)
        {
            if (proto == null) return;
            var v = proto;
        }
        private void GetProgressQuest(string accountName, ProgressQuestOutProto proto)
        {
            if (proto == null) return;
            var v = proto;
        }
        private void GetProbe(string accountName, ProbeProto proto)
        {
            if (proto == null) return;
            var v = proto;
        }
        private static void GetPlayer(string accountName, GetPlayerOutProto proto)
        {
            if (proto == null) return;
            //var used = new UseIncenseActionProto();
            //used.IncenseType = POGOProtos.Rpc.Item.IncenseOrdinary;
            //var used2 = new UseIncenseActionProto(used);
            var v = proto;
            //Log.Information($"[GetPlayer][GetPlayerOutProto][NaXXXXX99] Max Item Storage: {v.Player.MaxItemStorage}");
            //Log.Information($"[GetPlayer][GetPlayerOutProto][NaXXXXX99] Max Pokemon Storage: {v.Player.MaxPokemonStorage}");
            var storage = v.Player.MaxItemStorage;
        }
        private void GetCombatPlayerProfile(string accountName, PlayerProfileOutProto proto)
        {
            if (proto == null) return;
            var v = proto;
        }
        private void GetCombatPlayerProfile(string accountName, GetCombatPlayerProfileOutProto proto)
        {
            if (proto.Profile == null) return;
            var v = proto;
        }
        private void GetCompleteQuest(string accountName, CompleteQuestOutProto proto)
        {
            if (proto.Quest == null) return;
            var v = proto;
        }
        private void ProcessQuestDetails(string accountName, GetQuestDetailsOutProto questDetails)
        {
            if (questDetails.Quests == null) return;
            var v = questDetails;
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

                        PokedexEntryManager pokedexEntryManager = new();


                        switch (inventoryRequestType)
                        {
                            case HoloInventoryItemProto.TypeOneofCase.PokedexEntry:
                                var pokedexEntry = req.InventoryItemData.PokedexEntry;
                                pokedexEntryManager.Process(playerId, pokedexEntry);
                                //PokedexEntryManager.AddPokedexEntry(pokedexEntry);
                                Log.Information($"[{accountName}]\t[POKEDEX] {pokedexEntry.PokedexEntryNumber}\t{MasterData.PokeDictionary[pokedexEntry.PokedexEntryNumber].Name}\tSeen: {pokedexEntry.TimesEncountered}\tCaught: {pokedexEntry.TimesCaptured}");
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PokemonFamily:
                                var pokemonFamily = req.InventoryItemData.PokemonFamily;
                                //var pokemonFamily = PokedexEntry.FromJson(_.ToString());
                                Log.Information($"[{accountName}]\t[FAMILY ]\t{pokemonFamily.FamilyId}\t{pokemonFamily.Candy}\t{pokemonFamily.XlCandy}");
                                break;
                            //case HoloInventoryItemProto.TypeOneofCase.None:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.Pokemon:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.Item:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.PlayerStats:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.PlayerCurrency:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.PlayerCamera:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.InventoryUpgrades:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.AppliedItems:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.EggIncubators:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.Quest:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.AvatarItem:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.RaidTickets:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.Quests:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.GiftBoxes:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.BelugaIncense:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.RouteMaker:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.LimitedPurchaseSkuRecord:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.RoutePlay:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.MegaEvolveSpecies:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.Sticker:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.PokemonHome:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.BadgeData:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.PlayerStatsSnapshots:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.FakeData:
                            //    break;
                            //case HoloInventoryItemProto.TypeOneofCase.PokedexCategoryMilestone:
                            //    break;
                            //default:
                            //    throw new ArgumentOutOfRangeException();
                        }
                    }


                }
            } catch
            {

            }
            //if (item.InventoryItemData == null) return;

            //var inventoryRequestType = item.InventoryItemData.TypeCase;

            //int playerId = MySQLConnectionManager.GetAccountId(accountName);
            
        }
    }
}
