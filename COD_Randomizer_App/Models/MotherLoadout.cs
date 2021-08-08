using COD_Randomizer_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Randomizer_App.Models
{
    public class MotherLoadout
    {
        public List<Weapon> Primaries { get; set; } = new List<Weapon>();
        public List<Weapon> Secondaries { get; set; } = new List<Weapon>();

        public List<Grenade> Lethals { get; set; } = new List<Grenade>();
        public List<Grenade> Tacticals { get; set; } = new List<Grenade>();

        public List<Perk> Perks1 { get; set; } = new List<Perk>();
        public List<Perk> Perks2 { get; set; } = new List<Perk>();
        public List<Perk> Perks3 { get; set; } = new List<Perk>();

        private readonly Random rnd = new();

        public Loadout GetRandomLoadout(int n = 5, int pOverkill = 3)
        {
            int perk1 = rnd.Next(Perks1.Count);
            int perk2 = rnd.Next(Perks2.Count + pOverkill);
            int perk3 = rnd.Next(Perks3.Count);

            int lethal = rnd.Next(Lethals.Count);
            int tactical = rnd.Next(Tacticals.Count);

            if (perk2 > Perks2.Count - 1)
            {
                perk2 = 2;
            }

            Loadout loadout = new Loadout
            {
                Perk1 = Perks1[perk1],
                Perk2 = Perks2[perk2],
                Perk3 = Perks3[perk3],

                Lethal = Lethals[lethal],
                Tactical = Tacticals[tactical]
            };

            int primary = rnd.Next(Primaries.Count);
            int secondary;

            Weapon sec;

            if (loadout.Perk2.Name == "Overkill")
            {
                do
                {
                    secondary = rnd.Next(Primaries.Count);
                } while (primary == secondary);
                sec = GetWeapon(secondary, Primaries, n);
            }
            else
            {
                secondary = rnd.Next(Secondaries.Count);
                sec = GetWeapon(secondary, Secondaries, n);
            }


            loadout.Primary = GetWeapon(primary, Primaries, n);
            loadout.Secondary = sec;

            return loadout;
        }

        /// <summary>
        /// Gets a specific Loadout
        /// </summary>
        /// <param name="primpos"> index of primary weapon </param>
        /// <param name="secpos"> index of secondary weapon </param>
        /// <param name="isSecondary"> if force overkill or not</param>
        /// <param name="n"> number of Attachements </param> 
        /// <returns> Loadout </returns>
        public Loadout GetSpecificLoadout(int primpos = -1, int secpos = -1, bool isOverkill = true, int n = 5)
        {
            return new Loadout()
            {
                Perk1 = Perks1[rnd.Next(Perks1.Count)],
                Perk2 = Perks2[rnd.Next(isOverkill ? 2 : Perks2.Count)],
                Perk3 = Perks3[rnd.Next(Perks3.Count)],

                Lethal = Lethals[rnd.Next(Lethals.Count)],
                Tactical = Tacticals[rnd.Next(Tacticals.Count)],

                Primary = GetWeapon(primpos <= -1 ? rnd.Next(Primaries.Count) : primpos, Primaries, n),
                Secondary = GetWeapon(secpos <= -1 ? rnd.Next(Primaries.Count) : secpos, isOverkill ? Primaries : Secondaries, n),
            };
        }

        /// <summary>
        /// Gets an empty Loadout
        /// </summary>
        /// <returns> Empty Loadout</returns>
        public Loadout GetEmptyLoadout()
        {
            Loadout loadout = new()
            {
                Perk1 = new Perk("")
                {
                    PerkType = "Perk 1"
                },
                Perk2 = new Perk("")
                {
                    PerkType = "Perk 2"
                },
                Perk3 = new Perk("")
                {
                    PerkType = "Perk 3"
                },

                Lethal = new Grenade("")
                {
                    GrenadeType = "Lethal"
                },
                Tactical = new Grenade("")
                {
                    GrenadeType = "Tactical"
                },

                Primary = new Weapon(""),
                Secondary = new Weapon("")
            };

            loadout.Primary.AddSlot(new Slot("", 0));
            loadout.Secondary.AddSlot(new Slot("", 0));

            return loadout;
        }

        public string EncodeLoadout(Loadout loadout)
        {
            throw new NotImplementedException();
        }

        public Loadout DecodeLoadout(string code)
        {
            throw new NotImplementedException();
        }

        public string Display()
        {
            string output = "MotherLoadout:\n";
            output += "Primaries: " + Primaries.Count + "\n";
            output += "Secondaries: " + Secondaries.Count + "\n";

            output += "Perk1: " + Perks1.Count + "\n";
            output += "Perk2: " + Perks2.Count + "\n";
            output += "Perk3: " + Perks3.Count + "\n";

            output += "Lethals: " + Lethals.Count + "\n";
            output += "Tacticals: " + Tacticals.Count + "\n";

            return output;
        }

        private Weapon GetWeapon(int index, List<Weapon> weapons, int n = 1)
        {
            Weapon wep = weapons.ElementAtOrDefault(index) ?? new Weapon("");

            Weapon output = new Weapon(wep.Name);
            output.WeaponClass = wep.WeaponClass;
            output.AddSlot(wep.GetRandomSlots(n));
            output.Slots.Sort((x, y) => x.Id.CompareTo(y.Id));

            return output;
        }
    }
}
