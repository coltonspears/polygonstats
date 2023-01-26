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

            base.InitializeDBContext(new PokedexContext());
            PokedexEntryManager.GetAllForms();
        }
        public void HandlePayload(Payload payload)
        {
            string methodType = payload.getMethodType().ToString();

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
                case Method.SavePlayerSnapshot:
                    var mSavePlayerSnapshotOutProto = SavePlayerSnapshotOutProto.Parser.ParseFrom(payload.getDate());
                    break;
                case Method.Unset:
                    break;
                case Method.DownloadItemTemplates:
                    break;
                case Method.DownloadRemoteConfigVersion:
                    break;
                case Method.RegisterBackgroundDevice:
                    break;
                case Method.GetPlayerDay:
                    break;
                case Method.AcknowledgePunishment:
                    break;
                case Method.GetServerTime:
                    break;
                case Method.GetLocalTime:
                    break;
                case Method.FortSearch:
                    break;
                case Method.Encounter:
                    break;
                case Method.CatchPokemon:
                    break;
                case Method.FortDetails:
                    break;
                case Method.GetMapObjects:
                    break;
                case Method.FortDeployPokemon:
                    break;
                case Method.FortRecallPokemon:
                    break;
                case Method.ReleasePokemon:
                    break;
                case Method.UseItemPotion:
                    break;
                case Method.UseItemCapture:
                    break;
                case Method.UseItemFlee:
                    break;
                case Method.UseItemRevive:
                    break;
                case Method.EvolvePokemon:
                    break;
                case Method.GetHatchedEggs:
                    break;
                case Method.EncounterTutorialComplete:
                    break;
                case Method.LevelUpRewards:
                    break;
                case Method.RecycleInventoryItem:
                    break;
                case Method.CollectDailyBonus:
                    break;
                case Method.UseItemXpBoost:
                    break;
                case Method.UseItemEggIncubator:
                    break;
                case Method.UseIncense:
                    break;
                case Method.GetIncensePokemon:
                    break;
                case Method.IncenseEncounter:
                    break;
                case Method.AddFortModifier:
                    break;
                case Method.DiskEncounter:
                    break;
                case Method.UpgradePokemon:
                    break;
                case Method.SetFavoritePokemon:
                    break;
                case Method.NicknamePokemon:
                    break;
                case Method.EquipBadge:
                    break;
                case Method.SetContactSettings:
                    break;
                case Method.SetBuddyPokemon:
                    break;
                case Method.GetBuddyWalked:
                    break;
                case Method.UseItemEncounter:
                    break;
                case Method.GymDeploy:
                    break;
                case Method.GymGetInfo:
                    var mGym = GymGetInfoOutProto.Parser.ParseFrom(payload.getDate());
                    break;
                case Method.GymStartSession:
                    var mGymStartSession = GymStartSessionOutProto.Parser.ParseFrom(payload.getDate());
                    break;
                case Method.GymBattleAttack:
                    var mGymBattleAttack = GymBattleAttackOutProto.Parser.ParseFrom(payload.getDate());
                    break;
                case Method.JoinLobby:
                    break;
                case Method.LeaveLobby:
                    break;
                case Method.SetLobbyVisibility:
                    break;
                case Method.SetLobbyPokemon:
                    break;
                case Method.GetRaidDetails:
                    break;
                case Method.GymFeedPokemon:
                    break;
                case Method.StartRaidBattle:
                    break;
                case Method.AttackRaid:
                    break;
                case Method.AwardPokecoin:
                    break;
                case Method.UseItemStardustBoost:
                    break;
                case Method.ReassignPlayer:
                    break;
                case Method.RedeemPoiPasscode:
                    break;
                case Method.ConvertCandyToXlCandy:
                    break;
                case Method.IsSkuAvailable:
                    break;
                case Method.GetDownloadUrls:
                    break;
                case Method.GetAssetVersion:
                    break;
                case Method.ClaimCodename:
                    break;
                case Method.SetAvatar:
                    break;
                case Method.SetPlayerTeam:
                    break;
                case Method.MarkTutorialComplete:
                    break;
                case Method.UpdatePerformanceMetrics:
                    break;
                case Method.CheckChallenge:
                    break;
                case Method.VerifyChallenge:
                    break;
                case Method.Echo:
                    break;
                case Method.SfidaRegistration:
                    break;
                case Method.SfidaActionLog:
                    break;
                case Method.SfidaCertification:
                    break;
                case Method.SfidaUpdate:
                    break;
                case Method.SfidaAction:
                    break;
                case Method.SfidaDowser:
                    break;
                case Method.SfidaCapture:
                    break;
                case Method.ListAvatarCustomizations:
                    break;
                case Method.SetAvatarItemAsViewed:
                    break;
                case Method.GetInbox:
                    break;
                case Method.ListGymBadges:
                    break;
                case Method.GetGymBadgeDetails:
                    break;
                case Method.UseItemMoveReroll:
                    break;
                case Method.UseItemRareCandy:
                    break;
                case Method.AwardFreeRaidTicket:
                    break;
                case Method.FetchAllNews:
                    break;
                case Method.MarkReadNewsArticle:
                    break;
                case Method.GetPlayerDisplayInfo:
                    break;
                case Method.BelugaTransactionStart:
                    break;
                case Method.BelugaTransactionComplete:
                    break;
                case Method.SfidaAssociate:
                    break;
                case Method.SfidaCheckPairing:
                    break;
                case Method.SfidaDisassociate:
                    break;
                case Method.WainaSubmitSleepData:
                    break;
                case Method.GetNewQuests:
                    break;
                case Method.RemoveQuest:
                    break;
                case Method.QuestEncounter:
                    break;
                case Method.CompleteQuestStampCard:
                    break;
                case Method.StartQuestIncident:
                    break;
                case Method.ReadQuestDialog:
                    break;
                case Method.SendGift:
                    break;
                case Method.OpenGift:
                    break;
                case Method.GiftDetails:
                    break;
                case Method.DeleteGift:
                    break;
                case Method.GetFriendshipMilestoneRewards:
                    break;
                case Method.CheckSendGift:
                    break;
                case Method.SetFriendNickname:
                    break;
                case Method.DeleteGiftFromInventory:
                    break;
                case Method.SaveSocialPlayerSettings:
                    break;
                case Method.ShareExRaidPass:
                    break;
                case Method.CheckShareExRaidPass:
                    break;
                case Method.DeclineSharedExRaidPass:
                    break;
                case Method.OpenTrading:
                    break;
                case Method.UpdateTrading:
                    break;
                case Method.ConfirmTrading:
                    break;
                case Method.CancelTrading:
                    break;
                case Method.GetTrading:
                    break;
                case Method.GetFitnessRewards:
                    break;
                case Method.GenerateCombatChallengeId:
                    break;
                case Method.CreateCombatChallenge:
                    break;
                case Method.OpenCombatChallenge:
                    break;
                case Method.GetCombatChallenge:
                    break;
                case Method.AcceptCombatChallenge:
                    break;
                case Method.DeclineCombatChallenge:
                    break;
                case Method.CancelCombatChallenge:
                    break;
                case Method.SubmitCombatChallengePokemons:
                    break;
                case Method.SaveCombatPlayerPreferences:
                    break;
                case Method.OpenCombatSession:
                    break;
                case Method.UpdateCombat:
                    break;
                case Method.QuitCombat:
                    break;
                case Method.GetCombatResults:
                    break;
                case Method.UnlockSpecialMove:
                    break;
                case Method.GetNpcCombatRewards:
                    break;
                case Method.CombatFriendRequest:
                    break;
                case Method.OpenNpcCombatSession:
                    break;
                case Method.StartTutorialAction:
                    break;
                case Method.GetTutorialEggAction:
                    break;
                case Method.SendProbe:
                    break;
                case Method.CombatData:
                    break;
                case Method.CombatChallengeData:
                    break;
                case Method.CheckPhotobomb:
                    break;
                case Method.ConfirmPhotobomb:
                    break;
                case Method.GetPhotobomb:
                    break;
                case Method.EncounterPhotobomb:
                    break;
                case Method.GetSignedGmapUrlDeprecated:
                    break;
                case Method.ChangeTeam:
                    break;
                case Method.GetWebToken:
                    break;
                case Method.CompleteSnapshotSession:
                    break;
                case Method.CompleteWildSnapshotSession:
                    break;
                case Method.StartIncident:
                    break;
                case Method.InvasionCompleteDialogue:
                    break;
                case Method.InvasionOpenCombatSession:
                    break;
                case Method.InvasionBattleUpdate:
                    break;
                case Method.InvasionEncounter:
                    break;
                case Method.PurifyPokemon:
                    break;
                case Method.GetRocketBalloon:
                    break;
                case Method.StartRocketBalloonIncident:
                    break;
                case Method.VsSeekerStartMatchmaking:
                    break;
                case Method.CancelMatchmaking:
                    break;
                case Method.GetMatchmakingStatus:
                    break;
                case Method.CompleteVsSeekerAndRestartCharging:
                    break;
                case Method.GetVsSeekerStatus:
                    break;
                case Method.CompleteCombatCompetitiveSeasonAction:
                    break;
                case Method.ClaimVsSeekerRewards:
                    break;
                case Method.VsSeekerRewardEncounter:
                    break;
                case Method.ActivateVsSeeker:
                    break;
                case Method.GetBuddyMap:
                    break;
                case Method.GetBuddyStats:
                    break;
                case Method.FeedBuddy:
                    break;
                case Method.OpenBuddyGift:
                    break;
                case Method.PetBuddy:
                    break;
                case Method.GetBuddyHistory:
                    break;
                case Method.UpdateRouteDraft:
                    break;
                case Method.GetMapForts:
                    break;
                case Method.SubmitRouteDraft:
                    break;
                case Method.GetPublishedRoutes:
                    break;
                case Method.StartRoute:
                    break;
                case Method.GetRoutes:
                    break;
                case Method.ProgressRoute:
                    break;
                case Method.ProcessRouteWaypointInteraction:
                    break;
                case Method.ProcessRouteTappable:
                    break;
                case Method.ListRouteBadges:
                    break;
                case Method.CancelRoute:
                    break;
                case Method.ListRouteStamps:
                    break;
                case Method.CreateBuddyMutliplayerSession:
                    break;
                case Method.JoinBuddyMultiplayerSession:
                    break;
                case Method.LeaveBuddyMultiplayerSession:
                    break;
                case Method.GetTodayView:
                    break;
                case Method.MegaEvolvePokemon:
                    break;
                case Method.RemoteGiftPing:
                    break;
                case Method.SendRaidInvitation:
                    break;
                case Method.GetDailyEncounter:
                    break;
                case Method.DailyEncounter:
                    break;
                case Method.OpenSponsoredGift:
                    break;
                case Method.SponsoredGiftReportInteraction:
                    break;
                case Method.SavePlayerPreferences:
                    break;
                case Method.ProfanityCheck:
                    break;
                case Method.GetTimedGroupChallenge:
                    break;
                case Method.GetNintendoAccount:
                    break;
                case Method.UnlinkNintendoAccount:
                    break;
                case Method.GetNintendoOauth2Url:
                    break;
                case Method.TransferToPokemonHome:
                    break;
                case Method.ReportAdFeedback:
                    break;
                case Method.CreatePokemonTag:
                    break;
                case Method.DeletePokemonTag:
                    break;
                case Method.EditPokemonTag:
                    break;
                case Method.SetPokemonTagsForPokemon:
                    break;
                case Method.GetPokemonTags:
                    break;
                case Method.ChangePokemonForm:
                    break;
                case Method.ChooseEventVariant:
                    break;
                case Method.GetReferralCode:
                    break;
                case Method.AddReferrer:
                    break;
                case Method.SendFriendInviteViaReferralCode:
                    break;
                case Method.GetMilestones:
                    break;
                case Method.MarkMilestonesAsViewed:
                    break;
                case Method.GetMilestonesPreview:
                    break;
                case Method.CompleteMilestone:
                    break;
                case Method.GetGeofencedAd:
                    break;
                case Method.PowerUpPokestopEncounter:
                    break;
                case Method.CreatePostcard:
                    break;
                case Method.UpdatePostcard:
                    break;
                case Method.DeletePostcard:
                    break;
                case Method.GetMementoList:
                    break;
                case Method.UploadRaidClientLog:
                    break;
                case Method.SkipEnterReferralCode:
                    break;
                case Method.UploadCombatClientLog:
                    break;
                case Method.CombatSyncServerOffset:
                    break;
                case Method.CheckGiftingEligibility:
                    break;
                case Method.RedeemTicketGiftForFriend:
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
                                //Log.Information($"[{accountName}]\t[POKEDEX] {pokedexEntry.PokedexEntryNumber}\t{MasterData.PokeDictionary[pokedexEntry.PokedexEntryNumber].Name}\tSeen: {pokedexEntry.TimesEncountered}\tCaught: {pokedexEntry.TimesCaptured}");
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PokemonFamily:
                                var pokemonFamily = req.InventoryItemData.PokemonFamily;
                                //var pokemonFamily = PokedexEntry.FromJson(_.ToString());
                                //Log.Information($"[{accountName}]\t[FAMILY ]\t{pokemonFamily.FamilyId}\t{pokemonFamily.Candy}\t{pokemonFamily.XlCandy}");
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.None:
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.Pokemon:
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.Item:
                                var item = req.InventoryItemData.Item;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PlayerStats:
                                var playerStats = req.InventoryItemData.PlayerStats;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PlayerCurrency:
                                var playerCurrency = req.InventoryItemData.PlayerCurrency;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PlayerCamera:
                                var playerCamera = req.InventoryItemData.PlayerCamera;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.InventoryUpgrades:
                                var inventoryUpgrades = req.InventoryItemData.InventoryUpgrades;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.AppliedItems:
                                var appliedItems = req.InventoryItemData.AppliedItems;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.EggIncubators:
                                var EggIncubators = req.InventoryItemData.EggIncubators;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.Quest:
                                var Quest = req.InventoryItemData.Quest;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.AvatarItem:
                                var AvatarItem = req.InventoryItemData.AvatarItem;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.RaidTickets:
                                var RaidTickets = req.InventoryItemData.RaidTickets;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.Quests:
                                var Quests = req.InventoryItemData.Quests;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.GiftBoxes:
                                var GiftBoxes = req.InventoryItemData.GiftBoxes;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.BelugaIncense:
                                var BelugaIncense = req.InventoryItemData.BelugaIncense;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.RouteMaker:
                                var RouteMaker = req.InventoryItemData.RouteMaker;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.LimitedPurchaseSkuRecord:
                                var LimitedPurchaseSkuRecord = req.InventoryItemData.LimitedPurchaseSkuRecord;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.RoutePlay:
                                var RoutePlay = req.InventoryItemData.RoutePlay;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.MegaEvolveSpecies:
                                var MegaEvolveSpecies = req.InventoryItemData.MegaEvolveSpecies;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.Sticker:
                                var Sticker = req.InventoryItemData.Sticker;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PokemonHome:
                                var PokemonHome = req.InventoryItemData.PokemonHome;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.BadgeData:
                                var BadgeData = req.InventoryItemData.BadgeData;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PlayerStatsSnapshots:
                                var FlayerStatsSnapshots = req.InventoryItemData.PlayerStatsSnapshots;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.FakeData:
                                var fakeData = req.InventoryItemData.FakeData;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PokedexCategoryMilestone:
                                var pokedexCategoryMilestone = req.InventoryItemData.PokedexCategoryMilestone;
                                break;
                            case HoloInventoryItemProto.TypeOneofCase.PlayerAttributes:
                                var playerAttributes = req.InventoryItemData.PlayerAttributes;
                                break;
                                
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }


                }
            }
            catch
            {

            }
            //if (item.InventoryItemData == null) return;

            //var inventoryRequestType = item.InventoryItemData.TypeCase;

            //int playerId = MySQLConnectionManager.GetAccountId(accountName);

        }

        public override void LoadConfig()
        {
            throw new NotImplementedException();
        }
    }
}
