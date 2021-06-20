using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{

    public static class Barrels
    {
        public static void Create()
        {
            Factory.AddToGroup("Singuard Arms 16.6\" SOCOM", Id.BarrelKilo);
            Factory.AddToGroup("Singuard Arms 19.8\" Prowler", Id.BarrelKilo);
            Factory.AddToGroup("Singuard Arms Whisper", Id.BarrelKilo);
            Factory.AddToGroup("Oden Factory 810mm", Id.BarrelOden);
            Factory.AddToGroup("Oden Factory 730mm", Id.BarrelOden);
            Factory.AddToGroup("Oden Factory 420mm", Id.BarrelOden);
            Factory.AddToGroup("FFS 11.5 Commando", Id.BarrelM4A1);
            Factory.AddToGroup("Stock M16 Grenadier", Id.BarrelM4A1);
            Factory.AddToGroup("FFS 14.5 Tac Lite", Id.BarrelM4A1);
            Factory.AddToGroup("Corvus Custom Marksman", Id.BarrelM4A1);
            Factory.AddToGroup("FFS 12.4 Predator", Id.BarrelM4A1);

        }
    }
}

