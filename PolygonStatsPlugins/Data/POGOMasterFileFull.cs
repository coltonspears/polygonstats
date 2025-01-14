﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace PolygonStatsPlugins.Data
{

    public partial class PokemonGameMaster
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Pokemon> Pokemon { get; set; }

        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Form> Forms { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TypeValue> Types { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Item> Items { get; set; }

        [JsonProperty("moves", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Move> Moves { get; set; }

        [JsonProperty("questTypes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Quest> QuestTypes { get; set; }

        [JsonProperty("questRewardTypes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Quest> QuestRewardTypes { get; set; }

        [JsonProperty("questConditions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Quest> QuestConditions { get; set; }

        [JsonProperty("invasions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Invasion> Invasions { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Weather> Weather { get; set; }
    }

    public partial class Form
    {
        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("formId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FormId { get; set; }

        [JsonProperty("formName", NullValueHandling = NullValueHandling.Ignore)]
        public string FormName { get; set; }

        [JsonProperty("chargedMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> ChargedMoves { get; set; }

        [JsonProperty("quickMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> QuickMoves { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Types { get; set; }

        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attack { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defense { get; set; }

        [JsonProperty("stamina", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stamina { get; set; }

        [JsonProperty("evolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<FormEvolution> Evolutions { get; set; }

        [JsonProperty("purificationDust", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurificationDust { get; set; }

        [JsonProperty("purificationCandy", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurificationCandy { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        [JsonProperty("isCostume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCostume { get; set; }

        [JsonProperty("tempEvolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TempEvolution> TempEvolutions { get; set; }

        [JsonProperty("little", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Little { get; set; }
    }

    public partial class FormEvolution
    {
        [JsonProperty("evoId", NullValueHandling = NullValueHandling.Ignore)]
        public long? EvoId { get; set; }

        [JsonProperty("formId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FormId { get; set; }

        [JsonProperty("candyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyCost { get; set; }

        [JsonProperty("tradeBonus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TradeBonus { get; set; }

        [JsonProperty("genderRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public long? GenderRequirement { get; set; }

        [JsonProperty("itemRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemRequirement { get; set; }

        [JsonProperty("questRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestRequirement { get; set; }
    }

    public partial class TempEvolution
    {
        [JsonProperty("tempEvoId", NullValueHandling = NullValueHandling.Ignore)]
        public long? TempEvoId { get; set; }

        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attack { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defense { get; set; }

        [JsonProperty("stamina", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stamina { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        [JsonProperty("firstEnergyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstEnergyCost { get; set; }

        [JsonProperty("subsequentEnergyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubsequentEnergyCost { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Types { get; set; }

        [JsonProperty("unreleased", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unreleased { get; set; }
    }

    public partial class Invasion
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public long? Gender { get; set; }

        [JsonProperty("grunt", NullValueHandling = NullValueHandling.Ignore)]
        public Grunt? Grunt { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("secondReward", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecondReward { get; set; }

        [JsonProperty("encounters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Encounter> Encounters { get; set; }
    }

    public partial class Encounter
    {
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public Position? Position { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("formId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FormId { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("itemId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemId { get; set; }

        [JsonProperty("itemName", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty("minTrainerLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinTrainerLevel { get; set; }
    }

    public partial class Move
    {
        [JsonProperty("moveId", NullValueHandling = NullValueHandling.Ignore)]
        public long? MoveId { get; set; }

        [JsonProperty("moveName", NullValueHandling = NullValueHandling.Ignore)]
        public string MoveName { get; set; }

        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public long? Type { get; set; }

        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public long? Power { get; set; }
    }

    public partial class Pokemon
    {

        [Key]
        [JsonProperty("pokedexId", NullValueHandling = NullValueHandling.Ignore)]
        public long? PokedexId { get; set; }

        [JsonProperty("pokemonName", NullValueHandling = NullValueHandling.Ignore)]
        public string PokemonName { get; set; }

        [JsonProperty("defaultFormId", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefaultFormId { get; set; }

        [NotMapped]
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Types { get; set; }

        [NotMapped]
        [JsonProperty("quickMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> QuickMoves { get; set; }

        [NotMapped]
        [JsonProperty("chargedMoves", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> ChargedMoves { get; set; }

        [JsonProperty("genId", NullValueHandling = NullValueHandling.Ignore)]
        public long? GenId { get; set; }

        [NotMapped]
        [JsonProperty("generation", NullValueHandling = NullValueHandling.Ignore)]
        public Generation? Generation { get; set; }

        [NotMapped]
        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Forms { get; set; }

        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attack { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defense { get; set; }

        [JsonProperty("stamina", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stamina { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        [JsonProperty("family", NullValueHandling = NullValueHandling.Ignore)]
        public long? Family { get; set; }

        [JsonProperty("fleeRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? FleeRate { get; set; }

        [JsonProperty("captureRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? CaptureRate { get; set; }

        [JsonProperty("legendary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Legendary { get; set; }

        [JsonProperty("mythic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mythic { get; set; }

        [JsonProperty("ultraBeast", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UltraBeast { get; set; }

        [JsonProperty("buddyGroupNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyGroupNumber { get; set; }

        [JsonProperty("buddyDistance", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyDistance { get; set; }

        [JsonProperty("buddyMegaEnergy", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyMegaEnergy { get; set; }

        [JsonProperty("thirdMoveStardust", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThirdMoveStardust { get; set; }

        [JsonProperty("thirdMoveCandy", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThirdMoveCandy { get; set; }

        [JsonProperty("gymDefenderEligible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GymDefenderEligible { get; set; }

        [JsonProperty("tradable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tradable { get; set; }

        [JsonProperty("transferable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Transferable { get; set; }

        [NotMapped]
        [JsonProperty("evolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PokemonEvolution> Evolutions { get; set; }

        [JsonProperty("little", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Little { get; set; }

        [JsonProperty("bonusCandyCapture", NullValueHandling = NullValueHandling.Ignore)]
        public long? BonusCandyCapture { get; set; }

        [JsonProperty("bonusStardustCapture", NullValueHandling = NullValueHandling.Ignore)]
        public long? BonusStardustCapture { get; set; }

        [NotMapped]
        [JsonProperty("tempEvolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TempEvolution> TempEvolutions { get; set; }

        [NotMapped]
        [JsonProperty("costumeOverrideEvos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CostumeOverrideEvo> CostumeOverrideEvos { get; set; }

        [JsonProperty("unreleased", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unreleased { get; set; }
    }

    public partial class CostumeOverrideEvo
    {
        [JsonProperty("costumeId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CostumeId { get; set; }

        [JsonProperty("costumeProto", NullValueHandling = NullValueHandling.Ignore)]
        public string CostumeProto { get; set; }

        [JsonProperty("costumeName", NullValueHandling = NullValueHandling.Ignore)]
        public string CostumeName { get; set; }
    }

    public partial class PokemonEvolution
    {
        [JsonProperty("evoId", NullValueHandling = NullValueHandling.Ignore)]
        public long? EvoId { get; set; }

        [JsonProperty("formId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FormId { get; set; }

        [JsonProperty("candyCost", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyCost { get; set; }

        [JsonProperty("itemRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemRequirement { get; set; }

        [JsonProperty("tradeBonus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TradeBonus { get; set; }

        [JsonProperty("mustBeBuddy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MustBeBuddy { get; set; }

        [JsonProperty("onlyDaytime", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDaytime { get; set; }

        [JsonProperty("questRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestRequirement { get; set; }

        [JsonProperty("onlyNighttime", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyNighttime { get; set; }

        [JsonProperty("genderRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public long? GenderRequirement { get; set; }
    }

    public partial class Quest
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatted { get; set; }
    }

    public partial class TypeValue
    {
        [JsonProperty("typeId", NullValueHandling = NullValueHandling.Ignore)]
        public long? TypeId { get; set; }

        [JsonProperty("typeName", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeName { get; set; }

        [JsonProperty("strengths", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Strengths { get; set; }

        [JsonProperty("weaknesses", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Weaknesses { get; set; }

        [JsonProperty("veryWeakAgainst", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> VeryWeakAgainst { get; set; }

        [JsonProperty("immunes", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Immunes { get; set; }

        [JsonProperty("weakAgainst", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> WeakAgainst { get; set; }

        [JsonProperty("resistances", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Resistances { get; set; }
    }

    public partial class Weather
    {
        [JsonProperty("weatherId", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeatherId { get; set; }

        [JsonProperty("weatherName", NullValueHandling = NullValueHandling.Ignore)]
        public string WeatherName { get; set; }

        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Types { get; set; }
    }

    public enum Position { First, Second, Third };

    public enum Grunt { Blanche, Candela, Event, Executive, Giovanni, Grunt, Gruntb, Spark, Unset };

    public enum Generation { Alola, Galar, Hoenn, Johto, Kalos, Kanto, Sinnoh, Unova };

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
                PositionConverter.Singleton,
                GruntConverter.Singleton,
                GenerationConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PositionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Position) || t == typeof(Position?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "first":
                    return Position.First;
                case "second":
                    return Position.Second;
                case "third":
                    return Position.Third;
            }
            throw new Exception("Cannot unmarshal type Position");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Position)untypedValue;
            switch (value)
            {
                case Position.First:
                    serializer.Serialize(writer, "first");
                    return;
                case Position.Second:
                    serializer.Serialize(writer, "second");
                    return;
                case Position.Third:
                    serializer.Serialize(writer, "third");
                    return;
            }
            throw new Exception("Cannot marshal type Position");
        }

        public static readonly PositionConverter Singleton = new PositionConverter();
    }

    internal class GruntConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Grunt) || t == typeof(Grunt?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Blanche":
                    return Grunt.Blanche;
                case "Candela":
                    return Grunt.Candela;
                case "Event":
                    return Grunt.Event;
                case "Executive":
                    return Grunt.Executive;
                case "Giovanni":
                    return Grunt.Giovanni;
                case "Grunt":
                    return Grunt.Grunt;
                case "Gruntb":
                    return Grunt.Gruntb;
                case "Spark":
                    return Grunt.Spark;
                case "Unset":
                    return Grunt.Unset;
            }
            throw new Exception("Cannot unmarshal type Grunt");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Grunt)untypedValue;
            switch (value)
            {
                case Grunt.Blanche:
                    serializer.Serialize(writer, "Blanche");
                    return;
                case Grunt.Candela:
                    serializer.Serialize(writer, "Candela");
                    return;
                case Grunt.Event:
                    serializer.Serialize(writer, "Event");
                    return;
                case Grunt.Executive:
                    serializer.Serialize(writer, "Executive");
                    return;
                case Grunt.Giovanni:
                    serializer.Serialize(writer, "Giovanni");
                    return;
                case Grunt.Grunt:
                    serializer.Serialize(writer, "Grunt");
                    return;
                case Grunt.Gruntb:
                    serializer.Serialize(writer, "Gruntb");
                    return;
                case Grunt.Spark:
                    serializer.Serialize(writer, "Spark");
                    return;
                case Grunt.Unset:
                    serializer.Serialize(writer, "Unset");
                    return;
            }
            throw new Exception("Cannot marshal type Grunt");
        }

        public static readonly GruntConverter Singleton = new GruntConverter();
    }

    internal class GenerationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Generation) || t == typeof(Generation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Alola":
                    return Generation.Alola;
                case "Galar":
                    return Generation.Galar;
                case "Hoenn":
                    return Generation.Hoenn;
                case "Johto":
                    return Generation.Johto;
                case "Kalos":
                    return Generation.Kalos;
                case "Kanto":
                    return Generation.Kanto;
                case "Sinnoh":
                    return Generation.Sinnoh;
                case "Unova":
                    return Generation.Unova;
            }
            throw new Exception("Cannot unmarshal type Generation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Generation)untypedValue;
            switch (value)
            {
                case Generation.Alola:
                    serializer.Serialize(writer, "Alola");
                    return;
                case Generation.Galar:
                    serializer.Serialize(writer, "Galar");
                    return;
                case Generation.Hoenn:
                    serializer.Serialize(writer, "Hoenn");
                    return;
                case Generation.Johto:
                    serializer.Serialize(writer, "Johto");
                    return;
                case Generation.Kalos:
                    serializer.Serialize(writer, "Kalos");
                    return;
                case Generation.Kanto:
                    serializer.Serialize(writer, "Kanto");
                    return;
                case Generation.Sinnoh:
                    serializer.Serialize(writer, "Sinnoh");
                    return;
                case Generation.Unova:
                    serializer.Serialize(writer, "Unova");
                    return;
            }
            throw new Exception("Cannot marshal type Generation");
        }
        public static readonly GenerationConverter Singleton = new GenerationConverter();
    }
}