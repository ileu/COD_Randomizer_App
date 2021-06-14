using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.JsonGenerator.Models
{
    public class Grenade : BaseUnit
    {
        public bool Primary { get; set; }

        public Grenade(string name, bool primary) : base(name)
        {
            Primary = primary;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
