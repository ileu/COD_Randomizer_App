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
            if (n > Slots.Count)
            {
                n = Slots.Count;
            }

            if (Slots == null || n == 0)
            {
                return new List<Slot>();
            }

            List<Slot> slots = new List<Slot>();

            do
            {
                Slot lot = base.GetRandom();
                if (!slots.Contains(lot))
                {
                    Slot temp = new Slot(lot.Name, lot.Id);

                    temp.AddAttachment(lot.GetRandomAttachment());

                    if (CheckValidity(temp, slots))
                    {
                        slots.Add(temp);
                    }
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

        /// <summary>
        /// Checks for attachment conflicts
        /// </summary>
        /// <param name="slot"> Slot which will be added if valid</param> 
        /// <param name="slots">already existing slots</param>
        /// <returns>returns true if new attachment combination is valid</returns>
        private bool CheckValidity(Slot slot, List<Slot> slots)
        {
            if (slot == null)
            {
                return false;
            }

            Attachment attachment = slot.Attachments.FirstOrDefault();

            if (attachment == null)
            {
                return false;
            }

            #region Akimbo/ Dual Wield
            if (WeaponClass == "Handgun")
            {
                if (attachment.Name is "Akimbo" or "Dual Wield")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Optic") || s.Name.Contains("Stock"))
                            return false;
                    }
                }
                else if (slot.Name is "Optic" or "Stock")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name is "Akimbo" or "Dual Wield")
                            return false;

                    }
                }

                if (attachment.Name is "FTAC G-X" or "FTAC SATUS CS-X")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Laser"))
                            return false;
                    }
                }
                else if (slot.Name.Contains("Laser"))
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name is "FTAC G-X" or "FTAC SATUS CS-X")
                            return false;
                    }
                }
            }
            #endregion

            #region Assault Rifles

            else if (WeaponClass == "Assault Rifle")
            {
                #region Kilo, M13, M4A1
                if (attachment.Name is "Singuard Arms Whisper" or "FFS 12.4\" Predator" or "Tempus Cyclone")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Muzzle"))
                            return false;
                    }
                }
                else if (slot.Name == "Muzzle")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name is "Singuard Arms Whisper" or "FFS 12.4\" Predator" or "Tempus Cyclone")
                            return false;

                    }
                }

                if (attachment.Name == "ZLR Drifter A-08")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Underbarrel"))
                            return false;
                    }
                }
                else if (slot.Name.Contains("Underbarrel"))
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name == "ZLR Drifter A-08")
                            return false;

                    }
                }
                #endregion
            }
            #endregion

            #region MP

            else if (WeaponClass == "SMG")
            {
                #region MP 5 MW, Fennec, Iso 
                if (attachment.Name is "Monolithic Integral Suppressor" or "Subsonic Integral Suppressor" or "ZLR 18\" Deadfall" or "FSS Nightshade")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Muzzle"))
                            return false;
                    }
                }
                else if (slot.Name == "Muzzle")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name is "Monolithic Integral Suppressor" or "Subsonic Integral Suppressor" or "ZLR 18\" Deadfall" or "FSS Nightshade")
                            return false;

                    }
                }
                #endregion

                #region CS-9
                if (attachment.Name is "CX-38S" or "CX-23S")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Muzzle"))
                            return false;
                    }
                }
                else if (slot.Name is "Muzzle")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name is "CX-38S" or "CX-23S")
                            return false;

                    }
                }
                if (attachment.Name is "CX-23")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Underbarrel"))
                            return false;
                    }
                }
                else if (slot.Name is "Underbarrel")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name is "CX-23")
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
                if (attachment.Name == "XRK ChainSAW")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Optic"))
                            return false;
                    }
                }
                else if (slot.Name == "Optic")
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

        /// <summary>
        /// Checks if the given slot name and given attachment name
        /// are on the weapon. 
        /// </summary>
        /// <param name="slot"> slot which is to be added </param>
        /// <param name="slots"> already added slots </param>
        /// <param name="blockedSlots"> slots which are incompatbile with attachments </param>
        /// <param name="blockedAttachment"> attachment which are incompatible which slots </param>
        /// <returns> false if it contains both, true if only one </returns>
        private bool Check(Slot slot, List<Slot> slots, string[] blockedSlots, string[] blockedAttachment)
        {
            if (blockedAttachment.Contains(slot.Attachments.FirstOrDefault()?.Name))
            {
                foreach (Slot s in slots)
                {
                    if (blockedSlots.Contains(slot.Name))
                        return false;
                }
            }
            else if (slot.Attachments.FirstOrDefault()?.Name is "Optic" or "Stock")
            {
                foreach (Slot s in slots)
                {
                    Attachment temp = slot.Attachments.FirstOrDefault();
                    if (temp.Name is "Akimbo" or "Dual Wield")
                        return false;

                }
            }

            return true;
        }
    }
}
