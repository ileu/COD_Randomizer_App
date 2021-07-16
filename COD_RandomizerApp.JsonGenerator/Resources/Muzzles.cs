using COD_Randomizer_App.JsonGenerator.Factories;
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
            Factory.AddToGroup("Flash Guard", Id.MuzzleStandard, Id.MuzzleModel680, Id.MuzzleOrigin, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94, Id.MuzzleCQBBreacher, Id.MuzzleFennec);
            Factory.AddToGroup("Tactical Suppressor", Id.MuzzleStandard, Id.MuzzleModel680, Id.MuzzleOrigin, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94, Id.MuzzleFennec, Id.MuzzleCQBBreacher);
            Factory.AddToGroup("Breacher Device", Id.MuzzleStandard, Id.MuzzleModel680, Id.MuzzleOrigin);
            Factory.AddToGroup("Muzzle Brake", Id.MuzzleStandard, Id.MuzzleModel680, Id.MuzzleOrigin, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleCQBBreacher, Id.MuzzleFennec);
            Factory.AddToGroup("Lightweight Suppressor", Id.MuzzleStandard, Id.MuzzleOrigin, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94, Id.MuzzleCQBBreacher);

            Factory.AddToGroup("Compensator", Id.MuzzleStandard, Id.MuzzleModel680, Id.MuzzleOrigin, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94, Id.MuzzleFennec, Id.MuzzleFennec, Id.MuzzleCQBBreacher);
            Factory.AddToGroup("Monolithic Suppressor", Id.MuzzleStandard, Id.MuzzleModel680, Id.MuzzleOrigin, Id.MuzzleOden, Id.MuzzleFAL, Id.MuzzleFR556, Id.MuzzleAK47MW, Id.MuzzleAmax, Id.MuzzleAn94, Id.MuzzleCQBBreacher);
            Factory.AddToGroup("CQB Breacher Device", Id.MuzzleOden, Id.MuzzleCQBBreacher, Id.MuzzleFennec);
            Factory.AddToGroup("Collosus Suppressor", Id.MuzzleOden);

            Factory.AddToGroup("Choke", Id.MuzzleModel680, Id.MuzzleOrigin);
            Factory.AddToGroup("FORGE TAC Marauder", Id.MuzzleModel680);

            Factory.AddToGroup("Bayonet", Id.MuzzleAK47MW);
            Factory.AddToGroup("AN-94 Sonic Brake", Id.MuzzleAn94);

            Factory.AddToGroup("ZLR Sabre", Id.MuzzleFennec);

            Factory.AddToGroup("Muzzle Brake 5.56", Id.MuzzleWest556, Id.MuzzleEast556);
            Factory.AddToGroup("Flash Guard 5.56", Id.MuzzleWest556, Id.MuzzleEast556);

            Factory.AddToGroup("Muzzle Brake 7.62", Id.MuzzleEast762, Id.MuzzleWest762);
            Factory.AddToGroup("Flash Guard 7.62", Id.MuzzleEast762, Id.MuzzleWest762);

            Factory.AddToGroup("Muzzle Brake 9", Id.MuzzleEast9, Id.MuzzleWest9);
            Factory.AddToGroup("Flash Guard 9", Id.MuzzleEast9, Id.MuzzleWest9);

            Factory.AddToGroup("Muzzle Brake .45 APC", Id.MuzzleEast45, Id.MuzzleWest45);
            Factory.AddToGroup("Flash Guard .45 APC", Id.MuzzleEast45, Id.MuzzleWest45);

            Factory.AddToGroup("Muzzle Brake 5.45", Id.MuzzleEast545);
            Factory.AddToGroup("Flash Guard 5.45", Id.MuzzleEast545);

            Factory.AddToGroup("Muzzle Brake 4.73", Id.MuzzleWest473);
            Factory.AddToGroup("Flash Guard 4.73", Id.MuzzleWest473);

            Factory.AddToGroup("Stabilizer .308", Id.MuzzleWest308);
            Factory.AddToGroup("Flash Hider .308", Id.MuzzleWest308);

            Factory.AddToGroup("Stabilizer 20", Id.MuzzleWest20);
            Factory.AddToGroup("Flash Hider 20", Id.MuzzleWest20);

            Factory.AddToGroup("Stabilizer 7.5", Id.MuzzleEast75);
            Factory.AddToGroup("Flash Hider 7.5", Id.MuzzleEast75);

            Factory.AddToGroup("Stabilizer .50 BMG", Id.MuzzleWest50);
            Factory.AddToGroup("Flash Hider .50 BMG", Id.MuzzleWest50);

            Factory.AddToGroup("Suppressor", Id.MuzzleWest556, Id.MuzzleEast762, Id.MuzzleEast556, Id.MuzzleWest762);
            Factory.AddToGroup("Sound Suppressor", Id.MuzzleEast9, Id.MuzzleWest9, Id.MuzzleEast45, Id.MuzzleWest45, Id.MuzzleEast545, Id.MuzzleStreetsweeper, Id.MuzzleGallo);
            Factory.AddToGroup("Silencer", Id.MuzzleWest473);
            Factory.AddToGroup("Sound Moderator", Id.MuzzleWest308, Id.MuzzleWest20, Id.MuzzleEast75, Id.MuzzleWest50);

            Factory.AddToGroup("Infantry Compensator", Id.MuzzleWest556, Id.MuzzleWest762, Id.MuzzleWest9, Id.MuzzleWest45, Id.MuzzleWest473, Id.MuzzleWest308);
            Factory.AddToGroup("Infantry Stabilizer", Id.MuzzleWest20, Id.MuzzleEast75, Id.MuzzleWest50);

            Factory.AddToGroup("SOCOM Eliminator", Id.MuzzleWest556, Id.MuzzleWest762, Id.MuzzleWest9, Id.MuzzleWest45, Id.MuzzleWest473);
            Factory.AddToGroup("Agency Suppressor", Id.MuzzleWest556, Id.MuzzleWest762, Id.MuzzleWest9, Id.MuzzleWest45, Id.MuzzleWest473);

            Factory.AddToGroup("Task Force Shroud", Id.MuzzleWest308, Id.MuzzleWest20, Id.MuzzleEast75, Id.MuzzleWest50);
            Factory.AddToGroup("Wrapped Suppressor", Id.MuzzleWest308, Id.MuzzleWest20, Id.MuzzleWest50);

            Factory.AddToGroup("Spetsnaz Compensator", Id.MuzzleEast762, Id.MuzzleEast556, Id.MuzzleEast9, Id.MuzzleEast45, Id.MuzzleEast545);
            Factory.AddToGroup("KGB Eliminator", Id.MuzzleEast762, Id.MuzzleEast556, Id.MuzzleEast9, Id.MuzzleEast45, Id.MuzzleEast545);
            Factory.AddToGroup("GRU Suppressor", Id.MuzzleEast762, Id.MuzzleEast556, Id.MuzzleEast9, Id.MuzzleEast45, Id.MuzzleEast545, Id.MuzzleEast75);

            Factory.AddToGroup("Duckbill Choke", Id.MuzzleStreetsweeper, Id.MuzzleGallo);
            Factory.AddToGroup("Regulator", Id.MuzzleStreetsweeper);
            Factory.AddToGroup("Flash Cone 12 Ga", Id.MuzzleGallo);
            Factory.AddToGroup("Infantry V-Choke", Id.MuzzleStreetsweeper, Id.MuzzleGallo);

            Factory.AddToGroup("SOCOM Blast Mitigator", Id.MuzzleStreetsweeper, Id.MuzzleGallo);
            Factory.AddToGroup("Agency Choke", Id.MuzzleStreetsweeper, Id.MuzzleGallo);
        }
    }
}
