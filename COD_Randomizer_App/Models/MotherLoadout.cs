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

        public Loadout GetRandomLoadout()
        {
            int perk1 = rnd.Next(Perks1.Count);
            int perk2 = rnd.Next(Perks2.Count);
            int perk3 = rnd.Next(Perks3.Count);

            int lethal = rnd.Next(Lethals.Count);
            int tactical = rnd.Next(Tacticals.Count);

            Loadout loadout = new Loadout
            {
                Perk1 = Perks1[perk1],
                Perk2 = Perks2[perk2],
                Perk3 = Perks3[perk3],

                Lethal = Lethals[lethal],
                Tactical = Tacticals[tactical]
            };
            Weapon prim_draw;
            Weapon sec_draw;

            int primary = rnd.Next(Primaries.Count);

            int secondary;

            if (loadout.Perk2.Name == "Overkill")
            {
                do
                {
                    secondary = rnd.Next(Primaries.Count);
                } while (primary == secondary);
                sec_draw = Primaries[secondary];
            }
            else
            {
                secondary = rnd.Next(Secondaries.Count);
                sec_draw = Secondaries[secondary];
            }

            prim_draw = Primaries[primary];


            Weapon prim = new Weapon(prim_draw.Name);
            prim.AddSlot(prim_draw.GetRandom(5));
            Weapon sec = new Weapon(sec_draw.Name);
            sec.AddSlot(sec_draw.GetRandom(5));

            loadout.Primary = prim;
            loadout.Secondary = sec;

            return loadout;
        }

        public string EncodeLoadout()
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
    }
}
