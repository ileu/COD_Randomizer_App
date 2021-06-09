using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.Models
{
    public class Attachment : BaseUnit
    {
        public List<AttachGroup> Ids { get; } 

        [JsonConstructor]
        public Attachment(string name) : base(name)
        {

        }

        public Attachment(string name, AttachGroup id) : base(name)
        {
            Ids = new List<AttachGroup> { id };
        }

        public Attachment(string name, List<AttachGroup> id) : base(name)
        {
            Ids = id;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
