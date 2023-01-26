﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Pokedex;
//
//    var pokedexEntry = PokedexEntry.FromJson(jsonString);

namespace Pokedex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Globalization;
    using Google.Protobuf.Collections;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    //using POGOProtos.Rpc;
    using PolygonStatsPlugins.Data;

    [Table("PokedexEntry")]
    public partial class PokedexEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid SnapshotId { get; set; }
        [Obsolete]
        public DateTime timestamp { get; set; }

        public int PokedexId { get; set; }

        public int TimesEncountered { get; set; }
        public int TimesCaptured { get; set; }
        public int EvolutionStonePieces { get; set; }
        public int EvolutionStones { get; set; }
        public List<PokedexEnum> CapturedCostumes { get; set; }
        public List<PokedexEnum> CapturedForms { get; set; }

        public List<PokedexEnum> CapturedGenders { get; set; }

        public bool CapturedShiny { get; set; }
        public List<PokedexEnum> EncounteredCostumes { get; set; }
        public List<PokedexEnum> EncounteredForms { get; set; }

        public List<PokedexEnum> EncounteredGenders { get; set; }

        public bool EncounteredShiny { get; set; }
        public int TimesLuckyReceived { get; set; }
        public int TimesPurified { get; set; }
        //public List<PokedexEntryProto.Types.TempEvoData> TempEvoData { get; set; }

        public List<PokedexEnum> CapturedShinyForms { get; set; }

        //public MapField<string, PokedexEntryProto.Types.PokedexCategoryStatus> PokedexCategoryStatus { get; set; }

        public List<PokedexEnum> CapturedShinyAlignments { get; set; }
    }
    public class PokedexEnum
    {
        [Key]
        public int EnumValue { get; set; }
        public string EnumName { get; set; }
        
    }

    public partial class PokedexCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string CategoryKey { get; set; }
        public string CategoryName { get; set; }
        public int RequirementsToUnlock { get; set; }

    }
    [Table("PokedexCategoryEntry")]
    public partial class PokedexCategoryEntry
    {
        [Key, Column(Order = 0)]
        public int AccountId { get; set; }
        [Key, Column(Order = 1)]
        public POGOProtos.Rpc.PokedexCategory Category { get; set; }

        public bool Encountered { get; set; }

        public bool? Acquired { get; set; }
    }
    public partial class Snapshot
    {
        public Guid SnapshotId { get; set; }
        public int AccountId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
    //public partial class Pokemon
    //{
    //    [Key]
    //    public long? PokedexId { get; set; }
    //    public string PokemonName { get; set; }
    //    public long? DefaultFormId { get; set; }
    //    public long? GenId { get; set; }

    //    public Generation? Generation { get; set; }

    //    [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
    //    public List<long> Forms { get; set; }

    //    [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Attack { get; set; }

    //    [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Defense { get; set; }

    //    [JsonProperty("stamina", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Stamina { get; set; }

    //    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? Height { get; set; }

    //    [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? Weight { get; set; }

    //    [JsonProperty("family", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Family { get; set; }

    //    [JsonProperty("fleeRate", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? FleeRate { get; set; }

    //    [JsonProperty("captureRate", NullValueHandling = NullValueHandling.Ignore)]
    //    public double? CaptureRate { get; set; }

    //    [JsonProperty("legendary", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Legendary { get; set; }

    //    [JsonProperty("mythic", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Mythic { get; set; }

    //    [JsonProperty("ultraBeast", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? UltraBeast { get; set; }

    //    [JsonProperty("buddyGroupNumber", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BuddyGroupNumber { get; set; }

    //    [JsonProperty("buddyDistance", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BuddyDistance { get; set; }

    //    [JsonProperty("buddyMegaEnergy", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BuddyMegaEnergy { get; set; }

    //    [JsonProperty("thirdMoveStardust", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? ThirdMoveStardust { get; set; }

    //    [JsonProperty("thirdMoveCandy", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? ThirdMoveCandy { get; set; }

    //    [JsonProperty("gymDefenderEligible", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? GymDefenderEligible { get; set; }

    //    [JsonProperty("tradable", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Tradable { get; set; }

    //    [JsonProperty("transferable", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Transferable { get; set; }

    //    [JsonProperty("evolutions", NullValueHandling = NullValueHandling.Ignore)]
    //    public List<PokemonEvolution> Evolutions { get; set; }

    //    [JsonProperty("little", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Little { get; set; }

    //    [JsonProperty("bonusCandyCapture", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BonusCandyCapture { get; set; }

    //    [JsonProperty("bonusStardustCapture", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BonusStardustCapture { get; set; }

    //    [JsonProperty("tempEvolutions", NullValueHandling = NullValueHandling.Ignore)]
    //    public List<TempEvolution> TempEvolutions { get; set; }

    //    [JsonProperty("costumeOverrideEvos", NullValueHandling = NullValueHandling.Ignore)]
    //    public List<CostumeOverrideEvo> CostumeOverrideEvos { get; set; }

    //    [JsonProperty("unreleased", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Unreleased { get; set; }
    //}
}
