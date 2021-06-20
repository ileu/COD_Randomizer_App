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
            List<Id> FlashGuardList = new List<Id> { Id.MuzzleAssault, Id.MuzzleOden };
            List<Id> TacticalSupressorList = new List<Id> {Id.MuzzleAssault, Id.MuzzleOden};
            List<Id> CompensatorList = new List<Id> {Id.MuzzleAssault, Id.MuzzleOden};
            List<Id> MuzzleBrakeList = new List<Id> {Id.MuzzleAssault, Id.MuzzleOden};
            List<Id> MonolithicSuppressorList = new List<Id> {Id.MuzzleAssault, Id.MuzzleOden};


            Factory.AddToGroup("Flash Guard", FlashGuardList);
            Factory.AddToGroup("Tactical Suppressor", TacticalSupressorList);
            Factory.AddToGroup("Breacher Device", Id.MuzzleAssault);
            Factory.AddToGroup("Muzzle Brake", MuzzleBrakeList);
            Factory.AddToGroup("Lightweight Suppressor", Id.MuzzleAssault);
            Factory.AddToGroup("Compensator", CompensatorList);
            Factory.AddToGroup("Monolithic Suppressor", MonolithicSuppressorList);
            Factory.AddToGroup("CQB Breacher Device", Id.MuzzleOden);
            Factory.AddToGroup("Collosus Suppressor", Id.MuzzleOden);

        }
    }
}
