using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COD_Randomizer_App.JsonGenerator.Factories;

namespace COD_Randomizer_App.JsonGenerator.Resources
{
    public static class CrossbowStuff
    {
        public static void Create()
        {
            Factory.AddToGroup("16-Strand Cable", Id.Cable);
            Factory.AddToGroup("28-Strand Cable", Id.Cable);

            Factory.AddToGroup("XRK Thunder 200 Lb", Id.Arms);
            Factory.AddToGroup("XRK Quill 100 Lb", Id.Arms);
            Factory.AddToGroup("XRK Carbon Elite", Id.Arms);

            Factory.AddToGroup("FTAC Fury 20\" Bolts", Id.BoltCrossbow);
            Factory.AddToGroup("FTAC Venom 20\" Bolts", Id.BoltCrossbow);
            Factory.AddToGroup("FTAC Backburn 20\" Bolts", Id.BoltCrossbow);

        }
    }
}