using COD_Randomizer_App.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace COD_Randomizer_App.Models
{
    public abstract class BaseUnit
    { 
        protected string name;
        public string Name { get => name; }

        protected bool visible  = true;
        public bool Visible { get => visible; }

        protected Random rng;

        public BaseUnit(string name)
        {
            name = name;
        }

        public void ChangeVisibiliy()
        {
            visible = !visible;
        }

        public abstract override string ToString();
    }

    public abstract class Unit<T> : BaseUnit where T : BaseUnit
    {
        protected List<T> units;

        public Unit(string name) : base(name)
        {
            units = new List<T>();
            rng = new Random();
        }

        protected void AddUnit(T unit)
        {
            units.Add(unit);
        }

        public List<T> GetRandom(int n = 1)
        {
            if (n < 1)
                throw new ArgumentException("Bisch du dumm oder so?", "GetRandom Draws n is smaller than 1");

            List<T> draw = units.Where(unit => unit.Visible).ToList();
            T lot;
            List<T> selection = new List<T>();

            do
            {
                lot = units.ElementAt(rng.Next(units.Count));
                if (!selection.Contains(lot))
                    selection.Add(lot);
            } while (selection.Count < n);

            return selection;
        }
    }

    public class WeaponClass : Unit<Weapon>
    {
        public WeaponClass(string name) : base(name)
        {

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class Weapon : Unit<Slot>
    {

        public List<Slot> Slots { get => units; set => units = value; }

        public bool Primary { get; set; }

        public Weapon(string name) : base(name) { }

        public void AddSlot(string name, int id)
        {
            units.Add(new Slot(name, id));
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class Slot : Unit<Attachement>
    {
        public List<Attachement> Attachements { get => units; set => units = value; }
        
        [JsonConstructor]
        public Slot(string name) : base(name)
        {

        }

        public Slot(string name, int id) : base(name)
        {
            Attachements = AttachementFactory.GetAttachmentGroup(id);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class Attachement : BaseUnit
    {
        public Attachement(string name) : base(name)
        {

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class Grenade : BaseUnit
    {
        public bool Primary { get; set; }

        public Grenade(string name, bool primary) : base(name)
        {
            Primary = primary;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
