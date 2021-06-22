using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Stocks
    {
        public static void Create()
        {
            Factory.AddToGroup("FORGE TAC Ultralight", Id.StockKilo);
            Factory.AddToGroup("Singuard Arms Sniper Pro", Id.StockKilo);
            Factory.AddToGroup("No Stock", Id.StockKilo, Id.StockM4A1, Id.StockM13, Id.StockFAL);
            Factory.AddToGroup("FSS Close Quarters Stock", Id.StockKilo, Id.StockFAL);

            Factory.AddToGroup("FORGE TAC Ballast Pack", Id.StockOden);
            Factory.AddToGroup("Oden Ultralight Hollow", Id.StockOden);
            Factory.AddToGroup("FTAC XL Elite Comb", Id.StockOden);

            Factory.AddToGroup("M-16 Stock", Id.StockM4A1);
            Factory.AddToGroup("Singuard Arms Invader", Id.StockM4A1);
            Factory.AddToGroup("Forge TAC CQS", Id.StockM4A1);

            Factory.AddToGroup("Forge TAC Stalker", Id.StockM13, Id.StockFAL);
            Factory.AddToGroup("FSS Close Quarters Stock", Id.StockM13);
            Factory.AddToGroup("M13 Skeleton Stock", Id.StockM13);

            Factory.AddToGroup("Factory 18\" Aluminum", Id.StockFAL);

            Factory.AddToGroup("Tactical Stock", Id.StockKrig,Id.StockXM4, Id.StockQBZ, Id.StockFara, Id.StockAK47, Id.StockC58, Id.StockFFAR, Id.StockGroza);

            Factory.AddToGroup("Wire Stock", Id.StockKrig, Id.StockAK47, Id.StockXM4, Id.StockFara);
            Factory.AddToGroup("Marathon Stock", Id.StockQBZ, Id.StockC58, Id.StockFFAR, Id.StockGroza);

            Factory.AddToGroup("Duster Stock", Id.StockKrig, Id.StockAK47, Id.StockXM4, Id.StockFara, Id.StockC58);
            Factory.AddToGroup("Duster Pad", Id.StockGroza, Id.StockFFAR, Id.StockQBZ);

            Factory.AddToGroup("No Stock", Id.StockAK47, Id.StockFara, Id.StockKrig);
            Factory.AddToGroup("CQB Stock", Id.StockC58);
            Factory.AddToGroup("CQB Pad", Id.StockQBZ, Id.StockFFAR, Id.StockGroza);
            Factory.AddToGroup("Buffer Tube", Id.StockXM4);

            Factory.AddToGroup("SAS Combat Stock", Id.StockKrig, Id.StockXM4,Id.StockQBZ, Id.StockC58, Id.StockFFAR);
            Factory.AddToGroup("Raider Pad", Id.StockXM4);
            Factory.AddToGroup("Raider Stock", Id.StockQBZ, Id.StockFara, Id.StockC58, Id.StockKrig, Id.StockFFAR);

            Factory.AddToGroup("Spetsnaz PKM Stock", Id.StockAK47, Id.StockGroza);
            Factory.AddToGroup("KGB Skeletal Stock", Id.StockAK47, Id.StockFara);
            Factory.AddToGroup("KGB Pad", Id.StockGroza);
            
        }
    }
}
