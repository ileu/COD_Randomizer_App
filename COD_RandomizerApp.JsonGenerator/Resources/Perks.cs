using COD_Randomizer_App.JsonGenerator.Factories;
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
            Factory.AddToGroup("FMJ", Id.PerksMW);
            Factory.AddToGroup("Heavy Hitter", Id.PerksMW);
            Factory.AddToGroup("Recon", Id.PerksMW);
            Factory.AddToGroup("Frangible - Wounding", Id.PerksMW);
            Factory.AddToGroup("Mo' Money", Id.PerksMW);
            Factory.AddToGroup("Fully Loaded", Id.PerksMW);
            Factory.AddToGroup("Sleight of Hand", Id.PerksMW);
            Factory.AddToGroup("Fast Melee", Id.PerksMW);
            Factory.AddToGroup("Burst", Id.PerksMW);
            Factory.AddToGroup("Frangible - Disabling", Id.PerksMW);
            Factory.AddToGroup("Presence of Mind", Id.PerksMW);
        }
    }
}
