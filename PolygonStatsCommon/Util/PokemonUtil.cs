using PolygonStats.Common.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStatsCommon.Util
{
    public class PokemonUtil
    {
        public static bool IsShundo(PokemonProto poke)
        {
            return poke.IndividualAttack == 15 &&
                   poke.IndividualDefense == 15 &&
                   poke.IndividualStamina == 15;
        }
    }
    public static class PokemonExtensions
    {
        public static bool IsHundo(this PokemonProto poke)
        {
            return poke.IndividualAttack == 15 &&
                   poke.IndividualDefense == 15 &&
                   poke.IndividualStamina == 15;
        }
        public static bool IsShundo(this PokemonProto poke)
        {
            return poke.IsHundo() && poke.PokemonDisplay.Shiny;
        }
    }
}
