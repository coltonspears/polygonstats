using Google.Protobuf.Collections;
using POGOProtos.Rpc;
using Pokebox.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebox
{
    public class PokeboxEntryManager
    {
        
        public void AddPokeboxToDatabase(Guid extractId, RepeatedField<global::POGOProtos.Rpc.InventoryItemProto> inventoryItem)
        {
            Log.Information($"[Pokebox] Saving Pokemon Storage Snapshot with id: {extractId}");
            using (var context = new PokeboxContext())
            {
                foreach (InventoryItemProto item in inventoryItem)
                {
                    if (item.InventoryItemData?.Pokemon != null)
                    {

                        PokemonProto pokemon = item.InventoryItemData?.Pokemon;
                        if (pokemon.Cp > 0)
                        {
                            PokeboxEntry pokeboxEntry = new PokeboxEntry { ExtractId = extractId, timestamp = DateTime.UtcNow };

                            pokeboxEntry.PokemonUniqueId = pokemon.Id;
                            pokeboxEntry.PokemonId = pokemon.PokemonId;
                            pokeboxEntry.CP = pokemon.Cp;

                            pokeboxEntry.Stamina = pokemon.Stamina;
                            pokeboxEntry.MaxStamina = pokemon.MaxStamina;
                            pokeboxEntry.IndividualAttack = pokemon.IndividualAttack;
                            pokeboxEntry.IndividualDefense = pokemon.IndividualDefense;
                            pokeboxEntry.IndividualStamina = pokemon.IndividualStamina;
                            pokeboxEntry.Move1 = pokemon.Move1;
                            pokeboxEntry.Move2 = pokemon.Move2;
                            pokeboxEntry.Move3 = pokemon.Move3;
                            pokeboxEntry.IsLucky = pokemon.IsLucky;
                            if (pokemon.PokemonDisplay != null)
                            {
                                pokeboxEntry.IsShadow = pokemon.PokemonDisplay.Alignment == PokemonDisplayProto.Types.Alignment.Shadow;
                                pokeboxEntry.Gender = pokemon.PokemonDisplay.Gender;
                                pokeboxEntry.IsShiny = pokemon.PokemonDisplay.Shiny;
                            }
                            context.PokeboxEntries.Add(pokeboxEntry);
                        }
                    }
                    context.SaveChanges();
                }
            }
            Log.Information($"[Pokebox] Completed Pokemon Storage Snapshot with id: {extractId}");
        }
    }
}
