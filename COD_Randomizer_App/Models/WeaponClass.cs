using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class WeaponClass : Unit<Weapon>
    {
        public WeaponClass(string name) : base(name)
        {

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
