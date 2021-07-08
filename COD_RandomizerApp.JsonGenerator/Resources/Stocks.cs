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
            Factory.AddToGroup("FORGE TAC Ultralight", Id.StockKilo, Id.StockAK47MW, Id.StockAn94, Id.StockIso);
            Factory.AddToGroup("Singuard Arms Sniper Pro", Id.StockKilo);
            Factory.AddToGroup("No Stock", Id.StockKilo, Id.StockM4A1, Id.StockM13, Id.StockFAL, Id.StockAK47MW, Id.StockGrau, Id.StockAmax);
            Factory.AddToGroup("FSS Close Quarters Stock", Id.StockKilo, Id.StockFAL, Id.StockScar, Id.StockAK47MW, Id.StockAmax, Id.StockAn94);

            Factory.AddToGroup("FORGE TAC Ballast Pack", Id.StockOden);
            Factory.AddToGroup("Oden Ultralight Hollow", Id.StockOden);
            Factory.AddToGroup("FTAC XL Elite Comb", Id.StockOden);

            Factory.AddToGroup("M-16 Stock", Id.StockM4A1);
            Factory.AddToGroup("Singuard Arms Invader", Id.StockM4A1);
            Factory.AddToGroup("Forge TAC CQS", Id.StockM4A1);

            Factory.AddToGroup("Forge TAC Stalker", Id.StockM13, Id.StockFAL, Id.StockIso);
            Factory.AddToGroup("FSS Close Quarters Stock", Id.StockM13);
            Factory.AddToGroup("M13 Skeleton Stock", Id.StockM13);

            Factory.AddToGroup("Factory 18\" Aluminum", Id.StockFAL);
            Factory.AddToGroup("FTAC Hunter", Id.StockScar, Id.StockAmax);
            Factory.AddToGroup("FTAC Collapsible Stock", Id.StockScar);
            Factory.AddToGroup("XRK Obelisk Pro", Id.StockScar);

            Factory.AddToGroup("FR Ultralight Hollow", Id.StockFR556);
            Factory.AddToGroup("FORGE TAC Ballast Pack", Id.StockFR556);
            Factory.AddToGroup("FSS Tac-Wrap", Id.StockFR556);

            Factory.AddToGroup("Field LMG Stock", Id.StockAK47MW); 
            Factory.AddToGroup("Skeleton Stock", Id.StockAK47MW);

            Factory.AddToGroup("FTAC Equilibrium", Id.StockRam7);
            Factory.AddToGroup("XRK Ultralight Hollow", Id.StockRam7);
            Factory.AddToGroup("XRK Close Quarters Stock", Id.StockRam7);

            Factory.AddToGroup("FSS Blackjack", Id.StockGrau);
            Factory.AddToGroup("XRK StrikeLite III", Id.StockGrau);

            Factory.AddToGroup("FTAC Spartan", Id.StockAmax);
            Factory.AddToGroup("XRK Gatekeeper", Id.StockAmax);
            Factory.AddToGroup("CR-56 EXO", Id.StockAmax);

            Factory.AddToGroup("AN-94 Factory Heavy", Id.StockAn94);
            Factory.AddToGroup("Folded Stock", Id.StockAn94);
            Factory.AddToGroup("VLK PX-9 Pero", Id.StockAn94);

            Factory.AddToGroup("VLK Vintazh", Id.StockVal);
            Factory.AddToGroup("FSS Intl. Gen 4 GRU	", Id.StockVal);
            Factory.AddToGroup("Stovl 6P30 Skelet", Id.StockVal);
            Factory.AddToGroup("VLK Strelok", Id.StockVal);

            Factory.AddToGroup("FTAC Vagrant", Id.StockIso);
            Factory.AddToGroup("ISO Collapsible", Id.StockIso);

            Factory.AddToGroup("FTAC Ultralight Hollow", Id.StockAug);
            Factory.AddToGroup("FORGE TAC CQB Comb", Id.StockAug);
            Factory.AddToGroup("FSS Heavy Stock Pro", Id.StockAug);

            Factory.AddToGroup("FSS Guardian", Id.StockStriker);
            Factory.AddToGroup("FTAC Precision Fixed Stock", Id.StockStriker);
            Factory.AddToGroup("XRK Gen III Survivalist Series", Id.StockStriker);



            Factory.AddToGroup("Tactical Stock", Id.StockKrig,Id.StockXM4, Id.StockQBZ, Id.StockFara, Id.StockAK47CW, Id.StockC58, Id.StockFFAR,
                Id.StockGroza, Id.StockMilano, Id.StockPPSh, Id.StockMP9CW, Id.StockSGCW, Id.StockHauer, Id.StockM60, Id.StockStoner, Id.StockRPK);

            Factory.AddToGroup("Shotgun Stock", Id.StockHauer);
            Factory.AddToGroup("Wire Stock", Id.StockKrig, Id.StockAK47CW, Id.StockXM4, Id.StockFara, Id.StockMilano, Id.StockSGCW, Id.StockStoner, 
                Id.StockRPK);
            Factory.AddToGroup("Marathon Stock", Id.StockQBZ, Id.StockC58, Id.StockFFAR, Id.StockGroza, Id.StockMilano, Id.StockPPSh, Id.StockSGCW, 
                Id.StockHauer, Id.StockM60);
            Factory.AddToGroup("Collapsed Stock", Id.StockMP9CW);

            Factory.AddToGroup("Duster Stock", Id.StockKrig, Id.StockAK47CW, Id.StockXM4, Id.StockFara, Id.StockC58, Id.StockMilano, Id.StockPPSh, 
                Id.StockMP9CW, Id.StockSGCW, Id.StockM60, Id.StockRPK);
            Factory.AddToGroup("Duster Pad", Id.StockGroza, Id.StockFFAR, Id.StockQBZ, Id.StockHauer, Id.StockStoner);

            Factory.AddToGroup("No Stock", Id.StockAK47CW, Id.StockFara, Id.StockKrig, Id.StockMP9CW, Id.StockSGCW, Id.StockHauer, Id.StockM60, 
                Id.StockStoner, Id.StockRPK);
            Factory.AddToGroup("CQB Stock", Id.StockC58, Id.StockPPSh);
            Factory.AddToGroup("CQB Pad", Id.StockQBZ, Id.StockFFAR, Id.StockGroza);
            Factory.AddToGroup("Buffer Tube", Id.StockXM4);

            Factory.AddToGroup("SAS Combat Stock", Id.StockKrig, Id.StockXM4,Id.StockQBZ, Id.StockC58, Id.StockFFAR, Id.StockMilano, Id.StockMP9CW, 
                Id.StockSGCW, Id.StockHauer, Id.StockM60, Id.StockStoner);
            Factory.AddToGroup("Raider Pad", Id.StockXM4, Id.StockStoner);
            Factory.AddToGroup("Raider Stock", Id.StockQBZ, Id.StockFara, Id.StockC58, Id.StockKrig, Id.StockFFAR, Id.StockMilano, Id.StockPPSh,
                Id.StockMP9CW, Id.StockM60);

            Factory.AddToGroup("Spetsnaz PKM Stock", Id.StockAK47CW, Id.StockGroza, Id.StockPPSh, Id.StockRPK);
            Factory.AddToGroup("KGB Skeletal Stock", Id.StockAK47CW, Id.StockFara, Id.StockRPK);
            Factory.AddToGroup("KGB Pad", Id.StockGroza);
            
        }
    }
}
