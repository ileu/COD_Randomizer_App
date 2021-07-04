using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Underbarrel
    {
        public static void Create()
        {
            Factory.AddToGroup("Commando Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("M203 40mm Concussive", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("Merc Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("M203 40mm Smokescreen", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("12 Gauge Deputy", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("M203 40mm Recon", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("M203 40mm High-explosive", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("M203 40mm Flash", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("Tactical Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7);
            Factory.AddToGroup("M203 40mm Incendiary", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelRam7, Id.UnderbarrelGrau);
            Factory.AddToGroup("Operator Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelScar, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("Ranger Foregrip", Id.UnderbarrelAssault, Id.UnderbarrelAK47MW, Id.UnderbarrelRam7, Id.UnderbarrelGrau, Id.UnderbarrelVal);
            Factory.AddToGroup("Bipod", Id.UnderbarrelAssault, Id.UnderbarrelAK47MW, Id.UnderbarrelVal);

            Factory.AddToGroup("Bipod Foregrip", Id.UnderbarrelScar);
            Factory.AddToGroup("Cronen Shark II", Id.UnderbarrelGrau, Id.UnderbarrelVal);

            Factory.AddToGroup("GP25 40mm High-explosive", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Smokescreen", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Incendiary", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Concussive", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Flash", Id.UnderbarrelAK47MW);
            Factory.AddToGroup("GP25 40mm Recon", Id.UnderbarrelAK47MW);

            Factory.AddToGroup("Foregrip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelEastMP, Id.UnderbarrelWestMP);
            Factory.AddToGroup("Infiltrator Grip", Id.UnderbarrelWest, Id.UnderbarrelEast);
            Factory.AddToGroup("Bruiser Grip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelEastMP, Id.UnderbarrelWestMP);

            Factory.AddToGroup("Red Cell Foregrip", Id.UnderbarrelEastMP, Id.UnderbarrelWestMP);

            Factory.AddToGroup("Field Agent Grip", Id.UnderbarrelWest, Id.UnderbarrelWestMP);
            Factory.AddToGroup("Spetsnaz Grip", Id.UnderbarrelEast, Id.UnderbarrelEastMP);

            Factory.AddToGroup("Patrol Grip", Id.UnderbarrelWest, Id.UnderbarrelEast, Id.UnderbarrelEastMP, Id.UnderbarrelWestMP);

            Factory.AddToGroup("SFOD Speedgrip", Id.UnderbarrelWest, Id.UnderbarrelWestMP);
            Factory.AddToGroup("Spetsnaz Speedgrip", Id.UnderbarrelEast, Id.UnderbarrelEastMP);
        }
    }
}
