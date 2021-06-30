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

            Factory.AddToGroup("Muzzle Brake 5.56", Id.MuzzleWest, Id.MuzzleEast5);
            Factory.AddToGroup("Flashguard 5.56", Id.MuzzleWest, Id.MuzzleEast5);

            Factory.AddToGroup("Muzzle Brake 7.62", Id.MuzzleEast, Id.MuzzleWest7);
            Factory.AddToGroup("Flashguard 7.62", Id.MuzzleEast, Id.MuzzleWest7);

            Factory.AddToGroup("Suppressor", Id.MuzzleWest, Id.MuzzleEast, Id.MuzzleEast5, Id.MuzzleWest7);
            Factory.AddToGroup("Infantry Compensator", Id.MuzzleWest, Id.MuzzleWest7);
            Factory.AddToGroup("SOCOM Eliminator", Id.MuzzleWest, Id.MuzzleWest7);
            Factory.AddToGroup("Agency Suppressor", Id.MuzzleWest, Id.MuzzleWest7);

            Factory.AddToGroup("Spetsnaz Compensator", Id.MuzzleEast, Id.MuzzleEast5);
            Factory.AddToGroup("KGB Eliminator", Id.MuzzleEast, Id.MuzzleEast5);
            Factory.AddToGroup("GRU Suppressor", Id.MuzzleEast, Id.MuzzleEast5);
        }
    }
}
