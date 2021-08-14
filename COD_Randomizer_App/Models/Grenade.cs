using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class Grenade : BaseUnit
    {
        public string GrenadeType { get; set; }

        public Grenade(string name) : base(name)
        {
            
        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(GrenadeType) ? Name : GrenadeType + ": " + Name;
        }
    }
}
