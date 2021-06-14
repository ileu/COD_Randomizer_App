using COD_Randomizer_App.JsonGenerator.Models;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class Lasers
    { 
        public static void Create()
        {
            Factory.AddToGroup("1mW Laser", Id.LaserMW);
            Factory.AddToGroup("5mW Laser", Id.LaserMW);
            Factory.AddToGroup("Tac Laser", Id.LaserMW);
        }
    }
}
