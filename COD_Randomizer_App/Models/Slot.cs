using System.Collections.Generic;

namespace COD_Randomizer_App.Models
{
    public class Slot : Unit<Attachment>
    {
        public List<Attachment> Attachments { get => units; set => units = value; }

        public int Id { get; private set; }

        public Slot(string name, int id) : base(name)
        {
            Id = id;
        }

        public void AddAttachment(Attachment attachment)
        {
            if (attachment == null)
            {
                return;
            }

            Attachments.Add(attachment);
        }

        public void AddAttachment(List<Attachment> attachments)
        {
            foreach (Attachment attachment in attachments)
            {
                AddAttachment(attachment);
            }
        }

        public Attachment GetRandomAttachment()
        {
            return base.GetRandom();
        }

        public override string ToString()
        {
            string output = base.ToString() + ": ";

            if (Attachments == null)
            {
                return output += "null";
            }

            foreach (Attachment attachment in Attachments)
            {
                output += attachment;
            }

            return output;
        }
    }
}
