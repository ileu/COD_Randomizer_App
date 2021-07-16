using COD_Randomizer_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class Loadout
    {
        public string Id { get; set; }

        public Weapon Primary { get; set; }
        public Weapon Secondary { get; set; }

        public Grenade Lethal { get; set; }
        public Grenade Tactical { get; set; }

        public Perk Perk1 { get; set; }
        public Perk Perk2 { get; set; }
        public Perk Perk3 { get; set; }
    }
}
