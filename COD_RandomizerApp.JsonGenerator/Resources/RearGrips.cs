using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class RearGrips
    {
        public static void Create()
        {
            Factory.AddToGroup("Granulated Grip Tape", Id.RearGripStandard);
            Factory.AddToGroup("Rubberized Grip Tape", Id.RearGripStandard);
            Factory.AddToGroup("Stippled Grip Tape", Id.RearGripStandard);

            Factory.AddToGroup("XRK Void II", Id.RearGripGrau);
            Factory.AddToGroup("Cronen Sniper Elite", Id.RearGripGrau);
            Factory.AddToGroup("FTAC R-89 Rubber", Id.RearGripGrau);

            Factory.AddToGroup("XRK CR-56 Granulated Wrap", Id.RearGripAmax);
            Factory.AddToGroup("XRK CR-56 Stippled Wrap", Id.RearGripAmax);
            Factory.AddToGroup("XRK CR-56 Rubberized Wrap", Id.RearGripAmax);

            Factory.AddToGroup("FSS Vice ISO Grip", Id.RearGripIso);
            Factory.AddToGroup("FTAC Elite ISO Grip", Id.RearGripIso);
            Factory.AddToGroup("ISO Tac-Form", Id.RearGripIso);

            Factory.AddToGroup("FTAC 60 Series Polymer", Id.RearGripStriker);
            Factory.AddToGroup("FTAC G-5 EXO", Id.RearGripStriker);
            Factory.AddToGroup("FTAC 60 Series Rubber", Id.RearGripStriker);

            Factory.AddToGroup("Speed Tape", Id.RearGripWest, Id.RearGripEast);
            Factory.AddToGroup("Dropshot Wrap", Id.RearGripWest, Id.RearGripEast);
            Factory.AddToGroup("Field Tape", Id.RearGripWest, Id.RearGripEast);
            Factory.AddToGroup("SASR Jungle Grip", Id.RearGripWest);
            Factory.AddToGroup("Serpent Wrap", Id.RearGripWest, Id.RearGripEast);
            Factory.AddToGroup("Airborne Elastic Wrap", Id.RearGripWest);

            Factory.AddToGroup("Spetsnaz Field Grip", Id.RearGripEast);
            Factory.AddToGroup("GRU Elastic Wrap", Id.RearGripEast);

        }
    }
}
