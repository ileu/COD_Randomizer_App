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
            Factory.AddToGroup("Granulated Grip Tape", Id.RearGripAssault);
            Factory.AddToGroup("Rubberized Grip Tape", Id.RearGripAssault);
            Factory.AddToGroup("Stippled Grip Tape", Id.RearGripAssault);
        }
    }
}
