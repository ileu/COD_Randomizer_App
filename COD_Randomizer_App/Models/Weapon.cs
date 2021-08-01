using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace COD_Randomizer_App.Models
{
    public class Weapon : Unit<Slot>
    {
        public List<Slot> Slots { get => units; }

        public string WeaponClass { get; set; } = "";

        public string Game { get; set; }

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

        public List<Slot> GetRandomSlots(int n = 1)
        {
            if (Slots == null || n == 0)
            {
                return new List<Slot>();
            }

            if (n > Slots.Count)
            {
                n = Slots.Count;
            }

            List<Slot> slots = new List<Slot>();

            do
            {
                Slot lot = base.GetRandom();
                if (!slots.Contains(lot))
                {
                    Slot temp = new Slot(lot.Name, lot.Id);

                    temp.AddAttachment(lot.GetRandomAttachment());

                    slots.Add(temp);
                }
            } while (slots.Count < n);

            return slots;
        }

        public string Display()
        {
            string output = "Weapon: " + name + "\n";
            output += " Slots:\n";
            foreach (Slot slot in Slots)
            {
                output += "  " + slot.Name + ":\n";
                if (slot.Attachments == null)
                {
                    output += "null\n";
                    continue;
                }
                foreach (Attachment attachement in slot.Attachments)
                {
                    output += "      " + attachement.Name + "\n";
                }
            }

            return output;
        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(WeaponClass) ? Name : WeaponClass + ": " + Name;
        }

    }
}
