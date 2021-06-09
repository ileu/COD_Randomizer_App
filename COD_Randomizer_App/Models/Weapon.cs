using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class Weapon : Unit<Slot>
    {

        public List<Slot> Slots { get => units; set => units = value; }

        public bool Primary { get; set; }

        public Weapon(string name) : base(name) { }

        public void AddSlot(string name, int id)
        {
            units.Add(new Slot(name, id));
        }

        public void AddSlot(string name, AttachGroup id)
        {
            units.Add(new Slot(name, id));
        }

        public override string ToString()
        {
            return name;
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
            }

            return output;
        }
    }
}
