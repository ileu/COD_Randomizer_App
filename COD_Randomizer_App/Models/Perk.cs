using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class Perk : BaseUnit
    {
        public string PerkType { get; set; }

        public Perk(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(PerkType) ? Name : PerkType + ": " + Name;
        }
    }
}
