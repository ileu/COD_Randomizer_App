using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Underbarrel
    {
        public static void Create()
        {
            Factory.AddToGroup("Commando Foregrip", Id.UnderbarrelAssault);
            Factory.AddToGroup("M203 40mm Concussive", Id.UnderbarrelAssault);
            Factory.AddToGroup("Merc Foregrip", Id.UnderbarrelAssault);
            Factory.AddToGroup("M203 40mm Smokescreen", Id.UnderbarrelAssault);
            Factory.AddToGroup("12 Gauge Deputy", Id.UnderbarrelAssault);
            Factory.AddToGroup("M203 40mm Recon", Id.UnderbarrelAssault);
            Factory.AddToGroup("M203 40mm Highexplosive", Id.UnderbarrelAssault);
            Factory.AddToGroup("M203 40mm Flash", Id.UnderbarrelAssault);
            Factory.AddToGroup("Tactical Foregrip", Id.UnderbarrelAssault);
            Factory.AddToGroup("M203 40mm Incendiary", Id.UnderbarrelAssault);
            Factory.AddToGroup("Operator Foregrip", Id.UnderbarrelAssault);
            Factory.AddToGroup("Ranger Foregrip", Id.UnderbarrelAssault);
            Factory.AddToGroup("Bipod", Id.UnderbarrelAssault);
        }
    }
}
