using POGOProtos.Rpc;
using Pokedex.Models;
using PolygonStats.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PokedexEntryManager
    {
        private Guid mSnapshotId;
        private int mAccountId;
        private PokedexEntryProto mEntry;
        private PokedexContext mPokedexContext;


        public PokedexEntryManager()
        {
            mPokedexContext = new PokedexContext();
        }

        public void Process(int AccountId, PokedexEntryProto entry)
        {
            mSnapshotId = Guid.NewGuid();
            mAccountId = AccountId;
            mEntry = entry;

            BeginSnapshot();
            ProcessPokedexCategories();
            AddPokedexEntry();
            EndSnapshot();
        }
        public void BeginSnapshot()
        {
            using var context = new PokedexContext();
            Snapshot snapshot = new Snapshot()
            {
                SnapshotId = mSnapshotId,
                AccountId = mAccountId
            };
            context.Snapshot.Add(snapshot);
            context.SaveChanges();

        }
        public void EndSnapshot()
        {
            using var context = new PokedexContext();
            var snapshot = context.Snapshot.AsQueryable().Where(x => x.SnapshotId == mSnapshotId).First();

            snapshot.DateEnd = DateTime.UtcNow;
            context.Update(snapshot);
        }
        public void ProcessPokedexCategories()
        {
            //using var context = new PokedexContext();
            //var dexCategoryEntries = context.PokedexCategoryEntry.AsQueryable().Where(x => x.AccountId == mAccountId);

            //foreach (var dexCategory in mEntry.PokedexCategoryStatus)
            //{

            //    PokedexCategoryEntry pokedexCategoryEntry = new PokedexCategoryEntry()
            //    {
            //        AccountId = mAccountId,
            //        Category = dexCategory.Value.PokedexCategory,
            //        Acquired = dexCategory.Value.Acquired,
            //        Encountered = dexCategory.Value.Encountered
            //    };
            //    DbSetExtensions.Upsert<PokedexCategoryEntry>(context.PokedexCategoryEntry, pokedexCategoryEntry);
            //}
        }

        public void AddPokedexEntry()
        {
            using var context = new PokedexContext();
            PokedexEntry pokedexEntry = new() { 
                SnapshotId = mSnapshotId, 
                timestamp = DateTime.UtcNow,
                PokedexId = mEntry.PokedexEntryNumber,
                TimesEncountered = mEntry.TimesEncountered,
                TimesCaptured = mEntry.TimesCaptured,
                EvolutionStonePieces = mEntry.EvolutionStonePieces,
                EvolutionStones = mEntry.EvolutionStones,
                CapturedShiny = mEntry.CapturedShiny,
                EncounteredShiny = mEntry.EncounteredShiny,
                TimesLuckyReceived = mEntry.TimesLuckyReceived,
                TimesPurified = mEntry.TimesPurified
            };

            //foreach (var form in mEntry.CapturedCostumes)
            //{
            //    pokedexEntry.CapturedForms.Add(new PokedexEnum { EnumName = form.ToString(), EnumValue = (int)form });
            //}

            context.PokedexEntries.Add(pokedexEntry);
            context.SaveChanges();
        }
        
        public static void GetAllForms()
        {
            // ForeachPokemon
            // Foreach Form
            // Foreach Gender
            foreach (var pokemon in GameMasterData.Default.FullData.Pokemon)
            {
                using var context = new PokedexContext();

                //Pokemon pokemonEntry = new()
                //{
                //    PokedexId       = pokemon.Value.PokedexId,
                //    Name            = pokemon.Value.PokemonName,
                //    DefaultFormId   = pokemon.Value.DefaultFormId,
                //    Generation      = pokemon.Value.Generation,
                //    GenId           = pokemon.Value.GenId
                //}
                var pokemonEntry = context.Pokemon.AsQueryable().Where(x => x.PokedexId == pokemon.Value.PokedexId).First();
                if(pokemonEntry == null)
                {
                    context.Pokemon.Add(pokemon.Value);
                    context.SaveChanges();
                }
                

               // Console.WriteLine($"[{pokemon.Value.PokedexId}]\t{pokemon.Value.PokemonName} Forms");

                foreach (var form in pokemon.Value.Forms)
                {
                    // Console.Write($"{GameMasterData.Default.FullData.Forms[form.ToString()].FormName}: {pokemon.Value.PokedexId}:{form}");
                    if (form == pokemon.Value.DefaultFormId)
                    {
                        //Console.WriteLine($"");
                       // Console.Write("  [DEFAULT]");
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine();
            }
        }
    }


}
