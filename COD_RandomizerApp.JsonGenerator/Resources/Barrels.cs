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

            Factory.AddToGroup("11.8\" Extended", Id.BarrelXM4);
            Factory.AddToGroup("12.5\" Cavalry Lancer", Id.BarrelXM4);
            Factory.AddToGroup("13.5\" Reinforced Heavy", Id.BarrelXM4);
            Factory.AddToGroup("13.7\" Ranger", Id.BarrelXM4);
            Factory.AddToGroup("13.7\" Takedown", Id.BarrelXM4);
            Factory.AddToGroup("13.5\" Task Force", Id.BarrelXM4);

            Factory.AddToGroup("13.7\" Ultralight", Id.BarrelQBZ);
            Factory.AddToGroup("13.7\" Cavalry Lancer", Id.BarrelQBZ);
            Factory.AddToGroup("15.5\" Reinforced Heavy", Id.BarrelQBZ);
            Factory.AddToGroup("16.5\" Ranger", Id.BarrelQBZ);
            Factory.AddToGroup("15.5\" Takedown", Id.BarrelQBZ);
            Factory.AddToGroup("15.5\" Task Force", Id.BarrelQBZ);

            Factory.AddToGroup("16.5\" Ultralight", Id.BarrelKrig);
            Factory.AddToGroup("17.7\" Cavalry Lancer", Id.BarrelKrig);
            Factory.AddToGroup("15.5\" Contour", Id.BarrelKrig);
            Factory.AddToGroup("19.7\" Ranger", Id.BarrelKrig);
            Factory.AddToGroup("19.7\" Takedown", Id.BarrelKrig);
            Factory.AddToGroup("15\" CMV Mil-Spec", Id.BarrelKrig);

            Factory.AddToGroup("15.5\" Ultralight", Id.BarrelAk47);
            Factory.AddToGroup("16.5\" Cavalry Lancer", Id.BarrelAk47);
            Factory.AddToGroup("18.2\" VDV Reinforced", Id.BarrelAk47);
            Factory.AddToGroup("20\" Liberator", Id.BarrelAk47);
            Factory.AddToGroup("18.2\" Takedown", Id.BarrelAk47);
            Factory.AddToGroup("20\" Spetzsnaz RPK Barrel", Id.BarrelAk47);

            Factory.AddToGroup("15.3\" Ultralight", Id.BarrelGroza);
            Factory.AddToGroup("16.2\" Cavalry Lancer", Id.BarrelGroza);
            Factory.AddToGroup("16.7\" VDV Reinforced", Id.BarrelGroza);
            Factory.AddToGroup("16.2\" GRU Composite", Id.BarrelGroza);
            Factory.AddToGroup("15.7\" Contour M2", Id.BarrelGroza);
            Factory.AddToGroup("16.5\" CMV Mil-Spec", Id.BarrelGroza);

            Factory.AddToGroup("14.8\" Ultralight", Id.BarrelFara);
            Factory.AddToGroup("15.9\" Cavalry Lancer", Id.BarrelFara);
            Factory.AddToGroup("17.5\" VDV Reinforced", Id.BarrelFara);
            Factory.AddToGroup("19.5\" Liberator", Id.BarrelFara);
            Factory.AddToGroup("18.1\" Takedown", Id.BarrelFara);
            Factory.AddToGroup("18.7\" Spetzsnaz RPK Barrel", Id.BarrelFara);

            Factory.AddToGroup("15.6\" Ultralight", Id.BarrelC58);
            Factory.AddToGroup("15.2\" Cavalry Lancer", Id.BarrelC58);
            Factory.AddToGroup("18.7\" Reinforced Heavy", Id.BarrelC58);
            Factory.AddToGroup("18.7\" Ranger", Id.BarrelC58);
            Factory.AddToGroup("18.2\" Takedown", Id.BarrelC58);
            Factory.AddToGroup("18.5\" Task Force", Id.BarrelC58);

            Factory.AddToGroup("17.9\" Ultralight", Id.BarrelFFAR);
            Factory.AddToGroup("18.7\" Cavalry Lancer", Id.BarrelFFAR);
            Factory.AddToGroup("19.5\" Reinforced Heavy", Id.BarrelFFAR);
            Factory.AddToGroup("21.2\" Ranger", Id.BarrelFFAR);
            Factory.AddToGroup("20.3\" Takedown", Id.BarrelFFAR);
            Factory.AddToGroup("19.5\" Task Force", Id.BarrelFFAR);


        }
    }
}

