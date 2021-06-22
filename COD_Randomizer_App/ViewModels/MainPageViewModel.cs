using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using COD_Randomizer_App.Helpers;
using COD_Randomizer_App.Models;
using MvvmHelpers;
using Newtonsoft.Json;
using Xamarin.Forms;

using static COD_Randomizer_App.Resources.Dictionaries;

namespace COD_Randomizer_App.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; }

        Random rng = new Random();

        int p = 4;
        int over = 2;

        #region Bindings
        string slot1_weapon;
        public string Slot1_weapon
        {
            get => slot1_weapon;
            set => SetProperty(ref slot1_weapon, value);
        }

        List<string> slot1_att;
        public List<string> Slot1_att
        {
            get => slot1_att;
            set => SetProperty(ref slot1_att, value);
        }

        string slot2_weapon;
        public string Slot2_weapon
        {
            get => slot2_weapon;
            set => SetProperty(ref slot2_weapon, value);
        }

        List<string> slot2_att;
        public List<string> Slot2_att
        {
            get => slot2_att;
            set => SetProperty(ref slot2_att, value);
        }

        string perk1;
        public string Perk1
        {
            get => perk1;
            set => SetProperty(ref perk1, value);
        }

        string perk2;
        public string Perk2
        {
            get => perk2;
            set => SetProperty(ref perk2, value);
        }

        string perk3;
        public string Perk3
        {
            get => perk3;
            set => SetProperty(ref perk3, value);
        }

        string gren1;
        public string Gren1
        {
            get => gren1;
            set => SetProperty(ref gren1, value);
        }

        string gren2;
        public string Gren2
        {
            get => gren2;
            set => SetProperty(ref gren2, value);
        }
        #endregion

        public MainPageViewModel()
        {
            Slot1_weapon = "";
            Slot2_weapon = "";

            Slot1_att = new List<string> { "\n" };
            Slot2_att = new List<string> { "\n" };
            
            Perk1 = "Perk 1:";
            Perk2 = "Perk 2:";
            Perk3 = "Perk 3:";

            Gren1 = "Lethal";
            Gren2 = "Tactical";

            GenerateCommand = new Command(OnGenerate);
            /*
            #region TestZone

            AttachementFactory.AddAttachmentToGroup("THISE ATTACHEMENT", 999);

            Weapon test = UnitFactory.CreateWeapon("THISE WEAPON", new Dictionary<string, int>() { { "THISE SLOT", 999 } });

            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.json");
            string testText = JsonConvert.SerializeObject(test, Formatting.Indented);
            File.WriteAllText(fileName, testText);

            Weapon testCopy = JsonLoaderExample();

            bool testWeaponEquality = test == testCopy;

            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPageViewModel)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("COD_Randomizer_App.Resources.TestFile.txt");

            string text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            #endregion
            */
        }

        private Weapon JsonLoaderExample()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPageViewModel)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("COD_Randomizer_App.Resources.TestJson.json");

            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var weaponObject = JsonConvert.DeserializeObject<Weapon>(json);
                return weaponObject;
            }
        }

        private KeyValuePair<string, Dictionary<string, int>> get_Weapon(string weapon_class)
        {
            KeyValuePair<string, Dictionary<string, int>> weapon = new KeyValuePair<string, Dictionary<string, int>>();

            if (weapon_class == "Assault Rifle")
                weapon = sturmgewehr_dict.ElementAt(rng.Next(sturmgewehr_dict.Count));
            else if (weapon_class == "SMG")
                weapon = mp_dict.ElementAt(rng.Next(mp_dict.Count));
            else if (weapon_class == "Shotgun")
                weapon = shotgun_dict.ElementAt(rng.Next(shotgun_dict.Count));
            else if (weapon_class == "LMG")
                weapon = lmg_dict.ElementAt(rng.Next(lmg_dict.Count));
            else if (weapon_class == "Tactical Rifle")
                weapon = taktikgewehr_dict.ElementAt(rng.Next(taktikgewehr_dict.Count));
            else if (weapon_class == "Marksman Rifle")
                weapon = dmr_dict.ElementAt(rng.Next(dmr_dict.Count));
            else if (weapon_class == "Sniper")
                weapon = sniper_dict.ElementAt(rng.Next(sniper_dict.Count));
            else if (weapon_class == "Handgun")
                weapon = pistole_dict.ElementAt(rng.Next(pistole_dict.Count));
            else if (weapon_class == "Launcher")
                weapon = new KeyValuePair<string, Dictionary<string, int>>(werfer_dict[rng.Next(werfer_dict.Count)], null);


            return weapon;
        }

        private List<string> get_Att(Dictionary<string, int> weapon)
        {
            if (weapon == null)
                return new List<string> { "No attachments available\n" };

            List<string> temp = new List<string>();
            List<string> rand_pos = weapon.Keys.OrderBy(x => rng.Next()).Take(5).ToList();

            foreach (string att in rand_pos)
            {
                temp.Add(att + ": " + (rng.Next(weapon[att]) + 1));
            }

            return temp;
        }

        private void OnGenerate(object obj)
        {
            int p2 = rng.Next(perk2_list.Count + p);

            string weapon_class1 = primary_weapons[rng.Next(primary_weapons.Count)];
            KeyValuePair<string, Dictionary<string, int>> weapon1 = get_Weapon(weapon_class1);

            string weapon_class2;

            if ((p2 == over) || (p2 >= 6))
            {
                p2 = over;
                weapon_class2 = primary_weapons[rng.Next(primary_weapons.Count)];
            }
            else
            {
                weapon_class2 = secondary_weapons[rng.Next(secondary_weapons.Count)];
            }

            KeyValuePair<string, Dictionary<string, int>> weapon2 = get_Weapon(weapon_class2);

            Slot1_weapon = weapon_class1 + ": " + weapon1.Key;
            Slot1_att = get_Att(weapon1.Value);

            Slot2_weapon = weapon_class2 + ": " + weapon2.Key;
            Slot2_att = get_Att(weapon2.Value);

            Perk1 = "Perk 1: " + perk1_list[rng.Next(perk1_list.Count)];
            Perk2 = "Perk 2: " + perk2_list[p2];
            Perk3 = "Perk 3: " + perk3_list[rng.Next(perk3_list.Count)];

            Gren1 = "Lethal: " + prim_gren[rng.Next(prim_gren.Count)];
            Gren2 = "Tactical: " + sec_gren[rng.Next(sec_gren.Count)];
        }
    }
}
