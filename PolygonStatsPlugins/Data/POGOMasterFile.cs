﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace PolygonStatsPlugins
{

    public partial class PokemonData
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Pokemon> Pokemon { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TypeElement> Types { get; set; }

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

        [JsonProperty("translations", NullValueHandling = NullValueHandling.Ignore)]
        public Translations Translations { get; set; }
    }

    public partial class Invasion
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public long? Gender { get; set; }

        [JsonProperty("grunt", NullValueHandling = NullValueHandling.Ignore)]
        public Grunt? Grunt { get; set; }

        [JsonProperty("second_reward", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecondReward { get; set; }

        [JsonProperty("encounters", NullValueHandling = NullValueHandling.Ignore)]
        public Encounters Encounters { get; set; }
    }

    public partial class Encounters
    {
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> First { get; set; }

        [JsonProperty("second", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Second { get; set; }

        [JsonProperty("third", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Third { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }

        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public long? Power { get; set; }
    }

    public partial class Pokemon
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("pokedex_id", NullValueHandling = NullValueHandling.Ignore)]
        public long PokedexId { get; set; }

        [JsonProperty("default_form_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefaultFormId { get; set; }

        [JsonProperty("gen_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? GenId { get; set; }

        [JsonProperty("generation", NullValueHandling = NullValueHandling.Ignore)]
        public Generation? Generation { get; set; }

        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Form> Forms { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeElement> Types { get; set; }

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

        [JsonProperty("quick_moves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuickMoves { get; set; }

        [JsonProperty("charged_moves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChargedMoves { get; set; }

        [JsonProperty("family", NullValueHandling = NullValueHandling.Ignore)]
        public long? Family { get; set; }

        [JsonProperty("flee_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? FleeRate { get; set; }

        [JsonProperty("capture_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? CaptureRate { get; set; }

        [JsonProperty("legendary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Legendary { get; set; }

        [JsonProperty("mythic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mythic { get; set; }

        [JsonProperty("buddy_group_number", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyGroupNumber { get; set; }

        [JsonProperty("buddy_distance", NullValueHandling = NullValueHandling.Ignore)]
        public long? BuddyDistance { get; set; }

        [JsonProperty("third_move_stardust", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThirdMoveStardust { get; set; }

        [JsonProperty("third_move_candy", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThirdMoveCandy { get; set; }

        [JsonProperty("gym_defender_eligible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GymDefenderEligible { get; set; }

        [JsonProperty("evolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Evolution> Evolutions { get; set; }

        [JsonProperty("little", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Little { get; set; }

        [JsonProperty("temp_evolutions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PokemonTempEvolution> TempEvolutions { get; set; }

        [JsonProperty("costume_override_evos", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> CostumeOverrideEvos { get; set; }
    }

    public partial class Evolution
    {
        [JsonProperty("pokemon", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pokemon { get; set; }

        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public long? Form { get; set; }

        [JsonProperty("gender_requirement", NullValueHandling = NullValueHandling.Ignore)]
        public long? GenderRequirement { get; set; }
    }

    public partial class Form
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("evolutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Evolution> Evolutions { get; set; }

        [JsonProperty("is_costume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCostume { get; set; }

        [JsonProperty("temp_evolutions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, FormTempEvolution> TempEvolutions { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        [JsonProperty("charged_moves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChargedMoves { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeElement> Types { get; set; }

        [JsonProperty("attack", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attack { get; set; }

        [JsonProperty("defense", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defense { get; set; }

        [JsonProperty("stamina", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stamina { get; set; }

        [JsonProperty("quick_moves", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuickMoves { get; set; }

        [JsonProperty("little", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Little { get; set; }
    }

    public partial class FormTempEvolution
    {
    }

    public partial class PokemonTempEvolution
    {
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

        [JsonProperty("unreleased", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unreleased { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeElement> Types { get; set; }
    }

    public partial class Quest
    {
        [JsonProperty("proto", NullValueHandling = NullValueHandling.Ignore)]
        public string Proto { get; set; }

        [JsonProperty("formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatted { get; set; }
    }

    public partial class Translations
    {
        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> De { get; set; }

        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> En { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Fr { get; set; }
    }

    public partial class Weather
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeElement> Types { get; set; }
    }

    public enum Grunt { Blanche, Candela, Event, Executive, Giovanni, Grunt, Gruntb, Spark, Unset };

    public enum TypeElement { Bug, Dark, Dragon, Electric, Fairy, Fighting, Fire, Flying, Ghost, Grass, Ground, Ice, None, Normal, Poison, Psychic, Rock, Steel, Water };

    public enum Generation { Alola, Galar, Hoenn, Johto, Kalos, Kanto, Sinnoh, Unova };

    public partial class PokemonData
    {
        public static PokemonData FromJson(string json) => JsonConvert.DeserializeObject<PokemonData>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PokemonData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GruntConverter.Singleton,
                TypeElementConverter.Singleton,
                GenerationConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GruntConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Grunt) || t == typeof(Grunt?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize(reader);
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

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Bug":
                    return TypeElement.Bug;
                case "Dark":
                    return TypeElement.Dark;
                case "Dragon":
                    return TypeElement.Dragon;
                case "Electric":
                    return TypeElement.Electric;
                case "Fairy":
                    return TypeElement.Fairy;
                case "Fighting":
                    return TypeElement.Fighting;
                case "Fire":
                    return TypeElement.Fire;
                case "Flying":
                    return TypeElement.Flying;
                case "Ghost":
                    return TypeElement.Ghost;
                case "Grass":
                    return TypeElement.Grass;
                case "Ground":
                    return TypeElement.Ground;
                case "Ice":
                    return TypeElement.Ice;
                case "None":
                    return TypeElement.None;
                case "Normal":
                    return TypeElement.Normal;
                case "Poison":
                    return TypeElement.Poison;
                case "Psychic":
                    return TypeElement.Psychic;
                case "Rock":
                    return TypeElement.Rock;
                case "Steel":
                    return TypeElement.Steel;
                case "Water":
                    return TypeElement.Water;
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
                case TypeElement.Bug:
                    serializer.Serialize(writer, "Bug");
                    return;
                case TypeElement.Dark:
                    serializer.Serialize(writer, "Dark");
                    return;
                case TypeElement.Dragon:
                    serializer.Serialize(writer, "Dragon");
                    return;
                case TypeElement.Electric:
                    serializer.Serialize(writer, "Electric");
                    return;
                case TypeElement.Fairy:
                    serializer.Serialize(writer, "Fairy");
                    return;
                case TypeElement.Fighting:
                    serializer.Serialize(writer, "Fighting");
                    return;
                case TypeElement.Fire:
                    serializer.Serialize(writer, "Fire");
                    return;
                case TypeElement.Flying:
                    serializer.Serialize(writer, "Flying");
                    return;
                case TypeElement.Ghost:
                    serializer.Serialize(writer, "Ghost");
                    return;
                case TypeElement.Grass:
                    serializer.Serialize(writer, "Grass");
                    return;
                case TypeElement.Ground:
                    serializer.Serialize(writer, "Ground");
                    return;
                case TypeElement.Ice:
                    serializer.Serialize(writer, "Ice");
                    return;
                case TypeElement.None:
                    serializer.Serialize(writer, "None");
                    return;
                case TypeElement.Normal:
                    serializer.Serialize(writer, "Normal");
                    return;
                case TypeElement.Poison:
                    serializer.Serialize(writer, "Poison");
                    return;
                case TypeElement.Psychic:
                    serializer.Serialize(writer, "Psychic");
                    return;
                case TypeElement.Rock:
                    serializer.Serialize(writer, "Rock");
                    return;
                case TypeElement.Steel:
                    serializer.Serialize(writer, "Steel");
                    return;
                case TypeElement.Water:
                    serializer.Serialize(writer, "Water");
                    return;
            }
            throw new Exception("Cannot marshal type TypeElement");
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
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
