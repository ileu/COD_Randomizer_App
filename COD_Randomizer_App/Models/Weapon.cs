using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace COD_Randomizer_App.Models
{
    public class Weapon : Unit<Slot>
    {
        public List<Slot> Slots { get => units; }

        public string WeaponClass { get; set; } = "";

        public Weapon(string name) : base(name)
        {

        }

        public bool AddSlot(Slot slot)
        {
            try
            {
                Slots.Add(slot);
                return true;
            }
            catch (NullReferenceException e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        public bool AddSlot(List<Slot> slots)
        {
            foreach (Slot slot in slots)
            {
                bool check = AddSlot(slot);
                if (!check)
                    return false;
            }
            return true;
        }

        public string Display()
        {
            string output = "Weapon: " + name + "\n";
            output += " Slots:\n";
            foreach (Slot slot in Slots)
            {
                output += "  " + slot.Name + ":\n";
                if (slot.Attachements == null)
                {
                    output += "null\n";
                    continue;
                }
                foreach (Attachment attachement in slot.Attachements)
                {
                    output += "      " + attachement.Name + "\n";
                }
            }

            return output;
        }

        public override List<Slot> GetRandom(int n = 1)
        {
            var draw_slots = base.GetRandom(n);

            var slots = new List<Slot>();


            foreach (Slot slot in draw_slots)
            {
                var temp = new Slot(slot.Name);

                temp.Attachements.Add(slot.GetRandom().FirstOrDefault());
                slots.Add(temp);
            }

            return slots;
        }

        public override string ToString()
        {
            return WeaponClass + ": " + Name;
        }

    }
}
