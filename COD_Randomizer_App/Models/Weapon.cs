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
                return true;
            }

            #region Akimbo/ Dual Wield
            if (WeaponClass == "Handgun")
            {
                if (attachment.Name == "Akimbo" || attachment.Name == "Dual Wield")
                {
                    foreach (Slot s in slots)
                    {
                        if (s.Name.Contains("Optic") || s.Name.Contains("Stock"))
                            return false;
                    }
                }
                else if (slot.Name == "Optic" || slot.Name == "Stock")
                {
                    foreach (Slot s in slots)
                    {
                        Attachment temp = s.Attachments.FirstOrDefault();
                        if (temp.Name == "Akimbo" || temp.Name == "Dual Wield")
                            return false;

                    }
                }

                if (attachment.Name == "FTAC G-X" || attachment.Name == "FTAC SATUS CS-X")
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
                        if (temp.Name == "FTAC G-X" || temp.Name == "FTAC SATUS CS-X")
                            return false;
                    }
                }
            }
            #endregion

            #region Assault Rifles

            else if (WeaponClass == "Assault Rifle")
            {
                #region Kilo, M13, M4A1
                if (attachment.Name == "Singuard Arms Whisper" || attachment.Name == "FFS 12.4\" Predator" || attachment.Name == "Tempus Cyclone")
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
                        if (temp.Name == "Singuard Arms Whisper" || temp.Name == "FFS 12.4\" Predator" || temp.Name == "Tempus Cyclone")
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

            else if (WeaponClass == "MP")
            {
                #region MP 5 MW, Fennec, Iso 
                if (attachment.Name == "Monolithic Integral Suppressor" || attachment.Name == "Subsonic Integral Suppressor" || attachment.Name == "ZLR 18\" Deadfall" || attachment.Name == "FSS Nightshade")
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
                        if (temp.Name == "Monolithic Integral Suppressor" || temp.Name == "Subsonic Integral Suppressor" || temp.Name == "ZLR 18\" Deadfall" || temp.Name == "FSS Nightshade")
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
            else if (slot.Attachments.FirstOrDefault()?.Name == "Optic" || slot.Attachments.FirstOrDefault()?.Name == "Stock")
            {
                foreach (Slot s in slots)
                {
                    Attachment temp = slot.Attachments.FirstOrDefault();
                    if (temp.Name == "Akimbo" || temp.Name == "Dual Wield")
                        return false;

                }
            }

            return true;
        }
    }
}
