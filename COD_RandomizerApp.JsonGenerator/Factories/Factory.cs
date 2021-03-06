using COD_Randomizer_App.JsonGenerator.Resources;
using COD_Randomizer_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COD_Randomizer_App.JsonGenerator.Factories
{
    /*
         
         Each Id is given by 4 digits
        The first two digits is for the slot as following

        01 - Barrel     
        02 - Guard
        03 - Laser
        04 - Magazin
        05 - Muzzle
        06 - Optic
        07 - Perk
        08 - Pump
        09 - Rear Grip
        10 - Stock
        11 - Trigger Action
        12 - Underbarrel

        The other two digits are there to enumerate the different groups

         */

    public static class Factory
    {
        private static readonly Dictionary<Id, List<Attachment>> Groups = new Dictionary<Id, List<Attachment>>();

        static Factory()
        {
            Barrels.Create();
            Lasers.Create();
            Magazins.Create();
            Optics.Create();
            Muzzles.Create();
            Perks.Create();
            Underbarrel.Create();
            TriggerAction.Create();
            RearGrips.Create();
            Stocks.Create();
        }

        public static Dictionary<Id, List<Attachment>> GetGroups()
        {
            return Groups;
        }

        public static string PrintGroup()
        {
            string temp = "";
            foreach (KeyValuePair<Id, List<Attachment>> key in Groups)
            {
                temp += key.Key.ToString() + ": " + key.Value.Count + "\n";
            }

            return temp;
        }

        public static List<Attachment> GetAttachmentGroup(Id id)
        {
            return Groups.TryGetValue(id, out List<Attachment> output) ? output : new List<Attachment>();
        }

        public static Weapon CreateWeapon(string name, Dictionary<string, Id> dic = null)
        {
            Weapon weapon = new Weapon(name);

            if (dic == null)
            {
                return weapon;
            }

            foreach (KeyValuePair<string, Id> entry in dic)
            {
                Slot slot = CreateSlot(entry.Key, entry.Value);

                weapon.AddSlot(slot);
            }

            return weapon;
        }

        public static Weapon CreateWeapon(string name, string weaponClass, Dictionary<string, Id> dic = null)
        {
            Weapon weapon = CreateWeapon(name, dic);

            weapon.WeaponClass = weaponClass;

            return weapon;
        }

        public static Slot CreateSlot(string name, Id id)
        {
            Slot slot = new Slot(name, (int)id);

            slot.AddAttachment(GetAttachmentGroup(id));

            return slot;
        }

        public static Perk CreatePerk(string name, string perkType)
        {
            Perk perk = new Perk(name);

            perk.PerkType = perkType;

            return perk;
        }

        public static Grenade CreateGrenade(string name, string grenType)
        {
            Grenade grenade = new Grenade(name);

            grenade.GrenadeType = grenType;

            return grenade;
        }

        public static void AddToGroup(string name, Id id)
        {
            Attachment attachment = new Attachment(name);

            attachment.SetId((int)id);

            if (Groups.ContainsKey(id))
            {
                if (Groups[id].FindIndex(item => item.Name == name) < 0)
                {
                    Groups[id].Add(attachment);
                }
            }
            else
            {
                Groups.Add(id, new List<Attachment>() { attachment });
            }
        }

        public static void AddToGroup(string name, List<Id> ids)
        {
            foreach (Id id in ids)
            {
                AddToGroup(name, id);
            }
        }

        public static void AddToGroup(string name, params Id[] ids)
        {
            foreach (Id id in ids)
            {
                AddToGroup(name, id);
            }
        }

    }
}
