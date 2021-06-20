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
            Factory.AddToGroup("Flash Guard", Id.MuzzleAssault);
            Factory.AddToGroup("Tactical Suppressor", Id.MuzzleAssault);
            Factory.AddToGroup("Breacher Device", Id.MuzzleAssault);
            Factory.AddToGroup("Muzzle Brake", Id.MuzzleAssault);
            Factory.AddToGroup("Lightweight Suppressor", Id.MuzzleAssault);
            Factory.AddToGroup("Compensator", Id.MuzzleAssault);
            Factory.AddToGroup("Monolithic Suppressor", Id.MuzzleAssault);

            Factory.AddToGroup("Muzzle Brake 5.56", Id.MuzzleWest);
            Factory.AddToGroup("Flashguard 5.56", Id.MuzzleWest);
            Factory.AddToGroup("Suppressor", Id.MuzzleWest);
            Factory.AddToGroup("Infantry Compensator", Id.MuzzleWest);
            Factory.AddToGroup("SOCOM Eliminator", Id.MuzzleWest);
            Factory.AddToGroup("Agency Suppressor", Id.MuzzleWest);
        }
    }
}
