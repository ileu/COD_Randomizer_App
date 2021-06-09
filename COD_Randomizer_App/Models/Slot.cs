using Newtonsoft.Json;
using COD_Randomizer_App.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class Slot : Unit<Attachment>
    {
        public List<Attachment> Attachements { get => units; set => units = value; }

        [JsonConstructor]
        public Slot(string name) : base(name)
        {

        }

        public Slot(string name, int id) : base(name)
        {
            Attachements = AttachementFactory.GetAttachmentGroup(id);
        }

        public Slot(string name, AttachGroup id) : base(name)
        {
            Attachements = AttachementFactory.GetAttachmentGroup(id);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
