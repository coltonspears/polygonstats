﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Pokedex.Models
{


    public partial class PokemonGameMaster
    {
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemElement> Items { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }
    }

    public partial class ItemElement
    {
        [JsonProperty("templateId", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        [JsonProperty("addressablePokemonSettings", NullValueHandling = NullValueHandling.Ignore)]
        public AddressablePokemonSettings AddressablePokemonSettings { get; set; }

        [JsonProperty("addressBookImportSettings", NullValueHandling = NullValueHandling.Ignore)]
        public AddressBookImportSettings AddressBookImportSettings { get; set; }

        [JsonProperty("arTelemetrySettings", NullValueHandling = NullValueHandling.Ignore)]
        public ArTelemetrySettings ArTelemetrySettings { get; set; }

        [JsonProperty("avatarGroupOrderSettings", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarGroupOrderSettings AvatarGroupOrderSettings { get; set; }

        [JsonProperty("avatarCustomization", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarCustomization AvatarCustomization { get; set; }

        [JsonProperty("levelUpRewardSettings", NullValueHandling = NullValueHandling.Ignore)]
        public LevelUpRewardSettings LevelUpRewardSettings { get; set; }

        [JsonProperty("backgroundModeSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundModeSettings BackgroundModeSettings { get; set; }

        [JsonProperty("badgeSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BadgeSettings BadgeSettings { get; set; }

        [JsonProperty("battleHubBadgeSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BattleHubBadgeSettings BattleHubBadgeSettings { get; set; }

        [JsonProperty("battleHubOrderSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BattleHubOrderSettings BattleHubOrderSettings { get; set; }

        [JsonProperty("battlePartySettings", NullValueHandling = NullValueHandling.Ignore)]
        public BattlePartySettings BattlePartySettings { get; set; }

        [JsonProperty("battleSettings", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> BattleSettings { get; set; }

        [JsonProperty("battleVisualSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BattleVisualSettings BattleVisualSettings { get; set; }

        [JsonProperty("belugaPokemonWhitelist", NullValueHandling = NullValueHandling.Ignore)]
        public BelugaPokemonWhitelist BelugaPokemonWhitelist { get; set; }

        [JsonProperty("buddyActivitySettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyActivitySettings BuddyActivitySettings { get; set; }

        [JsonProperty("buddyActivityCategorySettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyActivityCategorySettings BuddyActivityCategorySettings { get; set; }

        [JsonProperty("buddyEmotionLevelSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyEmotionLevelSettings BuddyEmotionLevelSettings { get; set; }

        [JsonProperty("buddyEncounterCameoSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyEncounterCameoSettings BuddyEncounterCameoSettings { get; set; }

        [JsonProperty("buddyHungerSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyHungerSettings BuddyHungerSettings { get; set; }

        [JsonProperty("buddyInteractionSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyInteractionSettings BuddyInteractionSettings { get; set; }

        [JsonProperty("buddyLevelSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyLevelSettings BuddyLevelSettings { get; set; }

        [JsonProperty("buddySwapSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddySwapSettings BuddySwapSettings { get; set; }

        [JsonProperty("buddyWalkSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BuddyWalkSettings BuddyWalkSettings { get; set; }

        [JsonProperty("evolutionQuestTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public EvolutionQuestTemplate EvolutionQuestTemplate { get; set; }

        [JsonProperty("invasionNpcDisplaySettings", NullValueHandling = NullValueHandling.Ignore)]
        public InvasionNpcDisplaySettings InvasionNpcDisplaySettings { get; set; }

        [JsonProperty("combatCompetitiveSeasonSettings", NullValueHandling = NullValueHandling.Ignore)]
        public CombatCompetitiveSeasonSettings CombatCompetitiveSeasonSettings { get; set; }

        [JsonProperty("combatLeague", NullValueHandling = NullValueHandling.Ignore)]
        public CombatLeague CombatLeague { get; set; }

        [JsonProperty("combatLeagueSettings", NullValueHandling = NullValueHandling.Ignore)]
        public CombatLeagueSettings CombatLeagueSettings { get; set; }

        [JsonProperty("combatType", NullValueHandling = NullValueHandling.Ignore)]
        public CombatType CombatType { get; set; }

        [JsonProperty("combatRankingProtoSettings", NullValueHandling = NullValueHandling.Ignore)]
        public CombatRankingProtoSettings CombatRankingProtoSettings { get; set; }

        [JsonProperty("combatSettings", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> CombatSettings { get; set; }

        [JsonProperty("combatStatStageSettings", NullValueHandling = NullValueHandling.Ignore)]
        public CombatStatStageSettings CombatStatStageSettings { get; set; }

        [JsonProperty("combatMove", NullValueHandling = NullValueHandling.Ignore)]
        public CombatMove CombatMove { get; set; }

        [JsonProperty("crossGameSocialSettings", NullValueHandling = NullValueHandling.Ignore)]
        public CrossGameSocialSettings CrossGameSocialSettings { get; set; }

        [JsonProperty("deepLinkingSettings", NullValueHandling = NullValueHandling.Ignore)]
        public DeepLinkingSettings DeepLinkingSettings { get; set; }

        [JsonProperty("eggHatchImprovementsSettings", NullValueHandling = NullValueHandling.Ignore)]
        public EggHatchImprovementsSettings EggHatchImprovementsSettings { get; set; }

        [JsonProperty("eggTransparencySettings", NullValueHandling = NullValueHandling.Ignore)]
        public EggTransparencySettings EggTransparencySettings { get; set; }

        [JsonProperty("friendProfileSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FriendProfileSettings FriendProfileSettings { get; set; }

        [JsonProperty("encounterSettings", NullValueHandling = NullValueHandling.Ignore)]
        public EncounterSettings EncounterSettings { get; set; }

        [JsonProperty("pokemonHomeEnergyCosts", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonHomeEnergyCosts PokemonHomeEnergyCosts { get; set; }

        [JsonProperty("evolvePreviewSettings", NullValueHandling = NullValueHandling.Ignore)]
        public EvolvePreviewSettings EvolvePreviewSettings { get; set; }

        [JsonProperty("externalAddressableAssetsSettings", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalAddressableAssetsSettings ExternalAddressableAssetsSettings { get; set; }

        [JsonProperty("exRaidSettings", NullValueHandling = NullValueHandling.Ignore)]
        public ExRaidSettings ExRaidSettings { get; set; }

        [JsonProperty("formsRefactorSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FormsRefactorSettings FormsRefactorSettings { get; set; }

        [JsonProperty("formSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FormSettings FormSettings { get; set; }

        [JsonProperty("fortPowerUpSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FortPowerUpSettings FortPowerUpSettings { get; set; }

        [JsonProperty("friendshipMilestoneSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FriendshipMilestoneSettings FriendshipMilestoneSettings { get; set; }

        [JsonProperty("geotargetedQuestSettings", NullValueHandling = NullValueHandling.Ignore)]
        public GeotargetedQuestSettings GeotargetedQuestSettings { get; set; }

        [JsonProperty("guiSearchSettings", NullValueHandling = NullValueHandling.Ignore)]
        public GuiSearchSettings GuiSearchSettings { get; set; }

        [JsonProperty("gymBadgeSettings", NullValueHandling = NullValueHandling.Ignore)]
        public GymBadgeSettings GymBadgeSettings { get; set; }

        [JsonProperty("gymLevel", NullValueHandling = NullValueHandling.Ignore)]
        public GymLevel GymLevel { get; set; }

        [JsonProperty("iapCategoryDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public IapCategoryDisplay IapCategoryDisplay { get; set; }

        [JsonProperty("iapSettings", NullValueHandling = NullValueHandling.Ignore)]
        public IapSettings IapSettings { get; set; }

        [JsonProperty("incidentPrioritySettings", NullValueHandling = NullValueHandling.Ignore)]
        public IncidentPrioritySettings IncidentPrioritySettings { get; set; }

        [JsonProperty("pokestopInvasionAvailabilitySettings", NullValueHandling = NullValueHandling.Ignore)]
        public PokestopInvasionAvailabilitySettings PokestopInvasionAvailabilitySettings { get; set; }

        [JsonProperty("inventorySettings", NullValueHandling = NullValueHandling.Ignore)]
        public InventorySettings InventorySettings { get; set; }

        [JsonProperty("itemSettings", NullValueHandling = NullValueHandling.Ignore)]
        public ItemSettings ItemSettings { get; set; }

        [JsonProperty("loadingScreenSettings", NullValueHandling = NullValueHandling.Ignore)]
        public LoadingScreenSettings LoadingScreenSettings { get; set; }

        [JsonProperty("limitedPurchaseSkuSettings", NullValueHandling = NullValueHandling.Ignore)]
        public LimitedPurchaseSkuSettings LimitedPurchaseSkuSettings { get; set; }

        [JsonProperty("luckyPokemonSettings", NullValueHandling = NullValueHandling.Ignore)]
        public LuckyPokemonSettings LuckyPokemonSettings { get; set; }

        [JsonProperty("mapDisplaySettings", NullValueHandling = NullValueHandling.Ignore)]
        public MapDisplaySettings MapDisplaySettings { get; set; }

        [JsonProperty("mapObjectsInteractionRangeSettings", NullValueHandling = NullValueHandling.Ignore)]
        public MapObjectsInteractionRangeSettings MapObjectsInteractionRangeSettings { get; set; }

        [JsonProperty("megaEvoSettings", NullValueHandling = NullValueHandling.Ignore)]
        public MegaEvoSettings MegaEvoSettings { get; set; }

        [JsonProperty("monodepthSettings", NullValueHandling = NullValueHandling.Ignore)]
        public MonodepthSettings MonodepthSettings { get; set; }

        [JsonProperty("newsFeedClientSettings", NullValueHandling = NullValueHandling.Ignore)]
        public NewsFeedClientSettings NewsFeedClientSettings { get; set; }

        [JsonProperty("onboardingV2Settings", NullValueHandling = NullValueHandling.Ignore)]
        public OnboardingV2Settings OnboardingV2Settings { get; set; }

        [JsonProperty("partyRecommendationSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PartyRecommendationSettings PartyRecommendationSettings { get; set; }

        [JsonProperty("platypusRolloutSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PlatypusRolloutSettings PlatypusRolloutSettings { get; set; }

        [JsonProperty("playerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public PlayerLevel PlayerLevel { get; set; }

        [JsonProperty("pokecoinPurchaseDisplayGmt", NullValueHandling = NullValueHandling.Ignore)]
        public Gmt PokecoinPurchaseDisplayGmt { get; set; }

        [JsonProperty("pokedexCategoriesSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PokedexCategoriesSettings PokedexCategoriesSettings { get; set; }

        [JsonProperty("pokemonHomeSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonHomeSettings PokemonHomeSettings { get; set; }

        [JsonProperty("pokemonScaleSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonScaleSettings PokemonScaleSettings { get; set; }

        [JsonProperty("pokemonTagSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonTagSettings PokemonTagSettings { get; set; }

        [JsonProperty("typeEffective", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEffective TypeEffective { get; set; }

        [JsonProperty("pokemonUpgrades", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonUpgrades PokemonUpgrades { get; set; }

        [JsonProperty("postcardCollectionSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PostcardCollectionSettings PostcardCollectionSettings { get; set; }

        [JsonProperty("powerUpPokestopSharedSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PowerUpPokestopSharedSettings PowerUpPokestopSharedSettings { get; set; }

        [JsonProperty("pushGatewaySettings", NullValueHandling = NullValueHandling.Ignore)]
        public PushGatewaySettings PushGatewaySettings { get; set; }

        [JsonProperty("questEvolutionSettings", NullValueHandling = NullValueHandling.Ignore)]
        public QuestEvolutionSettings QuestEvolutionSettings { get; set; }

        [JsonProperty("questSettings", NullValueHandling = NullValueHandling.Ignore)]
        public QuestSettings QuestSettings { get; set; }

        [JsonProperty("raidSettings", NullValueHandling = NullValueHandling.Ignore)]
        public RaidSettings RaidSettings { get; set; }

        [JsonProperty("recommendedSearchSettings", NullValueHandling = NullValueHandling.Ignore)]
        public RecommendedSearchSettings RecommendedSearchSettings { get; set; }

        [JsonProperty("referralSettings", NullValueHandling = NullValueHandling.Ignore)]
        public ReferralSettings ReferralSettings { get; set; }

        [JsonProperty("sharedMoveSettings", NullValueHandling = NullValueHandling.Ignore)]
        public SharedMoveSettings SharedMoveSettings { get; set; }

        [JsonProperty("smeargleMovesSettings", NullValueHandling = NullValueHandling.Ignore)]
        public SmeargleMovesSettings SmeargleMovesSettings { get; set; }

        [JsonProperty("genderSettings", NullValueHandling = NullValueHandling.Ignore)]
        public GenderSettings GenderSettings { get; set; }

        [JsonProperty("sponsoredGeofenceGiftSettings", NullValueHandling = NullValueHandling.Ignore)]
        public SponsoredGeofenceGiftSettings SponsoredGeofenceGiftSettings { get; set; }

        [JsonProperty("stickerMetadata", NullValueHandling = NullValueHandling.Ignore)]
        public StickerMetadata StickerMetadata { get; set; }

        [JsonProperty("iapItemDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public IapItemDisplay IapItemDisplay { get; set; }

        [JsonProperty("surveySettings", NullValueHandling = NullValueHandling.Ignore)]
        public SurveySettings SurveySettings { get; set; }

        [JsonProperty("temporaryEvolutionSettings", NullValueHandling = NullValueHandling.Ignore)]
        public TemporaryEvolutionSettings TemporaryEvolutionSettings { get; set; }

        [JsonProperty("combatNpcTrainer", NullValueHandling = NullValueHandling.Ignore)]
        public CombatNpcTrainer CombatNpcTrainer { get; set; }

        [JsonProperty("combatNpcPersonality", NullValueHandling = NullValueHandling.Ignore)]
        public CombatNpcPersonality CombatNpcPersonality { get; set; }

        [JsonProperty("pokemonFamily", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonFamily PokemonFamily { get; set; }

        [JsonProperty("pokemonSettings", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonSettings PokemonSettings { get; set; }

        [JsonProperty("moveSettings", NullValueHandling = NullValueHandling.Ignore)]
        public MoveSettings MoveSettings { get; set; }

        [JsonProperty("pokemonHomeFormReversions", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonHomeFormReversions PokemonHomeFormReversions { get; set; }

        [JsonProperty("verboseLogRaidSettings", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> VerboseLogRaidSettings { get; set; }

        [JsonProperty("vsSeekerClientSettings", NullValueHandling = NullValueHandling.Ignore)]
        public VsSeekerClientSettings VsSeekerClientSettings { get; set; }

        [JsonProperty("vsSeekerLoot", NullValueHandling = NullValueHandling.Ignore)]
        public VsSeekerLoot VsSeekerLoot { get; set; }

        [JsonProperty("vsSeekerPokemonRewards", NullValueHandling = NullValueHandling.Ignore)]
        public VsSeekerPokemonRewards VsSeekerPokemonRewards { get; set; }

        [JsonProperty("weatherAffinities", NullValueHandling = NullValueHandling.Ignore)]
        public WeatherAffinities WeatherAffinities { get; set; }

        [JsonProperty("weatherBonusSettings", NullValueHandling = NullValueHandling.Ignore)]
        public WeatherBonusSettings WeatherBonusSettings { get; set; }

        [JsonProperty("adventureSyncV2Gmt", NullValueHandling = NullValueHandling.Ignore)]
        public Gmt AdventureSyncV2Gmt { get; set; }

        [JsonProperty("camera", NullValueHandling = NullValueHandling.Ignore)]
        public ItemCamera Camera { get; set; }

        [JsonProperty("moveSequenceSettings", NullValueHandling = NullValueHandling.Ignore)]
        public MoveSequenceSettings MoveSequenceSettings { get; set; }

        [JsonProperty("tutorialsSettings", NullValueHandling = NullValueHandling.Ignore)]
        public TutorialsSettings TutorialsSettings { get; set; }

        [JsonProperty("usernameSuggestionSettings", NullValueHandling = NullValueHandling.Ignore)]
        public UsernameSuggestionSettings UsernameSuggestionSettings { get; set; }
    }

    public partial class AddressBookImportSettings
    {
        [JsonProperty("isEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; }

        [JsonProperty("onboardingScreenLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnboardingScreenLevel { get; set; }

        [JsonProperty("showOptOutCheckbox", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOptOutCheckbox { get; set; }
    }

    public partial class AddressablePokemonSettings
    {
        [JsonProperty("pokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PokemonId { get; set; }
    }

    public partial class Gmt
    {
        [JsonProperty("featureEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FeatureEnabled { get; set; }
    }

    public partial class ArTelemetrySettings
    {
        [JsonProperty("measureBattery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MeasureBattery { get; set; }

        [JsonProperty("batterySamplingIntervalMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? BatterySamplingIntervalMs { get; set; }

        [JsonProperty("measureFramerate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MeasureFramerate { get; set; }

        [JsonProperty("framerateSamplingIntervalMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? FramerateSamplingIntervalMs { get; set; }

        [JsonProperty("percentageSessionsToSample", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageSessionsToSample { get; set; }
    }

    public partial class AvatarCustomization
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("avatarType", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarType? AvatarType { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public List<Slot> Slot { get; set; }

        [JsonProperty("bundleName", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleName { get; set; }

        [JsonProperty("assetName", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public Name? GroupName { get; set; }

        [JsonProperty("sortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public long? SortOrder { get; set; }

        [JsonProperty("unlockType", NullValueHandling = NullValueHandling.Ignore)]
        public UnlockType? UnlockType { get; set; }

        [JsonProperty("iconName", NullValueHandling = NullValueHandling.Ignore)]
        public string IconName { get; set; }

        [JsonProperty("iapSku", NullValueHandling = NullValueHandling.Ignore)]
        public string IapSku { get; set; }

        [JsonProperty("unlockBadgeType", NullValueHandling = NullValueHandling.Ignore)]
        public string UnlockBadgeType { get; set; }

        [JsonProperty("unlockBadgeLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnlockBadgeLevel { get; set; }

        [JsonProperty("unlockPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnlockPlayerLevel { get; set; }
    }

    public partial class AvatarGroupOrderSettings
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public List<Group> Group { get; set; }
    }

    public partial class Group
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Name? Name { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("showNewTag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNewTag { get; set; }
    }

    public partial class BackgroundModeSettings
    {
        [JsonProperty("weeklyFitnessGoalLevel1DistanceKm", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeeklyFitnessGoalLevel1DistanceKm { get; set; }

        [JsonProperty("weeklyFitnessGoalLevel2DistanceKm", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeeklyFitnessGoalLevel2DistanceKm { get; set; }

        [JsonProperty("weeklyFitnessGoalLevel3DistanceKm", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeeklyFitnessGoalLevel3DistanceKm { get; set; }

        [JsonProperty("weeklyFitnessGoalLevel4DistanceKm", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeeklyFitnessGoalLevel4DistanceKm { get; set; }
    }

    public partial class BadgeSettings
    {
        [JsonProperty("badgeType", NullValueHandling = NullValueHandling.Ignore)]
        public string BadgeType { get; set; }

        [JsonProperty("badgeRank", NullValueHandling = NullValueHandling.Ignore)]
        public long? BadgeRank { get; set; }

        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Targets { get; set; }

        [JsonProperty("eventBadge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EventBadge { get; set; }
    }

    public partial class BattleHubBadgeSettings
    {
        [JsonProperty("combatHubDisplayedBadges", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CombatHubDisplayedBadges { get; set; }
    }

    public partial class BattleHubOrderSettings
    {
        [JsonProperty("section", NullValueHandling = NullValueHandling.Ignore)]
        public List<Section> Section { get; set; }

        [JsonProperty("sectionGroup", NullValueHandling = NullValueHandling.Ignore)]
        public List<SectionGroup> SectionGroup { get; set; }
    }

    public partial class Section
    {
        [JsonProperty("mainSection", NullValueHandling = NullValueHandling.Ignore)]
        public string MainSection { get; set; }

        [JsonProperty("subsection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Subsection { get; set; }
    }

    public partial class SectionGroup
    {
        [JsonProperty("section", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Section { get; set; }
    }

    public partial class BattlePartySettings
    {
        [JsonProperty("maxBattleParties", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxBattleParties { get; set; }

        [JsonProperty("overallPartiesCap", NullValueHandling = NullValueHandling.Ignore)]
        public long? OverallPartiesCap { get; set; }
    }

    public partial class BattleVisualSettings
    {
        [JsonProperty("battleVisualStadiumEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BattleVisualStadiumEnabled { get; set; }

        [JsonProperty("stadiumCrowdAsset", NullValueHandling = NullValueHandling.Ignore)]
        public string StadiumCrowdAsset { get; set; }

        [JsonProperty("stadiumBannerAsset", NullValueHandling = NullValueHandling.Ignore)]
        public string StadiumBannerAsset { get; set; }
    }

    public partial class BelugaPokemonWhitelist
    {
        [JsonProperty("maxAllowedPokemonPokedexNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxAllowedPokemonPokedexNumber { get; set; }

        [JsonProperty("additionalPokemonAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdditionalPokemonAllowed { get; set; }

        [JsonProperty("costumesAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CostumesAllowed { get; set; }
    }

    public partial class BuddyActivityCategorySettings
    {
        [JsonProperty("activityCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityCategory { get; set; }

        [JsonProperty("maxPointsPerDay", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxPointsPerDay { get; set; }
    }

    public partial class BuddyActivitySettings
    {
        [JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
        public string Activity { get; set; }

        [JsonProperty("activityCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityCategory { get; set; }

        [JsonProperty("maxTimesPerDay", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxTimesPerDay { get; set; }

        [JsonProperty("numPointsPerAction", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumPointsPerAction { get; set; }

        [JsonProperty("numEmotionPointsPerAction", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumEmotionPointsPerAction { get; set; }

        [JsonProperty("emotionCooldownDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? EmotionCooldownDurationMs { get; set; }
    }

    public partial class BuddyEmotionLevelSettings
    {
        [JsonProperty("emotionLevel", NullValueHandling = NullValueHandling.Ignore)]
        public string EmotionLevel { get; set; }

        [JsonProperty("emotionAnimation", NullValueHandling = NullValueHandling.Ignore)]
        public string EmotionAnimation { get; set; }

        [JsonProperty("minEmotionPointsRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinEmotionPointsRequired { get; set; }
    }

    public partial class BuddyEncounterCameoSettings
    {
        [JsonProperty("buddyWildEncounterCameoChancePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? BuddyWildEncounterCameoChancePercent { get; set; }

        [JsonProperty("buddyQuestEncounterCameoChancePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? BuddyQuestEncounterCameoChancePercent { get; set; }

        [JsonProperty("buddyRaidEncounterCameoChancePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? BuddyRaidEncounterCameoChancePercent { get; set; }

        [JsonProperty("buddyInvasionEncounterCameoChancePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? BuddyInvasionEncounterCameoChancePercent { get; set; }
    }

    public partial class BuddyHungerSettings
    {
        [JsonProperty("numHungerPointsRequiredForFull", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumHungerPointsRequiredForFull { get; set; }

        [JsonProperty("decayPointsPerBucket", NullValueHandling = NullValueHandling.Ignore)]
        public long? DecayPointsPerBucket { get; set; }

        [JsonProperty("millisecondsPerBucket", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MillisecondsPerBucket { get; set; }

        [JsonProperty("cooldownDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CooldownDurationMs { get; set; }

        [JsonProperty("decayDurationAfterFullMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? DecayDurationAfterFullMs { get; set; }
    }

    public partial class BuddyInteractionSettings
    {
        [JsonProperty("feedItemWhitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FeedItemWhitelist { get; set; }
    }

    public partial class BuddyLevelSettings
    {
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        [JsonProperty("minNonCumulativePointsRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinNonCumulativePointsRequired { get; set; }

        [JsonProperty("unlockedTraits", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnlockedTraits { get; set; }
    }

    public partial class BuddySwapSettings
    {
        [JsonProperty("maxSwapsPerDay", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxSwapsPerDay { get; set; }

        [JsonProperty("obBuddySwapBool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObBuddySwapBool { get; set; }
    }

    public partial class BuddyWalkSettings
    {
        [JsonProperty("kmRequiredPerAffectionPoint", NullValueHandling = NullValueHandling.Ignore)]
        public long? KmRequiredPerAffectionPoint { get; set; }
    }

    public partial class ItemCamera
    {
        [JsonProperty("interpolation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Interpolation> Interpolation { get; set; }

        [JsonProperty("targetType", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetType> TargetType { get; set; }

        [JsonProperty("easeInSpeed", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> EaseInSpeed { get; set; }

        [JsonProperty("easeOutSpeed", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> EaseOutSpeed { get; set; }

        [JsonProperty("durationSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DurationSeconds { get; set; }

        [JsonProperty("waitSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> WaitSeconds { get; set; }

        [JsonProperty("transitionSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> TransitionSeconds { get; set; }

        [JsonProperty("angleDegree", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> AngleDegree { get; set; }

        [JsonProperty("angleOffsetDegree", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> AngleOffsetDegree { get; set; }

        [JsonProperty("pitchDegree", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> PitchDegree { get; set; }

        [JsonProperty("pitchOffsetDegree", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> PitchOffsetDegree { get; set; }

        [JsonProperty("rollDegree", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> RollDegree { get; set; }

        [JsonProperty("distanceMeters", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DistanceMeters { get; set; }

        [JsonProperty("heightPercent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> HeightPercent { get; set; }

        [JsonProperty("vertCtrRatio", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> VertCtrRatio { get; set; }

        [JsonProperty("nextCamera", NullValueHandling = NullValueHandling.Ignore)]
        public string NextCamera { get; set; }
    }

    public partial class CombatCompetitiveSeasonSettings
    {
        [JsonProperty("seasonEndTimeTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SeasonEndTimeTimestamp { get; set; }

        [JsonProperty("ratingAdjustmentPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingAdjustmentPercentage { get; set; }

        [JsonProperty("rankingAdjustmentPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? RankingAdjustmentPercentage { get; set; }
    }

    public partial class CombatLeague
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("pokemonCondition", NullValueHandling = NullValueHandling.Ignore)]
        public List<PokemonCondition> PokemonCondition { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get; set; }

        [JsonProperty("pokemonCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PokemonCount { get; set; }

        [JsonProperty("bannedPokemon", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BannedPokemon { get; set; }

        [JsonProperty("badgeType", NullValueHandling = NullValueHandling.Ignore)]
        public BadgeType? BadgeType { get; set; }

        [JsonProperty("leagueType", NullValueHandling = NullValueHandling.Ignore)]
        public LeagueType? LeagueType { get; set; }

        [JsonProperty("allowTempEvos", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowTempEvos { get; set; }

        [JsonProperty("unlockCondition", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnlockCondition> UnlockCondition { get; set; }

        [JsonProperty("battlePartyCombatLeagueTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public CombatLeagueTemplateId? BattlePartyCombatLeagueTemplateId { get; set; }
    }

    public partial class PokemonCondition
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonConditionType? Type { get; set; }

        [JsonProperty("withPokemonCpLimit", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonConditionWithPokemonCpLimit WithPokemonCpLimit { get; set; }

        [JsonProperty("pokemonWhiteList", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonList PokemonWhiteList { get; set; }

        [JsonProperty("pokemonCaughtTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonCaughtTimestamp PokemonCaughtTimestamp { get; set; }

        [JsonProperty("pokemonLevelRange", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonLevelRange PokemonLevelRange { get; set; }

        [JsonProperty("withPokemonType", NullValueHandling = NullValueHandling.Ignore)]
        public WithPokemonType WithPokemonType { get; set; }

        [JsonProperty("pokemonBanList", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonList PokemonBanList { get; set; }
    }

    public partial class PokemonList
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public List<PokemonElement> Pokemon { get; set; }
    }

    public partial class PokemonElement
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public string Form { get; set; }

        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Forms { get; set; }
    }

    public partial class PokemonCaughtTimestamp
    {
        [JsonProperty("afterTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string AfterTimestamp { get; set; }
    }

    public partial class PokemonLevelRange
    {
        [JsonProperty("maxLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxLevel { get; set; }
    }

    public partial class PokemonConditionWithPokemonCpLimit
    {
        [JsonProperty("maxCp", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxCp { get; set; }
    }

    public partial class WithPokemonType
    {
        [JsonProperty("pokemonType", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeElement> PokemonType { get; set; }
    }

    public partial class UnlockCondition
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonConditionType? Type { get; set; }

        [JsonProperty("minPokemonCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinPokemonCount { get; set; }

        [JsonProperty("withPokemonCpLimit", NullValueHandling = NullValueHandling.Ignore)]
        public UnlockConditionWithPokemonCpLimit WithPokemonCpLimit { get; set; }
    }

    public partial class UnlockConditionWithPokemonCpLimit
    {
        [JsonProperty("minCp", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinCp { get; set; }

        [JsonProperty("maxCp", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxCp { get; set; }
    }

    public partial class CombatLeagueSettings
    {
        [JsonProperty("combatLeagueTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public List<CombatLeagueTemplateId> CombatLeagueTemplateId { get; set; }
    }

    public partial class CombatMove
    {
        [JsonProperty("uniqueId", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }

        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public long? Power { get; set; }

        [JsonProperty("vfxName", NullValueHandling = NullValueHandling.Ignore)]
        public string VfxName { get; set; }

        [JsonProperty("energyDelta", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyDelta { get; set; }

        [JsonProperty("buffs", NullValueHandling = NullValueHandling.Ignore)]
        public Buffs Buffs { get; set; }

        [JsonProperty("durationTurns", NullValueHandling = NullValueHandling.Ignore)]
        public long? DurationTurns { get; set; }
    }

    public partial class Buffs
    {
        [JsonProperty("targetDefenseStatStageChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetDefenseStatStageChange { get; set; }

        [JsonProperty("buffActivationChance", NullValueHandling = NullValueHandling.Ignore)]
        public double? BuffActivationChance { get; set; }

        [JsonProperty("attackerAttackStatStageChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackerAttackStatStageChange { get; set; }

        [JsonProperty("targetAttackStatStageChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetAttackStatStageChange { get; set; }

        [JsonProperty("attackerDefenseStatStageChange", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackerDefenseStatStageChange { get; set; }
    }

    public partial class CombatNpcPersonality
    {
        [JsonProperty("personalityName", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalityName { get; set; }

        [JsonProperty("superEffectiveChance", NullValueHandling = NullValueHandling.Ignore)]
        public double? SuperEffectiveChance { get; set; }

        [JsonProperty("specialChance", NullValueHandling = NullValueHandling.Ignore)]
        public double? SpecialChance { get; set; }

        [JsonProperty("offensiveMinimumScore", NullValueHandling = NullValueHandling.Ignore)]
        public double? OffensiveMinimumScore { get; set; }

        [JsonProperty("offensiveMaximumScore", NullValueHandling = NullValueHandling.Ignore)]
        public double? OffensiveMaximumScore { get; set; }

        [JsonProperty("defensiveMinimumScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefensiveMinimumScore { get; set; }

        [JsonProperty("defensiveMaximumScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefensiveMaximumScore { get; set; }
    }

    public partial class CombatNpcTrainer
    {
        [JsonProperty("trainerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainerName { get; set; }

        [JsonProperty("combatLeagueTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public CombatLeagueTemplateId? CombatLeagueTemplateId { get; set; }

        [JsonProperty("combatPersonalityId", NullValueHandling = NullValueHandling.Ignore)]
        public string CombatPersonalityId { get; set; }

        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public CombatNpcTrainerAvatar Avatar { get; set; }

        [JsonProperty("availablePokemon", NullValueHandling = NullValueHandling.Ignore)]
        public List<CombatNpcTrainerAvailablePokemon> AvailablePokemon { get; set; }

        [JsonProperty("trainerTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainerTitle { get; set; }

        [JsonProperty("trainerQuote", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainerQuote { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get; set; }

        [JsonProperty("backdropImageBundle", NullValueHandling = NullValueHandling.Ignore)]
        public BackdropImageBundle? BackdropImageBundle { get; set; }
    }

    public partial class CombatNpcTrainerAvailablePokemon
    {
        [JsonProperty("pokemonType", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonType { get; set; }

        [JsonProperty("pokemonDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonDisplay PokemonDisplay { get; set; }
    }

    public partial class PokemonDisplay
    {
        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public string Form { get; set; }
    }

    public partial class CombatNpcTrainerAvatar
    {
        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public long? Avatar { get; set; }
    }

    public partial class CombatRankingProtoSettings
    {
        [JsonProperty("rankLevel", NullValueHandling = NullValueHandling.Ignore)]
        public List<RankLevel> RankLevel { get; set; }

        [JsonProperty("requiredForRewards", NullValueHandling = NullValueHandling.Ignore)]
        public RequiredForRewards RequiredForRewards { get; set; }

        [JsonProperty("minRankToDisplayRating", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinRankToDisplayRating { get; set; }

        [JsonProperty("minRatingRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinRatingRequired { get; set; }
    }

    public partial class RankLevel
    {
        [JsonProperty("rankLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? RankLevelRankLevel { get; set; }

        [JsonProperty("additionalTotalBattlesRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditionalTotalBattlesRequired { get; set; }

        [JsonProperty("additionalWinsRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditionalWinsRequired { get; set; }

        [JsonProperty("minRatingRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinRatingRequired { get; set; }
    }

    public partial class RequiredForRewards
    {
        [JsonProperty("rankLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? RankLevel { get; set; }

        [JsonProperty("additionalTotalBattlesRequired", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditionalTotalBattlesRequired { get; set; }
    }

    public partial class CombatStatStageSettings
    {
        [JsonProperty("minimumStatStage", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinimumStatStage { get; set; }

        [JsonProperty("maximumStatStage", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaximumStatStage { get; set; }

        [JsonProperty("attackBuffMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> AttackBuffMultiplier { get; set; }

        [JsonProperty("defenseBuffMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DefenseBuffMultiplier { get; set; }
    }

    public partial class CombatType
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }

        [JsonProperty("niceLevelThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? NiceLevelThreshold { get; set; }

        [JsonProperty("greatLevelThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? GreatLevelThreshold { get; set; }

        [JsonProperty("excellentLevelThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExcellentLevelThreshold { get; set; }
    }

    public partial class CrossGameSocialSettings
    {
        [JsonProperty("onlineStatusEnabledOverrideLevel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlineStatusEnabledOverrideLevel { get; set; }

        [JsonProperty("nianticProfileEnabledOverrideLevel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NianticProfileEnabledOverrideLevel { get; set; }
    }

    public partial class DeepLinkingSettings
    {
        [JsonProperty("minPlayerLevelForExternalLink", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinPlayerLevelForExternalLink { get; set; }

        [JsonProperty("minPlayerLevelForNotificationLink", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinPlayerLevelForNotificationLink { get; set; }

        [JsonProperty("externalAction", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExternalAction { get; set; }

        [JsonProperty("notificationAction", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationAction { get; set; }
    }

    public partial class EggHatchImprovementsSettings
    {
        [JsonProperty("featureEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FeatureEnabled { get; set; }

        [JsonProperty("eggHatchAnimationDelayMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? EggHatchAnimationDelayMs { get; set; }

        [JsonProperty("eggHatchAnimationInteruptionDelayMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? EggHatchAnimationInteruptionDelayMs { get; set; }
    }

    public partial class EggTransparencySettings
    {
        [JsonProperty("enableEggDistribution", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEggDistribution { get; set; }
    }

    public partial class EncounterSettings
    {
        [JsonProperty("spinBonusThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? SpinBonusThreshold { get; set; }

        [JsonProperty("excellentThrowThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExcellentThrowThreshold { get; set; }

        [JsonProperty("greatThrowThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? GreatThrowThreshold { get; set; }

        [JsonProperty("niceThrowThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? NiceThrowThreshold { get; set; }

        [JsonProperty("milestoneThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? MilestoneThreshold { get; set; }

        [JsonProperty("arPlusModeEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ArPlusModeEnabled { get; set; }

        [JsonProperty("arCloseProximityThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? ArCloseProximityThreshold { get; set; }

        [JsonProperty("arLowAwarenessThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? ArLowAwarenessThreshold { get; set; }
    }

    public partial class EvolutionQuestTemplate
    {
        [JsonProperty("questTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestTemplateId { get; set; }

        [JsonProperty("questType", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestType { get; set; }

        [JsonProperty("goals", NullValueHandling = NullValueHandling.Ignore)]
        public List<Goal> Goals { get; set; }

        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public Context? Context { get; set; }

        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public Display Display { get; set; }
    }

    public partial class Display
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }

    public partial class Goal
    {
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public long? Target { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public List<Condition> Condition { get; set; }
    }

    public partial class Condition
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("withPokemonType", NullValueHandling = NullValueHandling.Ignore)]
        public WithPokemonType WithPokemonType { get; set; }

        [JsonProperty("withThrowType", NullValueHandling = NullValueHandling.Ignore)]
        public WithThrowType WithThrowType { get; set; }
    }

    public partial class WithThrowType
    {
        [JsonProperty("throwType", NullValueHandling = NullValueHandling.Ignore)]
        public string ThrowType { get; set; }
    }

    public partial class EvolvePreviewSettings
    {
        [JsonProperty("enableEvolutionPreview", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEvolutionPreview { get; set; }

        [JsonProperty("enableMegaEvolutionPreview", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMegaEvolutionPreview { get; set; }
    }

    public partial class ExRaidSettings
    {
        [JsonProperty("minimumExRaidShareLevel", NullValueHandling = NullValueHandling.Ignore)]
        public string MinimumExRaidShareLevel { get; set; }

        [JsonProperty("obExRaidSetting", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObExRaidSetting { get; set; }
    }

    public partial class ExternalAddressableAssetsSettings
    {
    }

    public partial class FormSettings
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public string Pokemon { get; set; }

        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public List<Form> Forms { get; set; }
    }

    public partial class Form
    {
        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public string FormForm { get; set; }

        [JsonProperty("assetBundleSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetBundleSuffix { get; set; }

        [JsonProperty("isCostume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCostume { get; set; }

        [JsonProperty("assetBundleValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? AssetBundleValue { get; set; }
    }

    public partial class FormsRefactorSettings
    {
        [JsonProperty("obFormsRefactorSettingsBool1", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObFormsRefactorSettingsBool1 { get; set; }

        [JsonProperty("obFormsRefactorSettingsBool2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObFormsRefactorSettingsBool2 { get; set; }

        [JsonProperty("obFormsRefactorSettingsBool3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObFormsRefactorSettingsBool3 { get; set; }

        [JsonProperty("enableSingularShadowForm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSingularShadowForm { get; set; }
    }

    public partial class FortPowerUpSettings
    {
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        [JsonProperty("pointsNeededForLevelUp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointsNeededForLevelUp { get; set; }

        [JsonProperty("powerUpReward", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PowerUpReward { get; set; }

        [JsonProperty("durationOfPowerUpMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? DurationOfPowerUpMs { get; set; }
    }

    public partial class FriendProfileSettings
    {
        [JsonProperty("enableSwiping", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSwiping { get; set; }
    }

    public partial class FriendshipMilestoneSettings
    {
        [JsonProperty("milestoneXpReward", NullValueHandling = NullValueHandling.Ignore)]
        public long? MilestoneXpReward { get; set; }

        [JsonProperty("attackBonusPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttackBonusPercentage { get; set; }

        [JsonProperty("unlockedTrading", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnlockedTrading { get; set; }

        [JsonProperty("minPointsToReach", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinPointsToReach { get; set; }

        [JsonProperty("raidBallBonus", NullValueHandling = NullValueHandling.Ignore)]
        public long? RaidBallBonus { get; set; }

        [JsonProperty("tradingDiscount", NullValueHandling = NullValueHandling.Ignore)]
        public double? TradingDiscount { get; set; }
    }

    public partial class GenderSettings
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public string Pokemon { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public Gender Gender { get; set; }
    }

    public partial class Gender
    {
        [JsonProperty("malePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MalePercent { get; set; }

        [JsonProperty("femalePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? FemalePercent { get; set; }

        [JsonProperty("genderlessPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? GenderlessPercent { get; set; }
    }

    public partial class GeotargetedQuestSettings
    {
        [JsonProperty("enableGeotargetedQuests", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableGeotargetedQuests { get; set; }
    }

    public partial class GuiSearchSettings
    {
        [JsonProperty("guiSearchEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GuiSearchEnabled { get; set; }

        [JsonProperty("maxNumberRecentSearches", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxNumberRecentSearches { get; set; }

        [JsonProperty("maxNumberFavoriteSearches", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxNumberFavoriteSearches { get; set; }

        [JsonProperty("maxQueryLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxQueryLength { get; set; }
    }

    public partial class GymBadgeSettings
    {
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Target { get; set; }

        [JsonProperty("battleWinningScorePerDefenderCp", NullValueHandling = NullValueHandling.Ignore)]
        public double? BattleWinningScorePerDefenderCp { get; set; }

        [JsonProperty("gymDefendingScorePerMinute", NullValueHandling = NullValueHandling.Ignore)]
        public long? GymDefendingScorePerMinute { get; set; }

        [JsonProperty("berryFeedingScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? BerryFeedingScore { get; set; }

        [JsonProperty("pokemonDeployScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? PokemonDeployScore { get; set; }

        [JsonProperty("raidBattleWinningScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? RaidBattleWinningScore { get; set; }

        [JsonProperty("loseAllBattlesScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? LoseAllBattlesScore { get; set; }
    }

    public partial class GymLevel
    {
        [JsonProperty("requiredExperience", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> RequiredExperience { get; set; }

        [JsonProperty("leaderSlots", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> LeaderSlots { get; set; }

        [JsonProperty("trainerSlots", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> TrainerSlots { get; set; }
    }

    public partial class IapCategoryDisplay
    {
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty("sortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public long? SortOrder { get; set; }

        [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("bannerEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BannerEnabled { get; set; }

        [JsonProperty("bannerTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string BannerTitle { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("displayRows", NullValueHandling = NullValueHandling.Ignore)]
        public long? DisplayRows { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; }
    }

    public partial class IapItemDisplay
    {
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Category? Category { get; set; }

        [JsonProperty("sortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public long? SortOrder { get; set; }

        [JsonProperty("sale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sale { get; set; }

        [JsonProperty("spriteId", NullValueHandling = NullValueHandling.Ignore)]
        public string SpriteId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; }

        [JsonProperty("skuEnableTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SkuEnableTime { get; set; }

        [JsonProperty("skuDisableTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SkuDisableTime { get; set; }

        [JsonProperty("skuEnableTimeUtcMs", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuEnableTimeUtcMs { get; set; }

        [JsonProperty("skuDisableTimeUtcMs", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuDisableTimeUtcMs { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }
    }

    public partial class IapSettings
    {
        [JsonProperty("dailyDefenderBonusPerPokemon", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> DailyDefenderBonusPerPokemon { get; set; }

        [JsonProperty("dailyDefenderBonusMaxDefenders", NullValueHandling = NullValueHandling.Ignore)]
        public long? DailyDefenderBonusMaxDefenders { get; set; }

        [JsonProperty("dailyDefenderBonusCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DailyDefenderBonusCurrency { get; set; }

        [JsonProperty("minTimeBetweenClaimsMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MinTimeBetweenClaimsMs { get; set; }
    }

    public partial class IncidentPrioritySettings
    {
        [JsonProperty("incidentPriority", NullValueHandling = NullValueHandling.Ignore)]
        public List<IncidentPriority> IncidentPriority { get; set; }
    }

    public partial class IncidentPriority
    {
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public long? Priority { get; set; }

        [JsonProperty("displayType", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayType { get; set; }
    }

    public partial class InvasionNpcDisplaySettings
    {
        [JsonProperty("trainerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainerName { get; set; }

        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public InvasionNpcDisplaySettingsAvatar Avatar { get; set; }

        [JsonProperty("trainerTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainerTitle { get; set; }

        [JsonProperty("trainerQuote", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainerQuote { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get; set; }

        [JsonProperty("backdropImageBundle", NullValueHandling = NullValueHandling.Ignore)]
        public BackdropImageBundle? BackdropImageBundle { get; set; }

        [JsonProperty("modelName", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        [JsonProperty("tutorialOnLossString", NullValueHandling = NullValueHandling.Ignore)]
        public string TutorialOnLossString { get; set; }

        [JsonProperty("isMale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMale { get; set; }

        [JsonProperty("partySelectionMusic", NullValueHandling = NullValueHandling.Ignore)]
        public string PartySelectionMusic { get; set; }

        [JsonProperty("combatMusic", NullValueHandling = NullValueHandling.Ignore)]
        public string CombatMusic { get; set; }
    }

    public partial class InvasionNpcDisplaySettingsAvatar
    {
        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public long? Avatar { get; set; }

        [JsonProperty("skin", NullValueHandling = NullValueHandling.Ignore)]
        public long? Skin { get; set; }

        [JsonProperty("avatarHair", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarHair { get; set; }

        [JsonProperty("avatarShirt", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarShirt { get; set; }

        [JsonProperty("avatarPants", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarPants { get; set; }

        [JsonProperty("avatarHat", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarHat { get; set; }

        [JsonProperty("avatarShoes", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarShoes { get; set; }

        [JsonProperty("avatarEyes", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarEyes { get; set; }

        [JsonProperty("avatarBackpack", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarBackpack { get; set; }

        [JsonProperty("avatarGloves", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarGloves { get; set; }

        [JsonProperty("avatarSocks", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarSocks { get; set; }

        [JsonProperty("avatarBelt", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarBelt { get; set; }

        [JsonProperty("avatarGlasses", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarGlasses { get; set; }

        [JsonProperty("avatarNecklace", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarNecklace { get; set; }

        [JsonProperty("avatarPose", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarPose { get; set; }

        [JsonProperty("avatarFace", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarFace { get; set; }
    }

    public partial class InventorySettings
    {
        [JsonProperty("maxPokemon", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxPokemon { get; set; }

        [JsonProperty("maxBagItems", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxBagItems { get; set; }

        [JsonProperty("basePokemon", NullValueHandling = NullValueHandling.Ignore)]
        public long? BasePokemon { get; set; }

        [JsonProperty("baseBagItems", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseBagItems { get; set; }

        [JsonProperty("baseEggs", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseEggs { get; set; }

        [JsonProperty("maxTeamChanges", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxTeamChanges { get; set; }

        [JsonProperty("teamChangeItemResetPeriodInDays", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TeamChangeItemResetPeriodInDays { get; set; }

        [JsonProperty("maxItemBoostDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MaxItemBoostDurationMs { get; set; }

        [JsonProperty("enableEggsNotInventory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEggsNotInventory { get; set; }

        [JsonProperty("specialEggOverflowSpots", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpecialEggOverflowSpots { get; set; }

        [JsonProperty("enableRaidPassOverflow", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRaidPassOverflow { get; set; }

        [JsonProperty("basePostcardStorage", NullValueHandling = NullValueHandling.Ignore)]
        public long? BasePostcardStorage { get; set; }

        [JsonProperty("maxPostcardStorage", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxPostcardStorage { get; set; }
    }

    public partial class ItemSettings
    {
        [JsonProperty("itemId", NullValueHandling = NullValueHandling.Ignore)]
        public ItemId? ItemId { get; set; }

        [JsonProperty("itemType", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty("dropTrainerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? DropTrainerLevel { get; set; }

        [JsonProperty("food", NullValueHandling = NullValueHandling.Ignore)]
        public Food Food { get; set; }

        [JsonProperty("globalEventTicket", NullValueHandling = NullValueHandling.Ignore)]
        public GlobalEventTicket GlobalEventTicket { get; set; }

        [JsonProperty("incidentTicket", NullValueHandling = NullValueHandling.Ignore)]
        public IncidentTicket IncidentTicket { get; set; }

        [JsonProperty("potion", NullValueHandling = NullValueHandling.Ignore)]
        public Potion Potion { get; set; }

        [JsonProperty("incense", NullValueHandling = NullValueHandling.Ignore)]
        public Incense Incense { get; set; }

        [JsonProperty("eggIncubator", NullValueHandling = NullValueHandling.Ignore)]
        public EggIncubator EggIncubator { get; set; }

        [JsonProperty("inventoryUpgrade", NullValueHandling = NullValueHandling.Ignore)]
        public InventoryUpgrade InventoryUpgrade { get; set; }

        [JsonProperty("xpBoost", NullValueHandling = NullValueHandling.Ignore)]
        public XpBoost XpBoost { get; set; }

        [JsonProperty("revive", NullValueHandling = NullValueHandling.Ignore)]
        public Revive Revive { get; set; }

        [JsonProperty("stardustBoost", NullValueHandling = NullValueHandling.Ignore)]
        public StardustBoost StardustBoost { get; set; }
    }

    public partial class EggIncubator
    {
        [JsonProperty("incubatorType", NullValueHandling = NullValueHandling.Ignore)]
        public string IncubatorType { get; set; }

        [JsonProperty("uses", NullValueHandling = NullValueHandling.Ignore)]
        public long? Uses { get; set; }

        [JsonProperty("distanceMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? DistanceMultiplier { get; set; }
    }

    public partial class Food
    {
        [JsonProperty("itemEffect", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ItemEffect { get; set; }

        [JsonProperty("itemEffectPercent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> ItemEffectPercent { get; set; }

        [JsonProperty("growthPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? GrowthPercent { get; set; }

        [JsonProperty("berryMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? BerryMultiplier { get; set; }

        [JsonProperty("remoteBerryMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? RemoteBerryMultiplier { get; set; }

        [JsonProperty("numBuddyAffectionPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumBuddyAffectionPoints { get; set; }

        [JsonProperty("mapDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MapDurationMs { get; set; }

        [JsonProperty("activeDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ActiveDurationMs { get; set; }

        [JsonProperty("numBuddyHungerPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumBuddyHungerPoints { get; set; }
    }

    public partial class GlobalEventTicket
    {
        [JsonProperty("eventStartTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EventStartTime { get; set; }

        [JsonProperty("eventEndTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EventEndTime { get; set; }

        [JsonProperty("itemBagDescriptionKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemBagDescriptionKey { get; set; }

        [JsonProperty("clientEventStartTimeUtcMs", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientEventStartTimeUtcMs { get; set; }

        [JsonProperty("clientEventEndTimeUtcMs", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientEventEndTimeUtcMs { get; set; }
    }

    public partial class Incense
    {
        [JsonProperty("incenseLifetimeSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? IncenseLifetimeSeconds { get; set; }

        [JsonProperty("spawnTableProbability", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpawnTableProbability { get; set; }
    }

    public partial class IncidentTicket
    {
        [JsonProperty("ignoreFullInventory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreFullInventory { get; set; }

        [JsonProperty("upgradeRequirementCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpgradeRequirementCount { get; set; }

        [JsonProperty("upgradedItem", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradedItem { get; set; }
    }

    public partial class InventoryUpgrade
    {
        [JsonProperty("additionalStorage", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditionalStorage { get; set; }

        [JsonProperty("upgradeType", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeType { get; set; }
    }

    public partial class Potion
    {
        [JsonProperty("staAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? StaAmount { get; set; }

        [JsonProperty("staPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? StaPercent { get; set; }
    }

    public partial class Revive
    {
        [JsonProperty("staPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? StaPercent { get; set; }
    }

    public partial class StardustBoost
    {
        [JsonProperty("stardustMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? StardustMultiplier { get; set; }

        [JsonProperty("boostDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? BoostDurationMs { get; set; }
    }

    public partial class XpBoost
    {
        [JsonProperty("xpMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public long? XpMultiplier { get; set; }

        [JsonProperty("boostDurationMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? BoostDurationMs { get; set; }
    }

    public partial class LevelUpRewardSettings
    {
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public long? Level { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Items { get; set; }

        [JsonProperty("itemsCount", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> ItemsCount { get; set; }

        [JsonProperty("itemsUnlocked", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ItemsUnlocked { get; set; }

        [JsonProperty("avatarTemplateIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvatarTemplateIds { get; set; }
    }

    public partial class LimitedPurchaseSkuSettings
    {
        [JsonProperty("purchaseLimit", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurchaseLimit { get; set; }

        [JsonProperty("chronoUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string ChronoUnit { get; set; }

        [JsonProperty("lootTableId", NullValueHandling = NullValueHandling.Ignore)]
        public string LootTableId { get; set; }

        [JsonProperty("resetInterval", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResetInterval { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }
    }

    public partial class LoadingScreenSettings
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("displayAfterTimestampMs", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayAfterTimestampMs { get; set; }

        [JsonProperty("colorSettings", NullValueHandling = NullValueHandling.Ignore)]
        public ColorSettings ColorSettings { get; set; }
    }

    public partial class ColorSettings
    {
        [JsonProperty("warning_text", NullValueHandling = NullValueHandling.Ignore)]
        public string WarningText { get; set; }

        [JsonProperty("progress_background", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgressBackground { get; set; }

        [JsonProperty("progress_bar_left", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgressBarLeft { get; set; }

        [JsonProperty("progress_bar_right", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgressBarRight { get; set; }
    }

    public partial class LuckyPokemonSettings
    {
        [JsonProperty("powerUpStardustDiscountPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? PowerUpStardustDiscountPercent { get; set; }
    }

    public partial class MapDisplaySettings
    {
        [JsonProperty("showEnhancedSky", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowEnhancedSky { get; set; }
    }

    public partial class MapObjectsInteractionRangeSettings
    {
        [JsonProperty("interactionRangeMeters", NullValueHandling = NullValueHandling.Ignore)]
        public long? InteractionRangeMeters { get; set; }

        [JsonProperty("farInteractionRangeMeters", NullValueHandling = NullValueHandling.Ignore)]
        public long? FarInteractionRangeMeters { get; set; }

        [JsonProperty("remoteInteractionRangeMeters", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemoteInteractionRangeMeters { get; set; }
    }

    public partial class MegaEvoSettings
    {
        [JsonProperty("evolutionLengthMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? EvolutionLengthMs { get; set; }

        [JsonProperty("attackBoostFromMegaDifferentType", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttackBoostFromMegaDifferentType { get; set; }

        [JsonProperty("attackBoostFromMegaSameType", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttackBoostFromMegaSameType { get; set; }

        [JsonProperty("maxCandyHoardSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxCandyHoardSize { get; set; }

        [JsonProperty("enableBuddyWalkingMegaEnergyAward", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBuddyWalkingMegaEnergyAward { get; set; }

        [JsonProperty("activeMegaBonusCatchCandy", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveMegaBonusCatchCandy { get; set; }
    }

    public partial class MonodepthSettings
    {
        [JsonProperty("enableOcclusions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableOcclusions { get; set; }

        [JsonProperty("occlusionsDefaultOn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OcclusionsDefaultOn { get; set; }

        [JsonProperty("occlusionsToggleVisible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OcclusionsToggleVisible { get; set; }

        [JsonProperty("enableGroundSuppression", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableGroundSuppression { get; set; }

        [JsonProperty("minGroundSuppressionThresh", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinGroundSuppressionThresh { get; set; }

        [JsonProperty("suppressionChannelId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SuppressionChannelId { get; set; }
    }

    public partial class MoveSequenceSettings
    {
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sequence { get; set; }
    }

    public partial class MoveSettings
    {
        [JsonProperty("movementId", NullValueHandling = NullValueHandling.Ignore)]
        public string MovementId { get; set; }

        [JsonProperty("animationId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AnimationId { get; set; }

        [JsonProperty("pokemonType", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? PokemonType { get; set; }

        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public long? Power { get; set; }

        [JsonProperty("accuracyChance", NullValueHandling = NullValueHandling.Ignore)]
        public long? AccuracyChance { get; set; }

        [JsonProperty("criticalChance", NullValueHandling = NullValueHandling.Ignore)]
        public double? CriticalChance { get; set; }

        [JsonProperty("staminaLossScalar", NullValueHandling = NullValueHandling.Ignore)]
        public double? StaminaLossScalar { get; set; }

        [JsonProperty("trainerLevelMin", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrainerLevelMin { get; set; }

        [JsonProperty("trainerLevelMax", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrainerLevelMax { get; set; }

        [JsonProperty("vfxName", NullValueHandling = NullValueHandling.Ignore)]
        public string VfxName { get; set; }

        [JsonProperty("durationMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? DurationMs { get; set; }

        [JsonProperty("damageWindowStartMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? DamageWindowStartMs { get; set; }

        [JsonProperty("damageWindowEndMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? DamageWindowEndMs { get; set; }

        [JsonProperty("energyDelta", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyDelta { get; set; }

        [JsonProperty("healScalar", NullValueHandling = NullValueHandling.Ignore)]
        public double? HealScalar { get; set; }

        [JsonProperty("isLocked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocked { get; set; }
    }

    public partial class NewsFeedClientSettings
    {
        [JsonProperty("isNewsFeedPollingEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNewsFeedPollingEnabled { get; set; }

        [JsonProperty("getNewsFeedPollingRateMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public long? GetNewsFeedPollingRateMinutes { get; set; }
    }

    public partial class OnboardingV2Settings
    {
        [JsonProperty("pokedexId", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PokedexId { get; set; }

        [JsonProperty("eggKmUntilHatch", NullValueHandling = NullValueHandling.Ignore)]
        public long? EggKmUntilHatch { get; set; }
    }

    public partial class PartyRecommendationSettings
    {
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        [JsonProperty("variance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Variance { get; set; }

        [JsonProperty("thirdMoveWeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ThirdMoveWeight { get; set; }

        [JsonProperty("megaEvoCombatRatingScale", NullValueHandling = NullValueHandling.Ignore)]
        public double? MegaEvoCombatRatingScale { get; set; }
    }

    public partial class PlatypusRolloutSettings
    {
        [JsonProperty("buddyV2MinPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyV2MinPlayerLevel { get; set; }

        [JsonProperty("buddyMultiplayerMinPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyMultiplayerMinPlayerLevel { get; set; }
    }

    public partial class PlayerLevel
    {
        [JsonProperty("rankNum", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> RankNum { get; set; }

        [JsonProperty("requiredExperience", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> RequiredExperience { get; set; }

        [JsonProperty("cpMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> CpMultiplier { get; set; }

        [JsonProperty("maxEggPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxEggPlayerLevel { get; set; }

        [JsonProperty("maxEncounterPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxEncounterPlayerLevel { get; set; }

        [JsonProperty("maxQuestEncounterPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxQuestEncounterPlayerLevel { get; set; }
    }

    public partial class PokedexCategoriesSettings
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("pokedexCategoryData", NullValueHandling = NullValueHandling.Ignore)]
        public List<PokedexCategoryDatum> PokedexCategoryData { get; set; }
    }

    public partial class PokedexCategoryDatum
    {
        [JsonProperty("pokedexCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string PokedexCategory { get; set; }

        [JsonProperty("requirementsToUnlock", NullValueHandling = NullValueHandling.Ignore)]
        public long? RequirementsToUnlock { get; set; }
    }

    public partial class PokemonFamily
    {
        [JsonProperty("familyId", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyId { get; set; }

        [JsonProperty("candyPerXlCandy", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyPerXlCandy { get; set; }

        [JsonProperty("megaEvolvablePokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public string MegaEvolvablePokemonId { get; set; }
    }

    public partial class PokemonHomeEnergyCosts
    {
        [JsonProperty("pokemonClass", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonClass? PokemonClass { get; set; }

        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public long? Base { get; set; }

        [JsonProperty("shiny", NullValueHandling = NullValueHandling.Ignore)]
        public long? Shiny { get; set; }

        [JsonProperty("cp1001To2000", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cp1001To2000 { get; set; }

        [JsonProperty("cp2001ToInf", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cp2001ToInf { get; set; }
    }

    public partial class PokemonHomeFormReversions
    {
        [JsonProperty("pokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonId { get; set; }

        [JsonProperty("formMapping", NullValueHandling = NullValueHandling.Ignore)]
        public List<FormMapping> FormMapping { get; set; }
    }

    public partial class FormMapping
    {
        [JsonProperty("revertedForm", NullValueHandling = NullValueHandling.Ignore)]
        public string RevertedForm { get; set; }

        [JsonProperty("unauthorizedForms", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnauthorizedForms { get; set; }

        [JsonProperty("revertedFormString", NullValueHandling = NullValueHandling.Ignore)]
        public string RevertedFormString { get; set; }
    }

    public partial class PokemonHomeSettings
    {
        [JsonProperty("playerMinLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayerMinLevel { get; set; }

        [JsonProperty("transporterMaxEnergy", NullValueHandling = NullValueHandling.Ignore)]
        public long? TransporterMaxEnergy { get; set; }

        [JsonProperty("energySkuId", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergySkuId { get; set; }

        [JsonProperty("transporterEnergyGainPerHour", NullValueHandling = NullValueHandling.Ignore)]
        public long? TransporterEnergyGainPerHour { get; set; }
    }

    public partial class PokemonScaleSettings
    {
        [JsonProperty("pokemonScaleMode", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonScaleMode { get; set; }

        [JsonProperty("minHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinHeight { get; set; }

        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxHeight { get; set; }
    }

    public partial class PokemonSettings
    {
        [JsonProperty("pokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonId { get; set; }

        [JsonProperty("modelScale", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModelScale { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }

        [JsonProperty("type2", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type2 { get; set; }

        [JsonProperty("camera", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonSettingsCamera Camera { get; set; }

        [JsonProperty("encounter", NullValueHandling = NullValueHandling.Ignore)]
        public Encounter Encounter { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stats Stats { get; set; }

        [JsonProperty("quickMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuickMoves { get; set; }

        [JsonProperty("cinematicMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CinematicMoves { get; set; }

        [JsonProperty("animationTime", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> AnimationTime { get; set; }

        [JsonProperty("evolutionIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EvolutionIds { get; set; }

        [JsonProperty("evolutionPips", NullValueHandling = NullValueHandling.Ignore)]
        public long? EvolutionPips { get; set; }

        [JsonProperty("pokedexHeightM", NullValueHandling = NullValueHandling.Ignore)]
        public double? PokedexHeightM { get; set; }

        [JsonProperty("pokedexWeightKg", NullValueHandling = NullValueHandling.Ignore)]
        public double? PokedexWeightKg { get; set; }

        [JsonProperty("heightStdDev", NullValueHandling = NullValueHandling.Ignore)]
        public double? HeightStdDev { get; set; }

        [JsonProperty("weightStdDev", NullValueHandling = NullValueHandling.Ignore)]
        public double? WeightStdDev { get; set; }

        [JsonProperty("familyId", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyId { get; set; }

        [JsonProperty("candyToEvolve", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyToEvolve { get; set; }

        [JsonProperty("kmBuddyDistance", NullValueHandling = NullValueHandling.Ignore)]
        public long? KmBuddyDistance { get; set; }

        [JsonProperty("modelHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModelHeight { get; set; }

        [JsonProperty("evolutionBranch", NullValueHandling = NullValueHandling.Ignore)]
        public List<EvolutionBranch> EvolutionBranch { get; set; }

        [JsonProperty("modelScaleV2", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModelScaleV2 { get; set; }

        [JsonProperty("buddyOffsetMale", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> BuddyOffsetMale { get; set; }

        [JsonProperty("buddyOffsetFemale", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> BuddyOffsetFemale { get; set; }

        [JsonProperty("buddyScale", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyScale { get; set; }

        [JsonProperty("thirdMove", NullValueHandling = NullValueHandling.Ignore)]
        public ThirdMove ThirdMove { get; set; }

        [JsonProperty("isTransferable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTransferable { get; set; }

        [JsonProperty("isDeployable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeployable { get; set; }

        [JsonProperty("isTradable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTradable { get; set; }

        [JsonProperty("shadow", NullValueHandling = NullValueHandling.Ignore)]
        public Shadow Shadow { get; set; }

        [JsonProperty("buddyGroupNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyGroupNumber { get; set; }

        [JsonProperty("buddyWalkedMegaEnergyAward", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyWalkedMegaEnergyAward { get; set; }

        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public string Form { get; set; }

        [JsonProperty("disableTransferToPokemonHome", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableTransferToPokemonHome { get; set; }

        [JsonProperty("parentPokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentPokemonId { get; set; }

        [JsonProperty("buddySize", NullValueHandling = NullValueHandling.Ignore)]
        public BuddySize? BuddySize { get; set; }

        [JsonProperty("combatShoulderCameraAngle", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> CombatShoulderCameraAngle { get; set; }

        [JsonProperty("combatDefaultCameraAngle", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> CombatDefaultCameraAngle { get; set; }

        [JsonProperty("combatPlayerFocusCameraAngle", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> CombatPlayerFocusCameraAngle { get; set; }

        [JsonProperty("eliteCinematicMove", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EliteCinematicMove { get; set; }

        [JsonProperty("tempEvoOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<TempEvoOverride> TempEvoOverrides { get; set; }

        [JsonProperty("eliteQuickMove", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EliteQuickMove { get; set; }

        [JsonProperty("buddyPortraitOffset", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> BuddyPortraitOffset { get; set; }

        [JsonProperty("raidBossDistanceOffset", NullValueHandling = NullValueHandling.Ignore)]
        public double? RaidBossDistanceOffset { get; set; }

        [JsonProperty("combatPlayerPokemonPositionOffset", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> CombatPlayerPokemonPositionOffset { get; set; }

        [JsonProperty("pokemonClass", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonClass? PokemonClass { get; set; }

        [JsonProperty("combatOpponentFocusCameraAngle", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> CombatOpponentFocusCameraAngle { get; set; }

        [JsonProperty("formChange", NullValueHandling = NullValueHandling.Ignore)]
        public List<FormChange> FormChange { get; set; }

        [JsonProperty("obPokemonSetting", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> ObPokemonSetting { get; set; }
    }

    public partial class PokemonSettingsCamera
    {
        [JsonProperty("diskRadiusM", NullValueHandling = NullValueHandling.Ignore)]
        public double? DiskRadiusM { get; set; }

        [JsonProperty("cylinderRadiusM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CylinderRadiusM { get; set; }

        [JsonProperty("cylinderHeightM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CylinderHeightM { get; set; }

        [JsonProperty("shoulderModeScale", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShoulderModeScale { get; set; }

        [JsonProperty("cylinderGroundM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CylinderGroundM { get; set; }
    }

    public partial class Encounter
    {
        [JsonProperty("baseCaptureRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? BaseCaptureRate { get; set; }

        [JsonProperty("baseFleeRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? BaseFleeRate { get; set; }

        [JsonProperty("collisionRadiusM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CollisionRadiusM { get; set; }

        [JsonProperty("collisionHeightM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CollisionHeightM { get; set; }

        [JsonProperty("collisionHeadRadiusM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CollisionHeadRadiusM { get; set; }

        [JsonProperty("movementType", NullValueHandling = NullValueHandling.Ignore)]
        public MovementType? MovementType { get; set; }

        [JsonProperty("movementTimerS", NullValueHandling = NullValueHandling.Ignore)]
        public long? MovementTimerS { get; set; }

        [JsonProperty("jumpTimeS", NullValueHandling = NullValueHandling.Ignore)]
        public double? JumpTimeS { get; set; }

        [JsonProperty("attackTimerS", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackTimerS { get; set; }

        [JsonProperty("attackProbability", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttackProbability { get; set; }

        [JsonProperty("dodgeProbability", NullValueHandling = NullValueHandling.Ignore)]
        public double? DodgeProbability { get; set; }

        [JsonProperty("dodgeDurationS", NullValueHandling = NullValueHandling.Ignore)]
        public double? DodgeDurationS { get; set; }

        [JsonProperty("dodgeDistance", NullValueHandling = NullValueHandling.Ignore)]
        public double? DodgeDistance { get; set; }

        [JsonProperty("cameraDistance", NullValueHandling = NullValueHandling.Ignore)]
        public double? CameraDistance { get; set; }

        [JsonProperty("minPokemonActionFrequencyS", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinPokemonActionFrequencyS { get; set; }

        [JsonProperty("maxPokemonActionFrequencyS", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxPokemonActionFrequencyS { get; set; }

        [JsonProperty("shadowFormBaseCaptureRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShadowFormBaseCaptureRate { get; set; }

        [JsonProperty("shadowFormAttackProbability", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShadowFormAttackProbability { get; set; }

        [JsonProperty("shadowFormDodgeProbability", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShadowFormDodgeProbability { get; set; }

        [JsonProperty("bonusCandyCaptureReward", NullValueHandling = NullValueHandling.Ignore)]
        public long? BonusCandyCaptureReward { get; set; }

        [JsonProperty("bonusStardustCaptureReward", NullValueHandling = NullValueHandling.Ignore)]
        public long? BonusStardustCaptureReward { get; set; }

        [JsonProperty("bonusXlCandyCaptureReward", NullValueHandling = NullValueHandling.Ignore)]
        public long? BonusXlCandyCaptureReward { get; set; }
    }

    public partial class EvolutionBranch
    {
        [JsonProperty("evolution", NullValueHandling = NullValueHandling.Ignore)]
        public string Evolution { get; set; }

        [JsonProperty("candyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyCost { get; set; }

        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public string Form { get; set; }

        [JsonProperty("purificationEvolutionCandyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurificationEvolutionCandyCost { get; set; }

        [JsonProperty("temporaryEvolution", NullValueHandling = NullValueHandling.Ignore)]
        public Temp? TemporaryEvolution { get; set; }

        [JsonProperty("temporaryEvolutionEnergyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? TemporaryEvolutionEnergyCost { get; set; }

        [JsonProperty("temporaryEvolutionEnergyCostSubsequent", NullValueHandling = NullValueHandling.Ignore)]
        public long? TemporaryEvolutionEnergyCostSubsequent { get; set; }

        [JsonProperty("evolutionItemRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public EvolutionItemRequirement? EvolutionItemRequirement { get; set; }

        [JsonProperty("noCandyCostViaTrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoCandyCostViaTrade { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public long? Priority { get; set; }

        [JsonProperty("questDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public List<QuestDisplay> QuestDisplay { get; set; }

        [JsonProperty("lureItemRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public string LureItemRequirement { get; set; }

        [JsonProperty("kmBuddyDistanceRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public long? KmBuddyDistanceRequirement { get; set; }

        [JsonProperty("mustBeBuddy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MustBeBuddy { get; set; }

        [JsonProperty("onlyDaytime", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDaytime { get; set; }

        [JsonProperty("onlyNighttime", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyNighttime { get; set; }

        [JsonProperty("genderRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public GenderRequirement? GenderRequirement { get; set; }

        [JsonProperty("onlyUpsideDown", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyUpsideDown { get; set; }
    }

    public partial class QuestDisplay
    {
        [JsonProperty("questRequirementTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestRequirementTemplateId { get; set; }
    }

    public partial class FormChange
    {
        [JsonProperty("availableForm", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailableForm> AvailableForm { get; set; }

        [JsonProperty("candyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyCost { get; set; }

        [JsonProperty("stardustCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? StardustCost { get; set; }
    }

    public partial class Shadow
    {
        [JsonProperty("purificationStardustNeeded", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurificationStardustNeeded { get; set; }

        [JsonProperty("purificationCandyNeeded", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurificationCandyNeeded { get; set; }

        [JsonProperty("purifiedChargeMove", NullValueHandling = NullValueHandling.Ignore)]
        public PurifiedChargeMove? PurifiedChargeMove { get; set; }

        [JsonProperty("shadowChargeMove", NullValueHandling = NullValueHandling.Ignore)]
        public ShadowChargeMove? ShadowChargeMove { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("baseStamina", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseStamina { get; set; }

        [JsonProperty("baseAttack", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseAttack { get; set; }

        [JsonProperty("baseDefense", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseDefense { get; set; }
    }

    public partial class TempEvoOverride
    {
        [JsonProperty("tempEvoId", NullValueHandling = NullValueHandling.Ignore)]
        public Temp? TempEvoId { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stats Stats { get; set; }

        [JsonProperty("averageHeightM", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageHeightM { get; set; }

        [JsonProperty("averageWeightKg", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageWeightKg { get; set; }

        [JsonProperty("typeOverride", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? TypeOverride { get; set; }

        [JsonProperty("typeOverride2", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? TypeOverride2 { get; set; }

        [JsonProperty("camera", NullValueHandling = NullValueHandling.Ignore)]
        public TempEvoOverrideCamera Camera { get; set; }

        [JsonProperty("modelScaleV2", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModelScaleV2 { get; set; }

        [JsonProperty("modelHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ModelHeight { get; set; }

        [JsonProperty("buddyOffsetMale", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> BuddyOffsetMale { get; set; }

        [JsonProperty("buddyOffsetFemale", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> BuddyOffsetFemale { get; set; }

        [JsonProperty("buddyPortraitOffset", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> BuddyPortraitOffset { get; set; }
    }

    public partial class TempEvoOverrideCamera
    {
        [JsonProperty("cylinderRadiusM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CylinderRadiusM { get; set; }

        [JsonProperty("cylinderHeightM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CylinderHeightM { get; set; }

        [JsonProperty("cylinderGroundM", NullValueHandling = NullValueHandling.Ignore)]
        public double? CylinderGroundM { get; set; }
    }

    public partial class ThirdMove
    {
        [JsonProperty("stardustToUnlock", NullValueHandling = NullValueHandling.Ignore)]
        public long? StardustToUnlock { get; set; }

        [JsonProperty("candyToUnlock", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyToUnlock { get; set; }
    }

    public partial class PokemonTagSettings
    {
        [JsonProperty("minPlayerLevelForPokemonTagging", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinPlayerLevelForPokemonTagging { get; set; }

        [JsonProperty("colorBinding", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColorBinding> ColorBinding { get; set; }

        [JsonProperty("maxNumTagsAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxNumTagsAllowed { get; set; }
    }

    public partial class ColorBinding
    {
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty("hexCode", NullValueHandling = NullValueHandling.Ignore)]
        public string HexCode { get; set; }
    }

    public partial class PokemonUpgrades
    {
        [JsonProperty("upgradesPerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpgradesPerLevel { get; set; }

        [JsonProperty("allowedLevelsAbovePlayer", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllowedLevelsAbovePlayer { get; set; }

        [JsonProperty("candyCost", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> CandyCost { get; set; }

        [JsonProperty("stardustCost", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> StardustCost { get; set; }

        [JsonProperty("shadowStardustMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShadowStardustMultiplier { get; set; }

        [JsonProperty("shadowCandyMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? ShadowCandyMultiplier { get; set; }

        [JsonProperty("purifiedStardustMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? PurifiedStardustMultiplier { get; set; }

        [JsonProperty("purifiedCandyMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? PurifiedCandyMultiplier { get; set; }

        [JsonProperty("maxNormalUpgradeLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxNormalUpgradeLevel { get; set; }

        [JsonProperty("defaultCpBoostAdditionalLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefaultCpBoostAdditionalLevel { get; set; }

        [JsonProperty("xlCandyMinPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? XlCandyMinPlayerLevel { get; set; }

        [JsonProperty("xlCandyCost", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> XlCandyCost { get; set; }
    }

    public partial class PokestopInvasionAvailabilitySettings
    {
        [JsonProperty("availabilityStartMinute", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? AvailabilityStartMinute { get; set; }

        [JsonProperty("availabilityEndMinute", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? AvailabilityEndMinute { get; set; }
    }

    public partial class PostcardCollectionSettings
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
    }

    public partial class PowerUpPokestopSharedSettings
    {
        [JsonProperty("minPlayerLevelForScanning", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinPlayerLevelForScanning { get; set; }

        [JsonProperty("pointsMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointsMultiplier { get; set; }
    }

    public partial class PushGatewaySettings
    {
        [JsonProperty("obInt321", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObInt321 { get; set; }

        [JsonProperty("obInt322", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObInt322 { get; set; }
    }

    public partial class QuestEvolutionSettings
    {
        [JsonProperty("enableQuestEvolutions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQuestEvolutions { get; set; }

        [JsonProperty("enableWalkingQuestEvolutions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWalkingQuestEvolutions { get; set; }
    }

    public partial class QuestSettings
    {
        [JsonProperty("questType", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestType { get; set; }

        [JsonProperty("dailyQuest", NullValueHandling = NullValueHandling.Ignore)]
        public DailyQuest DailyQuest { get; set; }
    }

    public partial class DailyQuest
    {
        [JsonProperty("bucketsPerDay", NullValueHandling = NullValueHandling.Ignore)]
        public long? BucketsPerDay { get; set; }

        [JsonProperty("streakLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? StreakLength { get; set; }

        [JsonProperty("bonusMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public long? BonusMultiplier { get; set; }

        [JsonProperty("streakBonusMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public long? StreakBonusMultiplier { get; set; }
    }

    public partial class RaidSettings
    {
        [JsonProperty("remoteRaidEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoteRaidEnabled { get; set; }

        [JsonProperty("maxRemoteRaidPasses", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxRemoteRaidPasses { get; set; }

        [JsonProperty("remoteDamageModifier", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemoteDamageModifier { get; set; }

        [JsonProperty("remoteRaidsMinPlayerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemoteRaidsMinPlayerLevel { get; set; }

        [JsonProperty("maxNumFriendInvites", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxNumFriendInvites { get; set; }

        [JsonProperty("friendInviteCutoffTimeSec", NullValueHandling = NullValueHandling.Ignore)]
        public long? FriendInviteCutoffTimeSec { get; set; }

        [JsonProperty("canInviteFriendsInPerson", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanInviteFriendsInPerson { get; set; }

        [JsonProperty("canInviteFriendsRemotely", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanInviteFriendsRemotely { get; set; }

        [JsonProperty("maxPlayersPerLobby", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxPlayersPerLobby { get; set; }

        [JsonProperty("maxRemotePlayersPerLobby", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxRemotePlayersPerLobby { get; set; }

        [JsonProperty("inviteCooldownDurationMillis", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? InviteCooldownDurationMillis { get; set; }

        [JsonProperty("maxNumFriendInvitesPerAction", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxNumFriendInvitesPerAction { get; set; }
    }

    public partial class RecommendedSearchSettings
    {
        [JsonProperty("searchLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchLabel { get; set; }

        [JsonProperty("appendedSearchString", NullValueHandling = NullValueHandling.Ignore)]
        public string AppendedSearchString { get; set; }

        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }
    }

    public partial class ReferralSettings
    {
        [JsonProperty("featureEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FeatureEnabled { get; set; }

        [JsonProperty("recentFeatures", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecentFeature> RecentFeatures { get; set; }

        [JsonProperty("addReferrerGracePeriodMs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? AddReferrerGracePeriodMs { get; set; }

        [JsonProperty("minNumDaysWithoutSessionForLapsedPlayer", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinNumDaysWithoutSessionForLapsedPlayer { get; set; }

        [JsonProperty("referralLinkUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferralLinkUrl { get; set; }
    }

    public partial class RecentFeature
    {
        [JsonProperty("iconType", NullValueHandling = NullValueHandling.Ignore)]
        public string IconType { get; set; }

        [JsonProperty("featureName", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureName { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class SharedMoveSettings
    {
        [JsonProperty("staPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? StaPercent { get; set; }

        [JsonProperty("atkPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? AtkPercent { get; set; }

        [JsonProperty("defPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double? DefPercent { get; set; }

        [JsonProperty("durationS", NullValueHandling = NullValueHandling.Ignore)]
        public double? DurationS { get; set; }
    }

    public partial class SmeargleMovesSettings
    {
        [JsonProperty("quickMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuickMoves { get; set; }

        [JsonProperty("cinematicMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CinematicMoves { get; set; }
    }

    public partial class SponsoredGeofenceGiftSettings
    {
        [JsonProperty("giftPersistenceTimeMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? GiftPersistenceTimeMs { get; set; }

        [JsonProperty("mapPresentationTimeMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? MapPresentationTimeMs { get; set; }

        [JsonProperty("enableSponsoredGeofenceGift", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSponsoredGeofenceGift { get; set; }

        [JsonProperty("fullscreenDisableExitButtonTimeMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? FullscreenDisableExitButtonTimeMs { get; set; }

        [JsonProperty("balloonGiftSettings", NullValueHandling = NullValueHandling.Ignore)]
        public BalloonGiftSettings BalloonGiftSettings { get; set; }
    }

    public partial class BalloonGiftSettings
    {
        [JsonProperty("enableBalloonGift", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBalloonGift { get; set; }

        [JsonProperty("balloonAutoDismissTimeMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? BalloonAutoDismissTimeMs { get; set; }

        [JsonProperty("getWasabiAdRpcIntervalMs", NullValueHandling = NullValueHandling.Ignore)]
        public long? GetWasabiAdRpcIntervalMs { get; set; }
    }

    public partial class StickerMetadata
    {
        [JsonProperty("stickerId", NullValueHandling = NullValueHandling.Ignore)]
        public string StickerId { get; set; }

        [JsonProperty("stickerUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri StickerUrl { get; set; }

        [JsonProperty("maxCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxCount { get; set; }
    }

    public partial class SurveySettings
    {
        [JsonProperty("obSurveySettingsInt32", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObSurveySettingsInt32 { get; set; }
    }

    public partial class TemporaryEvolutionSettings
    {
        [JsonProperty("pokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonId { get; set; }

        [JsonProperty("temporaryEvolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemporaryEvolution> TemporaryEvolutions { get; set; }
    }

    public partial class TemporaryEvolution
    {
        [JsonProperty("temporaryEvolutionId", NullValueHandling = NullValueHandling.Ignore)]
        public Temp? TemporaryEvolutionId { get; set; }

        [JsonProperty("assetBundleValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? AssetBundleValue { get; set; }
    }

    public partial class TutorialsSettings
    {
        [JsonProperty("tutorialSettingsBool5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TutorialSettingsBool5 { get; set; }

        [JsonProperty("tutorialSettingsBool11", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TutorialSettingsBool11 { get; set; }

        [JsonProperty("tutorialCompleteReward", NullValueHandling = NullValueHandling.Ignore)]
        public List<TutorialCompleteReward> TutorialCompleteReward { get; set; }
    }

    public partial class TutorialCompleteReward
    {
        [JsonProperty("tutorialCompletation", NullValueHandling = NullValueHandling.Ignore)]
        public string TutorialCompletation { get; set; }

        [JsonProperty("itemReward", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemReward> ItemReward { get; set; }
    }

    public partial class ItemReward
    {
        [JsonProperty("itemId", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }
    }

    public partial class TypeEffective
    {
        [JsonProperty("attackScalar", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> AttackScalar { get; set; }

        [JsonProperty("attackType", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? AttackType { get; set; }
    }

    public partial class UsernameSuggestionSettings
    {
        [JsonProperty("obEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObEnabled { get; set; }

        [JsonProperty("obUsernameSuggestionInt321", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObUsernameSuggestionInt321 { get; set; }

        [JsonProperty("obUsernameSuggestionInt322", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObUsernameSuggestionInt322 { get; set; }
    }

    public partial class VsSeekerClientSettings
    {
        [JsonProperty("allowedVsSeekerLeagueTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedVsSeekerLeagueTemplateId { get; set; }
    }

    public partial class VsSeekerLoot
    {
        [JsonProperty("rankLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? RankLevel { get; set; }

        [JsonProperty("reward", NullValueHandling = NullValueHandling.Ignore)]
        public List<Reward> Reward { get; set; }

        [JsonProperty("rewardTrack", NullValueHandling = NullValueHandling.Ignore)]
        public RewardTrack? RewardTrack { get; set; }
    }

    public partial class Reward
    {
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public RewardItem Item { get; set; }

        [JsonProperty("itemLootTable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItemLootTable { get; set; }

        [JsonProperty("pokemonReward", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PokemonReward { get; set; }
    }

    public partial class RewardItem
    {
        [JsonProperty("stardust", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stardust { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public ItemEnum? Item { get; set; }
    }

    public partial class VsSeekerPokemonRewards
    {
        [JsonProperty("availablePokemon", NullValueHandling = NullValueHandling.Ignore)]
        public List<VsSeekerPokemonRewardsAvailablePokemon> AvailablePokemon { get; set; }

        [JsonProperty("rewardTrack", NullValueHandling = NullValueHandling.Ignore)]
        public RewardTrack? RewardTrack { get; set; }
    }

    public partial class VsSeekerPokemonRewardsAvailablePokemon
    {
        [JsonProperty("guaranteedLimitedPokemonReward", NullValueHandling = NullValueHandling.Ignore)]
        public GuaranteedLimitedPokemonReward GuaranteedLimitedPokemonReward { get; set; }

        [JsonProperty("unlockedAtRank", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnlockedAtRank { get; set; }

        [JsonProperty("attackIvOverride", NullValueHandling = NullValueHandling.Ignore)]
        public IvOverride AttackIvOverride { get; set; }

        [JsonProperty("defenseIvOverride", NullValueHandling = NullValueHandling.Ignore)]
        public IvOverride DefenseIvOverride { get; set; }

        [JsonProperty("staminaIvOverride", NullValueHandling = NullValueHandling.Ignore)]
        public IvOverride StaminaIvOverride { get; set; }

        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public GuaranteedLimitedPokemonRewardPokemon Pokemon { get; set; }
    }

    public partial class IvOverride
    {
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public Range Range { get; set; }
    }

    public partial class Range
    {
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public long? Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public long? Max { get; set; }
    }

    public partial class GuaranteedLimitedPokemonReward
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public GuaranteedLimitedPokemonRewardPokemon Pokemon { get; set; }

        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        [JsonProperty("perCompetitiveCombatSeasonMaxCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PerCompetitiveCombatSeasonMaxCount { get; set; }

        [JsonProperty("lifetimeMaxCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? LifetimeMaxCount { get; set; }
    }

    public partial class GuaranteedLimitedPokemonRewardPokemon
    {
        [JsonProperty("pokemonId", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonId { get; set; }

        [JsonProperty("pokemonDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public PokemonDisplay PokemonDisplay { get; set; }
    }

    public partial class WeatherAffinities
    {
        [JsonProperty("weatherCondition", NullValueHandling = NullValueHandling.Ignore)]
        public string WeatherCondition { get; set; }

        [JsonProperty("pokemonType", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeElement> PokemonType { get; set; }
    }

    public partial class WeatherBonusSettings
    {
        [JsonProperty("cpBaseLevelBonus", NullValueHandling = NullValueHandling.Ignore)]
        public long? CpBaseLevelBonus { get; set; }

        [JsonProperty("guaranteedIndividualValues", NullValueHandling = NullValueHandling.Ignore)]
        public long? GuaranteedIndividualValues { get; set; }

        [JsonProperty("stardustBonusMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? StardustBonusMultiplier { get; set; }

        [JsonProperty("attackBonusMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttackBonusMultiplier { get; set; }

        [JsonProperty("raidEncounterCpBaseLevelBonus", NullValueHandling = NullValueHandling.Ignore)]
        public long? RaidEncounterCpBaseLevelBonus { get; set; }

        [JsonProperty("raidEncounterGuaranteedIndividualValues", NullValueHandling = NullValueHandling.Ignore)]
        public long? RaidEncounterGuaranteedIndividualValues { get; set; }
    }

    public enum AvatarType { PlayerAvatarFemale };

    public enum Name { GroupBackpack, GroupBelt, GroupEyes, GroupFace, GroupGlasses, GroupGloves, GroupHair, GroupHalloween, GroupHat, GroupNecklace, GroupOutfits, GroupPants, GroupPoses, GroupSeasonal, GroupShirt, GroupShoes, GroupSkin, GroupSocks, GroupSponsor, GroupUniqlo };

    public enum Slot { Backpack, Belt, Eyes, Face, Glasses, Gloves, Hair, Hat, Necklace, Pants, Pose, Shirt, Shoes, Skin, Socks };

    public enum UnlockType { Default, IapClothing, LevelReward };

    public enum Interpolation { CamInterpCut, CamInterpLinear };

    public enum TargetType { CamTargetAttacker, CamTargetAttackerDefender, CamTargetAttackerDefenderEdge, CamTargetAttackerDefenderMirror, CamTargetAttackerDefenderWorld, CamTargetAttackerEdge, CamTargetAttackerGround, CamTargetDefender, CamTargetDefenderAttacker, CamTargetDefenderAttackerEdge, CamTargetDefenderEdge, CamTargetDefenderGround, CamTargetShoulderAttackerDefender, CamTargetShoulderAttackerDefenderMirror };

    public enum BadgeType { BadgeGreatLeague, BadgeMasterLeague, BadgeUltraLeague };

    public enum CombatLeagueTemplateId { CombatLeagueDefaultGreat, CombatLeagueDefaultMaster, CombatLeagueDefaultUltra };

    public enum LeagueType { Premier, Standard };

    public enum PokemonConditionType { PokemonBanlist, PokemonCaughtTimestamp, PokemonLevelRange, PokemonWhitelist, WithPokemonCpLimit, WithPokemonType, WithUniquePokemon };

    public enum TypeElement { PokemonTypeBug, PokemonTypeDark, PokemonTypeDragon, PokemonTypeElectric, PokemonTypeFairy, PokemonTypeFighting, PokemonTypeFire, PokemonTypeFlying, PokemonTypeGhost, PokemonTypeGrass, PokemonTypeGround, PokemonTypeIce, PokemonTypeNormal, PokemonTypePoison, PokemonTypePsychic, PokemonTypeRock, PokemonTypeSteel, PokemonTypeWater };

    public enum BackdropImageBundle { CombatBlancheBackdrop, CombatCandelaBackdrop, CombatSparkBackdrop };

    public enum Context { EvolutionQuest };

    public enum Category { IapCategoryBundle, IapCategoryFree, IapCategoryGlobalEventTicket, IapCategoryItems, IapCategorySticker, IapCategoryTransporterEnergy };

    public enum PokemonClass { PokemonClassLegendary, PokemonClassMythic };

    public enum BuddySize { BuddyBaby, BuddyBig, BuddyFlying, BuddyShoulder };

    public enum MovementType { MovementElectric, MovementFlying, MovementHovering, MovementJump, MovementPsychic };

    public enum EvolutionItemRequirement { ItemDragonScale, ItemGen4EvolutionStone, ItemGen5EvolutionStone, ItemKingsRock, ItemMetalCoat, ItemSunStone, ItemUpGrade };

    public enum GenderRequirement { Female, Male };

    public enum Temp { TempEvolutionMega, TempEvolutionMegaX, TempEvolutionMegaY };

    public enum AvailableForm { FurfrouDandy, FurfrouDiamond, FurfrouLaReine, FurfrouMatron, FurfrouNatural };

    public enum PurifiedChargeMove { Return };

    public enum ShadowChargeMove { Frustration };

    public enum ItemEnum { ItemMoveRerollSpecialAttack, ItemRareCandy };

    public enum RewardTrack { VsSeekerRewardTrackPremium };

    public partial struct ItemId
    {
        public long? Integer;
        public string String;

        public static implicit operator ItemId(long Integer) => new ItemId { Integer = Integer };
        public static implicit operator ItemId(string String) => new ItemId { String = String };
    }

    public partial class PokemonGameMaster
    {
        public static PokemonGameMaster FromJson(string json) => JsonConvert.DeserializeObject<PokemonGameMaster>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PokemonGameMaster self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AvatarTypeConverter.Singleton,
                NameConverter.Singleton,
                SlotConverter.Singleton,
                UnlockTypeConverter.Singleton,
                InterpolationConverter.Singleton,
                TargetTypeConverter.Singleton,
                BadgeTypeConverter.Singleton,
                CombatLeagueTemplateIdConverter.Singleton,
                LeagueTypeConverter.Singleton,
                PokemonConditionTypeConverter.Singleton,
                TypeElementConverter.Singleton,
                BackdropImageBundleConverter.Singleton,
                ContextConverter.Singleton,
                CategoryConverter.Singleton,
                ItemIdConverter.Singleton,
                PokemonClassConverter.Singleton,
                BuddySizeConverter.Singleton,
                MovementTypeConverter.Singleton,
                EvolutionItemRequirementConverter.Singleton,
                GenderRequirementConverter.Singleton,
                TempConverter.Singleton,
                AvailableFormConverter.Singleton,
                PurifiedChargeMoveConverter.Singleton,
                ShadowChargeMoveConverter.Singleton,
                ItemEnumConverter.Singleton,
                RewardTrackConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AvatarTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AvatarType) || t == typeof(AvatarType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "PLAYER_AVATAR_FEMALE")
            {
                return AvatarType.PlayerAvatarFemale;
            }
            throw new Exception("Cannot unmarshal type AvatarType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AvatarType)untypedValue;
            if (value == AvatarType.PlayerAvatarFemale)
            {
                serializer.Serialize(writer, "PLAYER_AVATAR_FEMALE");
                return;
            }
            throw new Exception("Cannot marshal type AvatarType");
        }

        public static readonly AvatarTypeConverter Singleton = new AvatarTypeConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "group_backpack":
                    return Name.GroupBackpack;
                case "group_belt":
                    return Name.GroupBelt;
                case "group_eyes":
                    return Name.GroupEyes;
                case "group_face":
                    return Name.GroupFace;
                case "group_glasses":
                    return Name.GroupGlasses;
                case "group_gloves":
                    return Name.GroupGloves;
                case "group_hair":
                    return Name.GroupHair;
                case "group_halloween":
                    return Name.GroupHalloween;
                case "group_hat":
                    return Name.GroupHat;
                case "group_necklace":
                    return Name.GroupNecklace;
                case "group_outfits":
                    return Name.GroupOutfits;
                case "group_pants":
                    return Name.GroupPants;
                case "group_poses":
                    return Name.GroupPoses;
                case "group_seasonal":
                    return Name.GroupSeasonal;
                case "group_shirt":
                    return Name.GroupShirt;
                case "group_shoes":
                    return Name.GroupShoes;
                case "group_skin":
                    return Name.GroupSkin;
                case "group_socks":
                    return Name.GroupSocks;
                case "group_sponsor":
                    return Name.GroupSponsor;
                case "group_uniqlo":
                    return Name.GroupUniqlo;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.GroupBackpack:
                    serializer.Serialize(writer, "group_backpack");
                    return;
                case Name.GroupBelt:
                    serializer.Serialize(writer, "group_belt");
                    return;
                case Name.GroupEyes:
                    serializer.Serialize(writer, "group_eyes");
                    return;
                case Name.GroupFace:
                    serializer.Serialize(writer, "group_face");
                    return;
                case Name.GroupGlasses:
                    serializer.Serialize(writer, "group_glasses");
                    return;
                case Name.GroupGloves:
                    serializer.Serialize(writer, "group_gloves");
                    return;
                case Name.GroupHair:
                    serializer.Serialize(writer, "group_hair");
                    return;
                case Name.GroupHalloween:
                    serializer.Serialize(writer, "group_halloween");
                    return;
                case Name.GroupHat:
                    serializer.Serialize(writer, "group_hat");
                    return;
                case Name.GroupNecklace:
                    serializer.Serialize(writer, "group_necklace");
                    return;
                case Name.GroupOutfits:
                    serializer.Serialize(writer, "group_outfits");
                    return;
                case Name.GroupPants:
                    serializer.Serialize(writer, "group_pants");
                    return;
                case Name.GroupPoses:
                    serializer.Serialize(writer, "group_poses");
                    return;
                case Name.GroupSeasonal:
                    serializer.Serialize(writer, "group_seasonal");
                    return;
                case Name.GroupShirt:
                    serializer.Serialize(writer, "group_shirt");
                    return;
                case Name.GroupShoes:
                    serializer.Serialize(writer, "group_shoes");
                    return;
                case Name.GroupSkin:
                    serializer.Serialize(writer, "group_skin");
                    return;
                case Name.GroupSocks:
                    serializer.Serialize(writer, "group_socks");
                    return;
                case Name.GroupSponsor:
                    serializer.Serialize(writer, "group_sponsor");
                    return;
                case Name.GroupUniqlo:
                    serializer.Serialize(writer, "group_uniqlo");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class SlotConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Slot) || t == typeof(Slot?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BACKPACK":
                    return Slot.Backpack;
                case "BELT":
                    return Slot.Belt;
                case "EYES":
                    return Slot.Eyes;
                case "FACE":
                    return Slot.Face;
                case "GLASSES":
                    return Slot.Glasses;
                case "GLOVES":
                    return Slot.Gloves;
                case "HAIR":
                    return Slot.Hair;
                case "HAT":
                    return Slot.Hat;
                case "NECKLACE":
                    return Slot.Necklace;
                case "PANTS":
                    return Slot.Pants;
                case "POSE":
                    return Slot.Pose;
                case "SHIRT":
                    return Slot.Shirt;
                case "SHOES":
                    return Slot.Shoes;
                case "SKIN":
                    return Slot.Skin;
                case "SOCKS":
                    return Slot.Socks;
            }
            throw new Exception("Cannot unmarshal type Slot");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Slot)untypedValue;
            switch (value)
            {
                case Slot.Backpack:
                    serializer.Serialize(writer, "BACKPACK");
                    return;
                case Slot.Belt:
                    serializer.Serialize(writer, "BELT");
                    return;
                case Slot.Eyes:
                    serializer.Serialize(writer, "EYES");
                    return;
                case Slot.Face:
                    serializer.Serialize(writer, "FACE");
                    return;
                case Slot.Glasses:
                    serializer.Serialize(writer, "GLASSES");
                    return;
                case Slot.Gloves:
                    serializer.Serialize(writer, "GLOVES");
                    return;
                case Slot.Hair:
                    serializer.Serialize(writer, "HAIR");
                    return;
                case Slot.Hat:
                    serializer.Serialize(writer, "HAT");
                    return;
                case Slot.Necklace:
                    serializer.Serialize(writer, "NECKLACE");
                    return;
                case Slot.Pants:
                    serializer.Serialize(writer, "PANTS");
                    return;
                case Slot.Pose:
                    serializer.Serialize(writer, "POSE");
                    return;
                case Slot.Shirt:
                    serializer.Serialize(writer, "SHIRT");
                    return;
                case Slot.Shoes:
                    serializer.Serialize(writer, "SHOES");
                    return;
                case Slot.Skin:
                    serializer.Serialize(writer, "SKIN");
                    return;
                case Slot.Socks:
                    serializer.Serialize(writer, "SOCKS");
                    return;
            }
            throw new Exception("Cannot marshal type Slot");
        }

        public static readonly SlotConverter Singleton = new SlotConverter();
    }

    internal class UnlockTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UnlockType) || t == typeof(UnlockType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DEFAULT":
                    return UnlockType.Default;
                case "IAP_CLOTHING":
                    return UnlockType.IapClothing;
                case "LEVEL_REWARD":
                    return UnlockType.LevelReward;
            }
            throw new Exception("Cannot unmarshal type UnlockType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UnlockType)untypedValue;
            switch (value)
            {
                case UnlockType.Default:
                    serializer.Serialize(writer, "DEFAULT");
                    return;
                case UnlockType.IapClothing:
                    serializer.Serialize(writer, "IAP_CLOTHING");
                    return;
                case UnlockType.LevelReward:
                    serializer.Serialize(writer, "LEVEL_REWARD");
                    return;
            }
            throw new Exception("Cannot marshal type UnlockType");
        }

        public static readonly UnlockTypeConverter Singleton = new UnlockTypeConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class InterpolationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Interpolation) || t == typeof(Interpolation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CAM_INTERP_CUT":
                    return Interpolation.CamInterpCut;
                case "CAM_INTERP_LINEAR":
                    return Interpolation.CamInterpLinear;
            }
            throw new Exception("Cannot unmarshal type Interpolation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Interpolation)untypedValue;
            switch (value)
            {
                case Interpolation.CamInterpCut:
                    serializer.Serialize(writer, "CAM_INTERP_CUT");
                    return;
                case Interpolation.CamInterpLinear:
                    serializer.Serialize(writer, "CAM_INTERP_LINEAR");
                    return;
            }
            throw new Exception("Cannot marshal type Interpolation");
        }

        public static readonly InterpolationConverter Singleton = new InterpolationConverter();
    }

    internal class TargetTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TargetType) || t == typeof(TargetType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CAM_TARGET_ATTACKER":
                    return TargetType.CamTargetAttacker;
                case "CAM_TARGET_ATTACKER_DEFENDER":
                    return TargetType.CamTargetAttackerDefender;
                case "CAM_TARGET_ATTACKER_DEFENDER_EDGE":
                    return TargetType.CamTargetAttackerDefenderEdge;
                case "CAM_TARGET_ATTACKER_DEFENDER_MIRROR":
                    return TargetType.CamTargetAttackerDefenderMirror;
                case "CAM_TARGET_ATTACKER_DEFENDER_WORLD":
                    return TargetType.CamTargetAttackerDefenderWorld;
                case "CAM_TARGET_ATTACKER_EDGE":
                    return TargetType.CamTargetAttackerEdge;
                case "CAM_TARGET_ATTACKER_GROUND":
                    return TargetType.CamTargetAttackerGround;
                case "CAM_TARGET_DEFENDER":
                    return TargetType.CamTargetDefender;
                case "CAM_TARGET_DEFENDER_ATTACKER":
                    return TargetType.CamTargetDefenderAttacker;
                case "CAM_TARGET_DEFENDER_ATTACKER_EDGE":
                    return TargetType.CamTargetDefenderAttackerEdge;
                case "CAM_TARGET_DEFENDER_EDGE":
                    return TargetType.CamTargetDefenderEdge;
                case "CAM_TARGET_DEFENDER_GROUND":
                    return TargetType.CamTargetDefenderGround;
                case "CAM_TARGET_SHOULDER_ATTACKER_DEFENDER":
                    return TargetType.CamTargetShoulderAttackerDefender;
                case "CAM_TARGET_SHOULDER_ATTACKER_DEFENDER_MIRROR":
                    return TargetType.CamTargetShoulderAttackerDefenderMirror;
            }
            throw new Exception("Cannot unmarshal type TargetType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TargetType)untypedValue;
            switch (value)
            {
                case TargetType.CamTargetAttacker:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER");
                    return;
                case TargetType.CamTargetAttackerDefender:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER_DEFENDER");
                    return;
                case TargetType.CamTargetAttackerDefenderEdge:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER_DEFENDER_EDGE");
                    return;
                case TargetType.CamTargetAttackerDefenderMirror:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER_DEFENDER_MIRROR");
                    return;
                case TargetType.CamTargetAttackerDefenderWorld:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER_DEFENDER_WORLD");
                    return;
                case TargetType.CamTargetAttackerEdge:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER_EDGE");
                    return;
                case TargetType.CamTargetAttackerGround:
                    serializer.Serialize(writer, "CAM_TARGET_ATTACKER_GROUND");
                    return;
                case TargetType.CamTargetDefender:
                    serializer.Serialize(writer, "CAM_TARGET_DEFENDER");
                    return;
                case TargetType.CamTargetDefenderAttacker:
                    serializer.Serialize(writer, "CAM_TARGET_DEFENDER_ATTACKER");
                    return;
                case TargetType.CamTargetDefenderAttackerEdge:
                    serializer.Serialize(writer, "CAM_TARGET_DEFENDER_ATTACKER_EDGE");
                    return;
                case TargetType.CamTargetDefenderEdge:
                    serializer.Serialize(writer, "CAM_TARGET_DEFENDER_EDGE");
                    return;
                case TargetType.CamTargetDefenderGround:
                    serializer.Serialize(writer, "CAM_TARGET_DEFENDER_GROUND");
                    return;
                case TargetType.CamTargetShoulderAttackerDefender:
                    serializer.Serialize(writer, "CAM_TARGET_SHOULDER_ATTACKER_DEFENDER");
                    return;
                case TargetType.CamTargetShoulderAttackerDefenderMirror:
                    serializer.Serialize(writer, "CAM_TARGET_SHOULDER_ATTACKER_DEFENDER_MIRROR");
                    return;
            }
            throw new Exception("Cannot marshal type TargetType");
        }

        public static readonly TargetTypeConverter Singleton = new TargetTypeConverter();
    }

    internal class BadgeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BadgeType) || t == typeof(BadgeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BADGE_GREAT_LEAGUE":
                    return BadgeType.BadgeGreatLeague;
                case "BADGE_MASTER_LEAGUE":
                    return BadgeType.BadgeMasterLeague;
                case "BADGE_ULTRA_LEAGUE":
                    return BadgeType.BadgeUltraLeague;
            }
            throw new Exception("Cannot unmarshal type BadgeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BadgeType)untypedValue;
            switch (value)
            {
                case BadgeType.BadgeGreatLeague:
                    serializer.Serialize(writer, "BADGE_GREAT_LEAGUE");
                    return;
                case BadgeType.BadgeMasterLeague:
                    serializer.Serialize(writer, "BADGE_MASTER_LEAGUE");
                    return;
                case BadgeType.BadgeUltraLeague:
                    serializer.Serialize(writer, "BADGE_ULTRA_LEAGUE");
                    return;
            }
            throw new Exception("Cannot marshal type BadgeType");
        }

        public static readonly BadgeTypeConverter Singleton = new BadgeTypeConverter();
    }

    internal class CombatLeagueTemplateIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CombatLeagueTemplateId) || t == typeof(CombatLeagueTemplateId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COMBAT_LEAGUE_DEFAULT_GREAT":
                    return CombatLeagueTemplateId.CombatLeagueDefaultGreat;
                case "COMBAT_LEAGUE_DEFAULT_MASTER":
                    return CombatLeagueTemplateId.CombatLeagueDefaultMaster;
                case "COMBAT_LEAGUE_DEFAULT_ULTRA":
                    return CombatLeagueTemplateId.CombatLeagueDefaultUltra;
            }
            throw new Exception("Cannot unmarshal type CombatLeagueTemplateId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CombatLeagueTemplateId)untypedValue;
            switch (value)
            {
                case CombatLeagueTemplateId.CombatLeagueDefaultGreat:
                    serializer.Serialize(writer, "COMBAT_LEAGUE_DEFAULT_GREAT");
                    return;
                case CombatLeagueTemplateId.CombatLeagueDefaultMaster:
                    serializer.Serialize(writer, "COMBAT_LEAGUE_DEFAULT_MASTER");
                    return;
                case CombatLeagueTemplateId.CombatLeagueDefaultUltra:
                    serializer.Serialize(writer, "COMBAT_LEAGUE_DEFAULT_ULTRA");
                    return;
            }
            throw new Exception("Cannot marshal type CombatLeagueTemplateId");
        }

        public static readonly CombatLeagueTemplateIdConverter Singleton = new CombatLeagueTemplateIdConverter();
    }

    internal class LeagueTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LeagueType) || t == typeof(LeagueType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "PREMIER":
                    return LeagueType.Premier;
                case "STANDARD":
                    return LeagueType.Standard;
            }
            throw new Exception("Cannot unmarshal type LeagueType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LeagueType)untypedValue;
            switch (value)
            {
                case LeagueType.Premier:
                    serializer.Serialize(writer, "PREMIER");
                    return;
                case LeagueType.Standard:
                    serializer.Serialize(writer, "STANDARD");
                    return;
            }
            throw new Exception("Cannot marshal type LeagueType");
        }

        public static readonly LeagueTypeConverter Singleton = new LeagueTypeConverter();
    }

    internal class PokemonConditionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PokemonConditionType) || t == typeof(PokemonConditionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "POKEMON_BANLIST":
                    return PokemonConditionType.PokemonBanlist;
                case "POKEMON_CAUGHT_TIMESTAMP":
                    return PokemonConditionType.PokemonCaughtTimestamp;
                case "POKEMON_LEVEL_RANGE":
                    return PokemonConditionType.PokemonLevelRange;
                case "POKEMON_WHITELIST":
                    return PokemonConditionType.PokemonWhitelist;
                case "WITH_POKEMON_CP_LIMIT":
                    return PokemonConditionType.WithPokemonCpLimit;
                case "WITH_POKEMON_TYPE":
                    return PokemonConditionType.WithPokemonType;
                case "WITH_UNIQUE_POKEMON":
                    return PokemonConditionType.WithUniquePokemon;
            }
            throw new Exception("Cannot unmarshal type PokemonConditionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PokemonConditionType)untypedValue;
            switch (value)
            {
                case PokemonConditionType.PokemonBanlist:
                    serializer.Serialize(writer, "POKEMON_BANLIST");
                    return;
                case PokemonConditionType.PokemonCaughtTimestamp:
                    serializer.Serialize(writer, "POKEMON_CAUGHT_TIMESTAMP");
                    return;
                case PokemonConditionType.PokemonLevelRange:
                    serializer.Serialize(writer, "POKEMON_LEVEL_RANGE");
                    return;
                case PokemonConditionType.PokemonWhitelist:
                    serializer.Serialize(writer, "POKEMON_WHITELIST");
                    return;
                case PokemonConditionType.WithPokemonCpLimit:
                    serializer.Serialize(writer, "WITH_POKEMON_CP_LIMIT");
                    return;
                case PokemonConditionType.WithPokemonType:
                    serializer.Serialize(writer, "WITH_POKEMON_TYPE");
                    return;
                case PokemonConditionType.WithUniquePokemon:
                    serializer.Serialize(writer, "WITH_UNIQUE_POKEMON");
                    return;
            }
            throw new Exception("Cannot marshal type PokemonConditionType");
        }

        public static readonly PokemonConditionTypeConverter Singleton = new PokemonConditionTypeConverter();
    }

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "POKEMON_TYPE_BUG":
                    return TypeElement.PokemonTypeBug;
                case "POKEMON_TYPE_DARK":
                    return TypeElement.PokemonTypeDark;
                case "POKEMON_TYPE_DRAGON":
                    return TypeElement.PokemonTypeDragon;
                case "POKEMON_TYPE_ELECTRIC":
                    return TypeElement.PokemonTypeElectric;
                case "POKEMON_TYPE_FAIRY":
                    return TypeElement.PokemonTypeFairy;
                case "POKEMON_TYPE_FIGHTING":
                    return TypeElement.PokemonTypeFighting;
                case "POKEMON_TYPE_FIRE":
                    return TypeElement.PokemonTypeFire;
                case "POKEMON_TYPE_FLYING":
                    return TypeElement.PokemonTypeFlying;
                case "POKEMON_TYPE_GHOST":
                    return TypeElement.PokemonTypeGhost;
                case "POKEMON_TYPE_GRASS":
                    return TypeElement.PokemonTypeGrass;
                case "POKEMON_TYPE_GROUND":
                    return TypeElement.PokemonTypeGround;
                case "POKEMON_TYPE_ICE":
                    return TypeElement.PokemonTypeIce;
                case "POKEMON_TYPE_NORMAL":
                    return TypeElement.PokemonTypeNormal;
                case "POKEMON_TYPE_POISON":
                    return TypeElement.PokemonTypePoison;
                case "POKEMON_TYPE_PSYCHIC":
                    return TypeElement.PokemonTypePsychic;
                case "POKEMON_TYPE_ROCK":
                    return TypeElement.PokemonTypeRock;
                case "POKEMON_TYPE_STEEL":
                    return TypeElement.PokemonTypeSteel;
                case "POKEMON_TYPE_WATER":
                    return TypeElement.PokemonTypeWater;
            }
            throw new Exception("Cannot unmarshal type TypeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeElement)untypedValue;
            switch (value)
            {
                case TypeElement.PokemonTypeBug:
                    serializer.Serialize(writer, "POKEMON_TYPE_BUG");
                    return;
                case TypeElement.PokemonTypeDark:
                    serializer.Serialize(writer, "POKEMON_TYPE_DARK");
                    return;
                case TypeElement.PokemonTypeDragon:
                    serializer.Serialize(writer, "POKEMON_TYPE_DRAGON");
                    return;
                case TypeElement.PokemonTypeElectric:
                    serializer.Serialize(writer, "POKEMON_TYPE_ELECTRIC");
                    return;
                case TypeElement.PokemonTypeFairy:
                    serializer.Serialize(writer, "POKEMON_TYPE_FAIRY");
                    return;
                case TypeElement.PokemonTypeFighting:
                    serializer.Serialize(writer, "POKEMON_TYPE_FIGHTING");
                    return;
                case TypeElement.PokemonTypeFire:
                    serializer.Serialize(writer, "POKEMON_TYPE_FIRE");
                    return;
                case TypeElement.PokemonTypeFlying:
                    serializer.Serialize(writer, "POKEMON_TYPE_FLYING");
                    return;
                case TypeElement.PokemonTypeGhost:
                    serializer.Serialize(writer, "POKEMON_TYPE_GHOST");
                    return;
                case TypeElement.PokemonTypeGrass:
                    serializer.Serialize(writer, "POKEMON_TYPE_GRASS");
                    return;
                case TypeElement.PokemonTypeGround:
                    serializer.Serialize(writer, "POKEMON_TYPE_GROUND");
                    return;
                case TypeElement.PokemonTypeIce:
                    serializer.Serialize(writer, "POKEMON_TYPE_ICE");
                    return;
                case TypeElement.PokemonTypeNormal:
                    serializer.Serialize(writer, "POKEMON_TYPE_NORMAL");
                    return;
                case TypeElement.PokemonTypePoison:
                    serializer.Serialize(writer, "POKEMON_TYPE_POISON");
                    return;
                case TypeElement.PokemonTypePsychic:
                    serializer.Serialize(writer, "POKEMON_TYPE_PSYCHIC");
                    return;
                case TypeElement.PokemonTypeRock:
                    serializer.Serialize(writer, "POKEMON_TYPE_ROCK");
                    return;
                case TypeElement.PokemonTypeSteel:
                    serializer.Serialize(writer, "POKEMON_TYPE_STEEL");
                    return;
                case TypeElement.PokemonTypeWater:
                    serializer.Serialize(writer, "POKEMON_TYPE_WATER");
                    return;
            }
            throw new Exception("Cannot marshal type TypeElement");
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
    }

    internal class BackdropImageBundleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BackdropImageBundle) || t == typeof(BackdropImageBundle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "combat_blanche_backdrop":
                    return BackdropImageBundle.CombatBlancheBackdrop;
                case "combat_candela_backdrop":
                    return BackdropImageBundle.CombatCandelaBackdrop;
                case "combat_spark_backdrop":
                    return BackdropImageBundle.CombatSparkBackdrop;
            }
            throw new Exception("Cannot unmarshal type BackdropImageBundle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BackdropImageBundle)untypedValue;
            switch (value)
            {
                case BackdropImageBundle.CombatBlancheBackdrop:
                    serializer.Serialize(writer, "combat_blanche_backdrop");
                    return;
                case BackdropImageBundle.CombatCandelaBackdrop:
                    serializer.Serialize(writer, "combat_candela_backdrop");
                    return;
                case BackdropImageBundle.CombatSparkBackdrop:
                    serializer.Serialize(writer, "combat_spark_backdrop");
                    return;
            }
            throw new Exception("Cannot marshal type BackdropImageBundle");
        }

        public static readonly BackdropImageBundleConverter Singleton = new BackdropImageBundleConverter();
    }

    internal class ContextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Context) || t == typeof(Context?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "EVOLUTION_QUEST")
            {
                return Context.EvolutionQuest;
            }
            throw new Exception("Cannot unmarshal type Context");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Context)untypedValue;
            if (value == Context.EvolutionQuest)
            {
                serializer.Serialize(writer, "EVOLUTION_QUEST");
                return;
            }
            throw new Exception("Cannot marshal type Context");
        }

        public static readonly ContextConverter Singleton = new ContextConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "IAP_CATEGORY_BUNDLE":
                    return Category.IapCategoryBundle;
                case "IAP_CATEGORY_FREE":
                    return Category.IapCategoryFree;
                case "IAP_CATEGORY_GLOBAL_EVENT_TICKET":
                    return Category.IapCategoryGlobalEventTicket;
                case "IAP_CATEGORY_ITEMS":
                    return Category.IapCategoryItems;
                case "IAP_CATEGORY_STICKER":
                    return Category.IapCategorySticker;
                case "IAP_CATEGORY_TRANSPORTER_ENERGY":
                    return Category.IapCategoryTransporterEnergy;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.IapCategoryBundle:
                    serializer.Serialize(writer, "IAP_CATEGORY_BUNDLE");
                    return;
                case Category.IapCategoryFree:
                    serializer.Serialize(writer, "IAP_CATEGORY_FREE");
                    return;
                case Category.IapCategoryGlobalEventTicket:
                    serializer.Serialize(writer, "IAP_CATEGORY_GLOBAL_EVENT_TICKET");
                    return;
                case Category.IapCategoryItems:
                    serializer.Serialize(writer, "IAP_CATEGORY_ITEMS");
                    return;
                case Category.IapCategorySticker:
                    serializer.Serialize(writer, "IAP_CATEGORY_STICKER");
                    return;
                case Category.IapCategoryTransporterEnergy:
                    serializer.Serialize(writer, "IAP_CATEGORY_TRANSPORTER_ENERGY");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }

    internal class ItemIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemId) || t == typeof(ItemId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ItemId { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ItemId { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type ItemId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ItemId)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type ItemId");
        }

        public static readonly ItemIdConverter Singleton = new ItemIdConverter();
    }

    internal class PokemonClassConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PokemonClass) || t == typeof(PokemonClass?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "POKEMON_CLASS_LEGENDARY":
                    return PokemonClass.PokemonClassLegendary;
                case "POKEMON_CLASS_MYTHIC":
                    return PokemonClass.PokemonClassMythic;
            }
            throw new Exception("Cannot unmarshal type PokemonClass");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PokemonClass)untypedValue;
            switch (value)
            {
                case PokemonClass.PokemonClassLegendary:
                    serializer.Serialize(writer, "POKEMON_CLASS_LEGENDARY");
                    return;
                case PokemonClass.PokemonClassMythic:
                    serializer.Serialize(writer, "POKEMON_CLASS_MYTHIC");
                    return;
            }
            throw new Exception("Cannot marshal type PokemonClass");
        }

        public static readonly PokemonClassConverter Singleton = new PokemonClassConverter();
    }

    internal class BuddySizeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BuddySize) || t == typeof(BuddySize?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BUDDY_BABY":
                    return BuddySize.BuddyBaby;
                case "BUDDY_BIG":
                    return BuddySize.BuddyBig;
                case "BUDDY_FLYING":
                    return BuddySize.BuddyFlying;
                case "BUDDY_SHOULDER":
                    return BuddySize.BuddyShoulder;
            }
            throw new Exception("Cannot unmarshal type BuddySize");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BuddySize)untypedValue;
            switch (value)
            {
                case BuddySize.BuddyBaby:
                    serializer.Serialize(writer, "BUDDY_BABY");
                    return;
                case BuddySize.BuddyBig:
                    serializer.Serialize(writer, "BUDDY_BIG");
                    return;
                case BuddySize.BuddyFlying:
                    serializer.Serialize(writer, "BUDDY_FLYING");
                    return;
                case BuddySize.BuddyShoulder:
                    serializer.Serialize(writer, "BUDDY_SHOULDER");
                    return;
            }
            throw new Exception("Cannot marshal type BuddySize");
        }

        public static readonly BuddySizeConverter Singleton = new BuddySizeConverter();
    }

    internal class MovementTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MovementType) || t == typeof(MovementType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "MOVEMENT_ELECTRIC":
                    return MovementType.MovementElectric;
                case "MOVEMENT_FLYING":
                    return MovementType.MovementFlying;
                case "MOVEMENT_HOVERING":
                    return MovementType.MovementHovering;
                case "MOVEMENT_JUMP":
                    return MovementType.MovementJump;
                case "MOVEMENT_PSYCHIC":
                    return MovementType.MovementPsychic;
            }
            throw new Exception("Cannot unmarshal type MovementType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MovementType)untypedValue;
            switch (value)
            {
                case MovementType.MovementElectric:
                    serializer.Serialize(writer, "MOVEMENT_ELECTRIC");
                    return;
                case MovementType.MovementFlying:
                    serializer.Serialize(writer, "MOVEMENT_FLYING");
                    return;
                case MovementType.MovementHovering:
                    serializer.Serialize(writer, "MOVEMENT_HOVERING");
                    return;
                case MovementType.MovementJump:
                    serializer.Serialize(writer, "MOVEMENT_JUMP");
                    return;
                case MovementType.MovementPsychic:
                    serializer.Serialize(writer, "MOVEMENT_PSYCHIC");
                    return;
            }
            throw new Exception("Cannot marshal type MovementType");
        }

        public static readonly MovementTypeConverter Singleton = new MovementTypeConverter();
    }

    internal class EvolutionItemRequirementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EvolutionItemRequirement) || t == typeof(EvolutionItemRequirement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ITEM_DRAGON_SCALE":
                    return EvolutionItemRequirement.ItemDragonScale;
                case "ITEM_GEN4_EVOLUTION_STONE":
                    return EvolutionItemRequirement.ItemGen4EvolutionStone;
                case "ITEM_GEN5_EVOLUTION_STONE":
                    return EvolutionItemRequirement.ItemGen5EvolutionStone;
                case "ITEM_KINGS_ROCK":
                    return EvolutionItemRequirement.ItemKingsRock;
                case "ITEM_METAL_COAT":
                    return EvolutionItemRequirement.ItemMetalCoat;
                case "ITEM_SUN_STONE":
                    return EvolutionItemRequirement.ItemSunStone;
                case "ITEM_UP_GRADE":
                    return EvolutionItemRequirement.ItemUpGrade;
            }
            throw new Exception("Cannot unmarshal type EvolutionItemRequirement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EvolutionItemRequirement)untypedValue;
            switch (value)
            {
                case EvolutionItemRequirement.ItemDragonScale:
                    serializer.Serialize(writer, "ITEM_DRAGON_SCALE");
                    return;
                case EvolutionItemRequirement.ItemGen4EvolutionStone:
                    serializer.Serialize(writer, "ITEM_GEN4_EVOLUTION_STONE");
                    return;
                case EvolutionItemRequirement.ItemGen5EvolutionStone:
                    serializer.Serialize(writer, "ITEM_GEN5_EVOLUTION_STONE");
                    return;
                case EvolutionItemRequirement.ItemKingsRock:
                    serializer.Serialize(writer, "ITEM_KINGS_ROCK");
                    return;
                case EvolutionItemRequirement.ItemMetalCoat:
                    serializer.Serialize(writer, "ITEM_METAL_COAT");
                    return;
                case EvolutionItemRequirement.ItemSunStone:
                    serializer.Serialize(writer, "ITEM_SUN_STONE");
                    return;
                case EvolutionItemRequirement.ItemUpGrade:
                    serializer.Serialize(writer, "ITEM_UP_GRADE");
                    return;
            }
            throw new Exception("Cannot marshal type EvolutionItemRequirement");
        }

        public static readonly EvolutionItemRequirementConverter Singleton = new EvolutionItemRequirementConverter();
    }

    internal class GenderRequirementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GenderRequirement) || t == typeof(GenderRequirement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FEMALE":
                    return GenderRequirement.Female;
                case "MALE":
                    return GenderRequirement.Male;
            }
            throw new Exception("Cannot unmarshal type GenderRequirement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GenderRequirement)untypedValue;
            switch (value)
            {
                case GenderRequirement.Female:
                    serializer.Serialize(writer, "FEMALE");
                    return;
                case GenderRequirement.Male:
                    serializer.Serialize(writer, "MALE");
                    return;
            }
            throw new Exception("Cannot marshal type GenderRequirement");
        }

        public static readonly GenderRequirementConverter Singleton = new GenderRequirementConverter();
    }

    internal class TempConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Temp) || t == typeof(Temp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "TEMP_EVOLUTION_MEGA":
                    return Temp.TempEvolutionMega;
                case "TEMP_EVOLUTION_MEGA_X":
                    return Temp.TempEvolutionMegaX;
                case "TEMP_EVOLUTION_MEGA_Y":
                    return Temp.TempEvolutionMegaY;
            }
            throw new Exception("Cannot unmarshal type Temp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Temp)untypedValue;
            switch (value)
            {
                case Temp.TempEvolutionMega:
                    serializer.Serialize(writer, "TEMP_EVOLUTION_MEGA");
                    return;
                case Temp.TempEvolutionMegaX:
                    serializer.Serialize(writer, "TEMP_EVOLUTION_MEGA_X");
                    return;
                case Temp.TempEvolutionMegaY:
                    serializer.Serialize(writer, "TEMP_EVOLUTION_MEGA_Y");
                    return;
            }
            throw new Exception("Cannot marshal type Temp");
        }

        public static readonly TempConverter Singleton = new TempConverter();
    }

    internal class AvailableFormConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AvailableForm) || t == typeof(AvailableForm?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FURFROU_DANDY":
                    return AvailableForm.FurfrouDandy;
                case "FURFROU_DIAMOND":
                    return AvailableForm.FurfrouDiamond;
                case "FURFROU_LA_REINE":
                    return AvailableForm.FurfrouLaReine;
                case "FURFROU_MATRON":
                    return AvailableForm.FurfrouMatron;
                case "FURFROU_NATURAL":
                    return AvailableForm.FurfrouNatural;
            }
            throw new Exception("Cannot unmarshal type AvailableForm");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AvailableForm)untypedValue;
            switch (value)
            {
                case AvailableForm.FurfrouDandy:
                    serializer.Serialize(writer, "FURFROU_DANDY");
                    return;
                case AvailableForm.FurfrouDiamond:
                    serializer.Serialize(writer, "FURFROU_DIAMOND");
                    return;
                case AvailableForm.FurfrouLaReine:
                    serializer.Serialize(writer, "FURFROU_LA_REINE");
                    return;
                case AvailableForm.FurfrouMatron:
                    serializer.Serialize(writer, "FURFROU_MATRON");
                    return;
                case AvailableForm.FurfrouNatural:
                    serializer.Serialize(writer, "FURFROU_NATURAL");
                    return;
            }
            throw new Exception("Cannot marshal type AvailableForm");
        }

        public static readonly AvailableFormConverter Singleton = new AvailableFormConverter();
    }

    internal class PurifiedChargeMoveConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurifiedChargeMove) || t == typeof(PurifiedChargeMove?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "RETURN")
            {
                return PurifiedChargeMove.Return;
            }
            throw new Exception("Cannot unmarshal type PurifiedChargeMove");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurifiedChargeMove)untypedValue;
            if (value == PurifiedChargeMove.Return)
            {
                serializer.Serialize(writer, "RETURN");
                return;
            }
            throw new Exception("Cannot marshal type PurifiedChargeMove");
        }

        public static readonly PurifiedChargeMoveConverter Singleton = new PurifiedChargeMoveConverter();
    }

    internal class ShadowChargeMoveConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShadowChargeMove) || t == typeof(ShadowChargeMove?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "FRUSTRATION")
            {
                return ShadowChargeMove.Frustration;
            }
            throw new Exception("Cannot unmarshal type ShadowChargeMove");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ShadowChargeMove)untypedValue;
            if (value == ShadowChargeMove.Frustration)
            {
                serializer.Serialize(writer, "FRUSTRATION");
                return;
            }
            throw new Exception("Cannot marshal type ShadowChargeMove");
        }

        public static readonly ShadowChargeMoveConverter Singleton = new ShadowChargeMoveConverter();
    }

    internal class ItemEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemEnum) || t == typeof(ItemEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ITEM_MOVE_REROLL_SPECIAL_ATTACK":
                    return ItemEnum.ItemMoveRerollSpecialAttack;
                case "ITEM_RARE_CANDY":
                    return ItemEnum.ItemRareCandy;
            }
            throw new Exception("Cannot unmarshal type ItemEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemEnum)untypedValue;
            switch (value)
            {
                case ItemEnum.ItemMoveRerollSpecialAttack:
                    serializer.Serialize(writer, "ITEM_MOVE_REROLL_SPECIAL_ATTACK");
                    return;
                case ItemEnum.ItemRareCandy:
                    serializer.Serialize(writer, "ITEM_RARE_CANDY");
                    return;
            }
            throw new Exception("Cannot marshal type ItemEnum");
        }

        public static readonly ItemEnumConverter Singleton = new ItemEnumConverter();
    }

    internal class RewardTrackConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RewardTrack) || t == typeof(RewardTrack?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "VS_SEEKER_REWARD_TRACK_PREMIUM")
            {
                return RewardTrack.VsSeekerRewardTrackPremium;
            }
            throw new Exception("Cannot unmarshal type RewardTrack");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RewardTrack)untypedValue;
            if (value == RewardTrack.VsSeekerRewardTrackPremium)
            {
                serializer.Serialize(writer, "VS_SEEKER_REWARD_TRACK_PREMIUM");
                return;
            }
            throw new Exception("Cannot marshal type RewardTrack");
        }

        public static readonly RewardTrackConverter Singleton = new RewardTrackConverter();
    }
}
