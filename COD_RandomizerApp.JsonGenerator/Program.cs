using COD_Randomizer_App.JsonGenerator.Factories;
using COD_Randomizer_App.JsonGenerator.Resources;
using COD_Randomizer_App.JsonGenerator.Models;
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

            Weapon tes_weapon = Factory.CreateWeapon("Test", WeaponDictionaries.striker);

            var test = JsonConvert.SerializeObject(tes_weapon, Formatting.Indented);

            /*
            foreach(KeyValuePair<string, Dictionary<string, int>> key in WeaponDictionaries.sturmgewehr_dict)
            {
                MotherLoadout.Primaries.Add(WeaponFactory.CreateWeapon(key.Key, key.Value));
            }
            */

            
            string filestring = "";

            foreach (KeyValuePair<string, Dictionary<string, Id>> key in WeaponDictionaries.TestWeaponsCW)
            {
                filestring += Factory.CreateWeapon(key.Key, key.Value).Display();
            }
            
            //File.WriteAllText(filepath, test);

            File.WriteAllText("C:/Users/ueli/Desktop/TestFile.txt", filestring);

            Console.WriteLine(tes_weapon.Display());
            Console.WriteLine(Factory.PrintGroup());
            Console.ReadLine();
        }
    }
}
