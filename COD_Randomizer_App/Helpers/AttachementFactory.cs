using COD_Randomizer_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Helpers
{
    static class AttachementFactory
    {
        private static readonly Dictionary<int, List<Attachment>> attachementGroups = new Dictionary<int, List<Attachment>>();

        public static List<Attachment> GetAttachmentGroup(int id)
        {
            if (attachementGroups.TryGetValue(id, out List<Attachment> output))
                return output;
            else
                return null;
        }

        public static List<Attachment> GetAttachmentGroup(AttachGroup id)
        {
            if (attachementGroups.TryGetValue((int)id, out List<Attachment> output))
                return output;
            else
                return null;
        }

        public static void AddAttachmentToGroup(string name, int id)
        {
            if(attachementGroups.ContainsKey(id))
               attachementGroups[id].Add(new Attachment(name));
            else
                attachementGroups.Add(id, new List<Attachment>() { new Attachment(name) });
        }

        public static void AddAttachmentToGroup(Attachment attachement, int id)
        {
            if (attachementGroups.ContainsKey(id))
                attachementGroups[id].Add(attachement);
            else
                attachementGroups.Add(id, new List<Attachment>() { attachement });
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
