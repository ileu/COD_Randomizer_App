using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Optics
    {
        public static void Create()
        {
            List<Id> OperatorReflexSightList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> CorpCombatHoloList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> SolozoeroOpticsMiniList = new List<Id> { Id.OpticMW, Id.OpticOden };
            List<Id> AimOpReflexList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> APX5HoloList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> VLK3xList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> ViperReflexList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> SniperScopeList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> SolozeroNVGList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> PBXHoloList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> MonocleReflexList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> GIMiniReflexList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> IntegralHybridList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> ScoutCombatList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> MercThermalList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> ThermalHybridList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> CronenC480List = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> CantedHybridList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> VarZoomList = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> CronenLP945List = new List<Id> { Id.OpticMW, Id.OpticOden, Id.OpticM4A1 };
            List<Id> FlipHybrid4xList = new List<Id> { Id.OpticMW, Id.OpticM4A1 };

            Factory.AddToGroup("4.0x Flip Hybrid", FlipHybrid4xList);
            Factory.AddToGroup("Aim-Op Reflex Sight", AimOpReflexList);
            Factory.AddToGroup("APX5 Holographic Sight", APX5HoloList);
            Factory.AddToGroup("Canted Hybrid", CantedHybridList);
            Factory.AddToGroup("Corp Combat Holo Sight", CorpCombatHoloList);
            Factory.AddToGroup("Cronen C480 Pro Optic", CronenC480List);
            Factory.AddToGroup("Cronen LP945 Mini Reflex", CronenLP945List);
            Factory.AddToGroup("Operator Reflex Sight", OperatorReflexSightList);
            Factory.AddToGroup("G.I Mini Reflex", GIMiniReflexList);
            Factory.AddToGroup("Scout Combat Optic", ScoutCombatList);
            Factory.AddToGroup("VLK 3.0x Optic", VLK3xList);
            Factory.AddToGroup("Integral Hybrid", IntegralHybridList);
            Factory.AddToGroup("Viper Reflex Sight", ViperReflexList);
            Factory.AddToGroup("Solozero NVG Enhanced", SolozeroNVGList);
            Factory.AddToGroup("Monocle Reflex Sight", MonocleReflexList);
            Factory.AddToGroup("Sniper Scope", SniperScopeList);
            Factory.AddToGroup("Merc Thermal Optic", MercThermalList);
            Factory.AddToGroup("PBX Holo 7 Sight", PBXHoloList);
            Factory.AddToGroup("Thermal Hybrid", ThermalHybridList);
            Factory.AddToGroup("Solozero Optics Mini Reflex", SolozoeroOpticsMiniList);
            Factory.AddToGroup("Variable Zoom Scope", VarZoomList);
        }
    }
}
