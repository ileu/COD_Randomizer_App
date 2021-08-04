using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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


        /// <summary>
        /// Checks for attachment conflicts
        /// </summary>
        /// <param name="att"> Slot which will be added if valid</param> 
        /// <param name="slots">already existing slots</param>
        /// <returns>returns true if new attachment combination is valid</returns>
        public bool checkValidity(Slot att, List<Slot> slots)
        {

            Attachment a = att.Attachments.FirstOrDefault();

            #region Akimbo/ Dual Wield
            if (WeaponClass == "Handgun")
            {

                if (a != null && (a.Name == "Akimbo" || a.Name == "Dual Wield"))
                {
                    foreach (Slot slot in slots)
                    {
                        if (slot.Name.Contains("Optic") || slot.Name.Contains("Stock"))
                            return false;
                    }
                }

                else if (att.Name == "Optic" || att.Name == "Stock")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name == "Akimbo" || temp.Name == "Dual Wield")
                            return false;

                    }
                }
            }
            #endregion

            #region Assault Rifles

            if (WeaponClass == "Assault Rifle")
            {
                #region Kilo, M13, M4A1
                if (a != null && (a.Name == "Singuard Arms Whisper" || a.Name == "FFS 12.4\" Predator" || a.Name == "Tempus Cyclone"))
                {
                    foreach (Slot slot in slots)
                    {
                        if (slot.Name.Contains("Muzzle"))
                            return false;
                    }
                }

                else if (att.Name == "Muzzle")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if ((temp.Name == "Singuard Arms Whisper" || temp.Name == "FFS 12.4\" Predator" || temp.Name == "Tempus Cyclone"))
                            return false;

                    }
                }
                #endregion
            }
            #endregion

            #region MP

            else if (WeaponClass == "MP")
            {
                #region MP 5 MW, Fennec, Iso 
                if (a != null && (a.Name == "Monolithic Integral Suppressor" || a.Name == "Subsonic Integral Suppressor" || a.Name == "ZLR 18\" Deadfall" || a.Name == "FSS Nightshade"))
                {
                    foreach (Slot slot in slots)
                    {
                        if (slot.Name.Contains("Muzzle"))
                            return false;
                    }
                }

                else if (att.Name == "Muzzle")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if ((temp.Name == "Monolithic Integral Suppressor" || temp.Name == "Subsonic Integral Suppressor" || temp.Name == "ZLR 18\" Deadfall" || temp.Name == "FSS Nightshade"))
                            return false;

                    }
                }
                #endregion
            }
            #endregion

            #region LMG
            else if (WeaponClass == "LMG")
            {
                #region Chainsaw
                if (a != null && a.Name == "XRK ChainSAW")
                {
                    foreach (Slot slot in slots)
                    {
                        if (slot.Name.Contains("Optic"))
                            return false;
                    }
                }

                else if (att.Name == "Optic")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name == "XRK ChainSAW")
                            return false;

                    }
                }
                #endregion


            }
            #endregion

            return true;
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

                    
                   if (checkValidity(temp, slots))
                        slots.Add(temp);
                }
            } while (slots.Count < n );

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
