using Newtonsoft.Json;
using COD_Randomizer_App.JsonGenerator.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace COD_Randomizer_App.JsonGenerator.Models
{
    public class Slot : Unit<Attachment>
    {
        public List<Attachment> Attachements { get => units; set => units = value; }

        public Slot(string name) : base(name)
        {

        }
    }
}
