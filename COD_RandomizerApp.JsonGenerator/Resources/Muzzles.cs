﻿using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Muzzles
    {
        public static void Create()
        {
            Factory.AddToGroup("Flash Guard", Id.MuzzleAssault, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94);
            Factory.AddToGroup("Tactical Suppressor", Id.MuzzleAssault, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94);
            Factory.AddToGroup("Breacher Device", Id.MuzzleAssault);
            Factory.AddToGroup("Muzzle Brake", Id.MuzzleAssault, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax);
            Factory.AddToGroup("Lightweight Suppressor", Id.MuzzleAssault, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94);

            Factory.AddToGroup("Compensator", Id.MuzzleAssault, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94);
            Factory.AddToGroup("Monolithic Suppressor", Id.MuzzleAssault, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94);
            Factory.AddToGroup("CQB Breacher Device", Id.MuzzleOden);
            Factory.AddToGroup("Collosus Suppressor", Id.MuzzleOden);

            Factory.AddToGroup("Bayonet", Id.MuzzleAK47MW);
            Factory.AddToGroup("AN-94 Sonic Brake", Id.MuzzleAn94);

            Factory.AddToGroup("Muzzle Brake 5.56", Id.MuzzleWest556, Id.MuzzleEast556);
            Factory.AddToGroup("Flashguard 5.56", Id.MuzzleWest556, Id.MuzzleEast556);

            Factory.AddToGroup("Muzzle Brake 7.62", Id.MuzzleEast, Id.MuzzleWest762);
            Factory.AddToGroup("Flashguard 7.62", Id.MuzzleEast, Id.MuzzleWest762);

            Factory.AddToGroup("Muzzle Brake 9", Id.MuzzleEast9, Id.MuzzleWest9);
            Factory.AddToGroup("Flashguard 9", Id.MuzzleEast9, Id.MuzzleWest9);

            Factory.AddToGroup("Muzzle Brake .45 APC", Id.MuzzleEast45, Id.MuzzleWest45);
            Factory.AddToGroup("Flashguard .45 APC", Id.MuzzleEast45, Id.MuzzleWest45);

            Factory.AddToGroup("Muzzle Brake 5.45", Id.MuzzleEast545);
            Factory.AddToGroup("Flashguard 5.45", Id.MuzzleEast545);

            Factory.AddToGroup("Suppressor", Id.MuzzleWest556, Id.MuzzleEast, Id.MuzzleEast556, Id.MuzzleWest762);
            Factory.AddToGroup("Sound Suppressor", Id.MuzzleEast9, Id.MuzzleWest9, Id.MuzzleEast45, Id.MuzzleWest45, Id.MuzzleEast545, Id.MuzzleStreetsweeper, Id.MuzzleGallo);

            Factory.AddToGroup("Infantry Compensator", Id.MuzzleWest556, Id.MuzzleWest762, Id.MuzzleWest9, Id.MuzzleWest45);
            Factory.AddToGroup("SOCOM Eliminator", Id.MuzzleWest556, Id.MuzzleWest762, Id.MuzzleWest9, Id.MuzzleWest45);
            Factory.AddToGroup("Agency Suppressor", Id.MuzzleWest556, Id.MuzzleWest762, Id.MuzzleWest9, Id.MuzzleWest45);

            Factory.AddToGroup("Spetsnaz Compensator", Id.MuzzleEast, Id.MuzzleEast556, Id.MuzzleEast9, Id.MuzzleEast45, Id.MuzzleEast545);
            Factory.AddToGroup("KGB Eliminator", Id.MuzzleEast, Id.MuzzleEast556, Id.MuzzleEast9, Id.MuzzleEast45, Id.MuzzleEast545);
            Factory.AddToGroup("GRU Suppressor", Id.MuzzleEast, Id.MuzzleEast556, Id.MuzzleEast9, Id.MuzzleEast45, Id.MuzzleEast545);

            Factory.AddToGroup("Duckbill Choke", Id.MuzzleStreetsweeper, Id.MuzzleGallo);
            Factory.AddToGroup("Regulator", Id.MuzzleStreetsweeper);
            Factory.AddToGroup("Flash Cone 12 Ga", Id.MuzzleGallo);
            Factory.AddToGroup("Infantry V-Choke", Id.MuzzleStreetsweeper, Id.MuzzleGallo);

            Factory.AddToGroup("SOCOM Blast Mitigator", Id.MuzzleStreetsweeper, Id.MuzzleGallo);
            Factory.AddToGroup("Agency Choke", Id.MuzzleStreetsweeper, Id.MuzzleGallo);
        }
    }
}
