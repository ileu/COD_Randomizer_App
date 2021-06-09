using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using COD_Randomizer_App.Models;
using System.IO;
using System.Globalization;
using System.Reflection;

namespace COD_Randomizer_App.Helpers
{
    public static class WeaponFactory
    {
        public static Weapon CreateWeapon(string name, Dictionary<string, int> dic = null)
        {
            Weapon output = new Weapon(name);

            if (dic != null)
            {
                foreach (KeyValuePair<string, int> entry in dic)
                {
                    output.AddSlot(entry.Key, entry.Value);
                }
            }

            return output;
        }

        public static Weapon CreateWeapon(string name)
        {
            return new Weapon(name);
        }

    }
}
