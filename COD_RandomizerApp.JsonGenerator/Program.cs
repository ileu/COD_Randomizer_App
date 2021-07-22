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

        static void Main(string[] args)
        {
            MotherLoadout MotherLoadout = new MotherLoadout();
            string filepath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\COD_Randomizer_App\\Resources\\TestJson.json";
            var testContent = File.ReadAllText(filepath);

            Weapon tes_weapon = Factory.CreateWeapon("Test", WeaponDictionaries.hdr);

            /*
            foreach(KeyValuePair<string, Dictionary<string, int>> key in WeaponDictionaries.sturmgewehr_dict)
            {
                MotherLoadout.Primaries.Add(WeaponFactory.CreateWeapon(key.Key, key.Value));
            }
            */

            //foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.Primary_WepCW)
            //{
            //    MotherLoadout.Primaries.Add(Factory.CreateWeapon(key.Key, key.Value));
            //}

            //foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.Secondary_WepCW)
            //{
            //    MotherLoadout.Secondaries.Add(Factory.CreateWeapon(key.Key, key.Value));
            //}

            //foreach (string perk in WeaponDictionaries.perk1_list)
            //{
            //    MotherLoadout.Perks1.Add(Factory.CreatePerk(perk));
            //}

            //foreach (string perk in WeaponDictionaries.perk2_list)
            //{
            //    MotherLoadout.Perks2.Add(Factory.CreatePerk(perk));
            //}

            //foreach (string perk in WeaponDictionaries.perk2_list)
            //{
            //    MotherLoadout.Perks3.Add(Factory.CreatePerk(perk));
            //}

            //foreach (string gren in WeaponDictionaries.prim_gren)
            //{
            //    MotherLoadout.Lethals.Add(Factory.CreateGrenade(gren));
            //}

            //foreach (string gren in WeaponDictionaries.sec_gren)
            //{
            //    MotherLoadout.Tacticals.Add(Factory.CreateGrenade(gren));
            //}

            //var test = JsonConvert.SerializeObject(MotherLoadout, Formatting.Indented);

            //File.WriteAllText(filepath, test);

            //File.WriteAllText("C:/Users/ueli/Desktop/TestFile.txt", filestring);

            Console.WriteLine(tes_weapon.Display());
            //Console.WriteLine(Factory.PrintGroup());
            //Console.WriteLine(MotherLoadout.Display());
            Console.ReadLine();
        }
    }
}
