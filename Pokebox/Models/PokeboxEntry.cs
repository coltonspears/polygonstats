using POGOProtos.Rpc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebox.Models
{
    [Table("PokeboxEntry")]
    public class PokeboxEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Guid ExtractId { get; set; }
        [Required]
        public ulong PokemonUniqueId { get; set; }
        [Required]
        [MaxLength(50)]
        public POGOProtos.Rpc.HoloPokemonId PokemonId { get; set; }
        [DefaultValue(0)]
        public int CP { get; set; }
        [DefaultValue(0)]
        public int Stamina { get; set; }
        [DefaultValue(0)]
        public int MaxStamina { get; set; }
        [DefaultValue(0)]
        public HoloPokemonMove Move1 { get; set; }
        [DefaultValue(0)]
        public HoloPokemonMove Move2 { get; set; }
        [DefaultValue(0)]
        public HoloPokemonMove Move3 { get; set; }
        [DefaultValue(0)]
        public int IndividualAttack { get; set; }
        [DefaultValue(0)]
        public int IndividualDefense { get; set; }
        [DefaultValue(0)]
        public int IndividualStamina { get; set; }
        [DefaultValue(0)]
        public PokemonDisplayProto.Types.Gender Gender { get; set; }
        [DefaultValue(false)]
        public bool IsShiny { get; set; }
        [DefaultValue(false)]
        public bool IsLucky { get; set; }
        [DefaultValue(false)]
        public bool IsShadow { get; set; }
        [Required]
        public DateTime timestamp { get; set; }
    }
}
