﻿using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Perks
    {
        public static void Create()
        {
            Factory.AddToGroup("FMJ", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Heavy Hitter", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Recon", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Frangible - Wounding", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Mo' Money", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Fully Loaded", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Sleight of Hand", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Fast Melee", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Burst", Id.PerksMW);
            Factory.AddToGroup("Frangible - Disabling", Id.PerksMW, Id.PerksScar, Id.PerksNoBurst);
            Factory.AddToGroup("Presence of Mind", Id.PerksMW, Id.PerksNoBurst);
        }
    }
}