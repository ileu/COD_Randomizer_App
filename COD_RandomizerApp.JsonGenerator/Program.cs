using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Resources;
using COD_Randomizer_App.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace COD_Randomizer_App.JsonGenerator
{
    class Program
    {
        private static readonly bool GENERATE = false;
        private static readonly bool WRITE = false;

        static void Main(string[] args)
        {
            MotherLoadout MotherLoadout = new MotherLoadout();
            string filepath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\COD_Randomizer_App\\Resources\\TestJson.json";

            Weapon tes_weapon = Factory.CreateWeapon("Test", WeaponDictionaries.hdr);
            Console.WriteLine(tes_weapon.Display());

            #region Json Generation
            if (GENERATE)
            {
                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.sturmgewehr_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "Assault Rifle", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.mp_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "SMG", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.shotgun_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "Shotgun", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.lmg_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "LMG", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.taktikgewehr_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "Tactical Rifle", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.dmr_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "Marksman Rifle", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.sniper_dict)
                {
                    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, "Sniper Rifle", key.Value));
                }

                foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.pistole_dict)
                {
                    MotherLoadout.Secondaries.Add(Factory.CreateWeapon(key.Key, "Handgun", key.Value));
                }

                foreach (string launcher in WeaponDictionaries.werfer_dict)
                {
                    MotherLoadout.Secondaries.Add(Factory.CreateWeapon(launcher, "Launcher"));
                }

                foreach (string perk in WeaponDictionaries.perk1_list)
                {
                    MotherLoadout.Perks1.Add(Factory.CreatePerk(perk, "Perk 1"));
                }

                foreach (string perk in WeaponDictionaries.perk2_list)
                {
                    MotherLoadout.Perks2.Add(Factory.CreatePerk(perk, "Perk 2"));
                }

                foreach (string perk in WeaponDictionaries.perk3_list)
                {
                    MotherLoadout.Perks3.Add(Factory.CreatePerk(perk, "Perk 3"));
                }

                foreach (string gren in WeaponDictionaries.prim_gren)
                {
                    MotherLoadout.Lethals.Add(Factory.CreateGrenade(gren, "Lethal"));
                }

                foreach (string gren in WeaponDictionaries.sec_gren)
                {
                    MotherLoadout.Tacticals.Add(Factory.CreateGrenade(gren, "Tactical"));
                }

                Console.WriteLine(MotherLoadout.Display());
            }

            if (WRITE)
            {
                string file = JsonConvert.SerializeObject(MotherLoadout, Formatting.Indented);

                File.WriteAllText(filepath, file);
            }
            #endregion

            //Console.WriteLine(Factory.PrintGroup());

            Console.ReadLine();
        }
    }
}
