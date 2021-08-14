using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using COD_Randomizer_App.Models;
using COD_Randomizer_App.Services;
using MvvmHelpers;
using Xamarin.Forms;

using static COD_Randomizer_App.Resources.Dictionaries;

namespace COD_Randomizer_App.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; }

        private Loadout loadout;
        public Loadout Loadout { get => loadout; private set => SetProperty(ref loadout, value); }

        public MainPageViewModel()
        {
            GenerateCommand = new Command(OnGenerate);

            Loadout = LocalDataService.MotherLoadout.GetEmptyLoadout();
        }

        private void OnGenerate()
        {
            Loadout = LocalDataService.MotherLoadout.GetRandomLoadout();
        }

        #region OldStuff

        private readonly Random rng = new Random();

        private readonly int p = 4;
        private readonly int over = 2;

        #region Bindings
        private string slot1_weapon = "";
        public string Slot1_weapon
        {
            get => slot1_weapon;
            set => SetProperty(ref slot1_weapon, value);
        }

        private List<string> slot1_att = new List<string> { "\n" };

        public List<string> Slot1_att
        {
            get => slot1_att;
            set => SetProperty(ref slot1_att, value);
        }

        private string slot2_weapon = "";
        public string Slot2_weapon
        {
            get => slot2_weapon;
            set => SetProperty(ref slot2_weapon, value);
        }

        private List<string> slot2_att = new List<string> { "\n" };
        public List<string> Slot2_att
        {
            get => slot2_att;
            set => SetProperty(ref slot2_att, value);
        }

        private string perk1 = "Perk 1:";
        public string Perk1
        {
            get => perk1;
            set => SetProperty(ref perk1, value);
        }

        private string perk2 = "Perk 2:";
        public string Perk2
        {
            get => perk2;
            set => SetProperty(ref perk2, value);
        }

        private string perk3 = "Perk 3:";
        public string Perk3
        {
            get => perk3;
            set => SetProperty(ref perk3, value);
        }

        private string gren1 = "Lethal:";
        public string Gren1
        {
            get => gren1;
            set => SetProperty(ref gren1, value);
        }

        private string gren2 = "Tactical:";
        public string Gren2
        {
            get => gren2;
            set => SetProperty(ref gren2, value);
        }
        #endregion

        private KeyValuePair<string, Dictionary<string, int>> Get_Weapon(string weapon_class)
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

        private List<string> Get_Att(Dictionary<string, int> weapon)
        {
            if (weapon == null)
                return new List<string> { "No attachments available\n" };

            List<string> temp = new List<string>();
            List<string> rand_pos = weapon.Keys.OrderBy(x => rng.Next()).Take(5).ToList();

            foreach (string att in rand_pos)
            {
                temp.Add(att + ": " + (rng.Next(weapon[att]) + 1) + ",");
            }

            temp.Last().Remove(temp.Last().Count() - 1);

            return temp;
        }

        private void OnGenerateOld(object obj)
        {
            int p2 = rng.Next(perk2_list.Count + p);

            string weapon_class1 = primary_weapons[rng.Next(primary_weapons.Count)];
            KeyValuePair<string, Dictionary<string, int>> weapon1 = Get_Weapon(weapon_class1);

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

            KeyValuePair<string, Dictionary<string, int>> weapon2 = Get_Weapon(weapon_class2);

            Slot1_weapon = weapon_class1 + ": " + weapon1.Key;
            
            Slot1_att = Get_Att(weapon1.Value);

            Slot2_weapon = weapon_class2 + ": " + weapon2.Key;
            Slot2_att = Get_Att(weapon2.Value);

            Perk1 = "Perk 1: " + perk1_list[rng.Next(perk1_list.Count)];
            Perk2 = "Perk 2: " + perk2_list[p2];
            Perk3 = "Perk 3: " + perk3_list[rng.Next(perk3_list.Count)];

            Gren1 = "Lethal: " + prim_gren[rng.Next(prim_gren.Count)];
            Gren2 = "Tactical: " + sec_gren[rng.Next(sec_gren.Count)];
        }
        #endregion
    }
}
