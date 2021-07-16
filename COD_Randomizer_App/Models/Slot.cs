using System.Collections.Generic;

namespace COD_Randomizer_App.Models
{
    public class Slot : Unit<Attachment>
    {
        public List<Attachment> Attachements { get => units; set => units = value; }

        public Slot(string name) : base(name)
        {

        }
    }
}
