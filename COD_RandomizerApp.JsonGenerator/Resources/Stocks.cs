﻿using COD_Randomizer_App.JsonGenerator.Models;
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
            Factory.AddToGroup("FORGE TAC Ultralight", Id.StockKilo, Id.StockAK47MW, Id.StockAn94);
            Factory.AddToGroup("Singuard Arms Sniper Pro", Id.StockKilo);
            Factory.AddToGroup("No Stock", Id.StockKilo, Id.StockM4A1, Id.StockM13, Id.StockFAL, Id.StockAK47MW, Id.StockGrau, Id.StockAmax);
            Factory.AddToGroup("FSS Close Quarters Stock", Id.StockKilo, Id.StockFAL, Id.StockScar, Id.StockAK47MW, Id.StockAmax, Id.StockAn94);

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