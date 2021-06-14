using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Models
{
    public class MotherLoadout
    {
        public List<Weapon> Primaries { get; set; } = new List<Weapon>();
        public List<Weapon> Secondaries { get; set; } = new List<Weapon>();

        public List<Grenade> Lethals { get; set; } = new List<Grenade>();
        public List<Grenade> Tacticals { get; set; } = new List<Grenade>();

        public List<Perk> Perks1 { get; set; } = new List<Perk>();
        public List<Perk> Perks2 { get; set; } = new List<Perk>();
        public List<Perk> Perks3 { get; set; } = new List<Perk>();
    }
}
