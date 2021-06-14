using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.JsonGenerator.Models
{
    public class Weapon : Unit<Slot>
    {
        public List<Slot> Slots { get => units; }

        public Weapon(string name) : base(name)
        {
        }

        public string Display()
        {
            string output = "Weapon: " + name + "\n";
            output += " Slots:\n";
            foreach (Slot slot in Slots)
            {
                output += "  " + slot.Name + ": ";
                if (slot.Attachements == null)
                {
                    output += "null\n";
                    continue;
                }
                foreach (Attachment attachement in slot.Attachements)
                {
                    output += attachement.Name + ", ";
                }
                output = output.Remove(output.Length - 2);
                output += "\n";
            }

            return output;
        }
    }
}
