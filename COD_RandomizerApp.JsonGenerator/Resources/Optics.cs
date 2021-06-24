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
            Factory.AddToGroup("4.0x Flip Hybrid", Id.OpticMW, Id.OpticM4A1);
            Factory.AddToGroup("Aim-Op Reflex Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("APX5 Holographic Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Canted Hybrid", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Corp Combat Holo Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Cronen C480 Pro Optic", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Cronen LP945 Mini Reflex", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Operator Reflex Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("G.I Mini Reflex", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Scout Combat Optic", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("VLK 3.0x Optic", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Integral Hybrid", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Viper Reflex Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Solozero NVG Enhanced", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Monocle Reflex Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Sniper Scope", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Merc Thermal Optic", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("PBX Holo 7 Sight", Id.OpticMW, Id.OpticOden, Id.OpticM4A1);
            Factory.AddToGroup("Thermal Hybrid", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);
            Factory.AddToGroup("Solozero Optics Mini Reflex", Id.OpticMW, Id.OpticOden, Id.OpticAK47MW);
            Factory.AddToGroup("Variable Zoom Scope", Id.OpticMW, Id.OpticOden, Id.OpticM4A1, Id.OpticAK47MW);

            Factory.AddToGroup("Millstop Reflex", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Visiontech 2x", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Kobra Red Dot", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Quickdot LED", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Axial Arms 3x", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Sillix Holoscout", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Microflex LED", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Hawksmoor", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Royal & Kross 4x", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("SUSAT Multizoom", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("Diamondback Reflex", Id.OpticWest, Id.OpticEast);
            Factory.AddToGroup("AN/PVS-4 Thermal", Id.OpticWest);
            Factory.AddToGroup("Noch Sova Thermal", Id.OpticEast);



        }
    }
}
