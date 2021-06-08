using COD_Randomizer_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Helpers
{
    static class AttachementFactory
    {
        public enum AttachGroup
        {
            AssaultMuzzle = 101,
            SMGMuzzle = 201,
        }

        private static readonly Dictionary<int, List<Attachement>> attachementGroups = new Dictionary<int, List<Attachement>>();

        public static List<Attachement> GetAttachmentGroup(int id)
        {
            if (attachementGroups.TryGetValue(id, out List<Attachement> output))
                return output;
            else
                return null;
        }

        public static void AddAttachmentToGroup(string name, int id)
        {
            if(attachementGroups.ContainsKey(id))
               attachementGroups[id].Add(new Attachement(name));
            else
                attachementGroups.Add(id, new List<Attachement>() { new Attachement(name) });
        }

        public static void AddAttachmentToGroup(string name, List<int> ids)
        {
            foreach(int id in ids)
            {
                AddAttachmentToGroup(name, id);
            }
        }

    }
}
