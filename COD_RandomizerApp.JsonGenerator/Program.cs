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
            // var testContent = File.ReadAllText(filepath);

            Weapon kilo = Factory.CreateWeapon("Kilo", WeaponDictionaries.kilotest);

            MotherLoadout.Primaries.Add(kilo);

            var test = JsonConvert.SerializeObject(kilo, Formatting.Indented);

            /*
            foreach(KeyValuePair<string, Dictionary<string, int>> key in WeaponDictionaries.sturmgewehr_dict)
            {
                MotherLoadout.Primaries.Add(WeaponFactory.CreateWeapon(key.Key, key.Value));
            }
            */

            File.WriteAllText(filepath, test);

            Console.WriteLine(kilo.Display());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
