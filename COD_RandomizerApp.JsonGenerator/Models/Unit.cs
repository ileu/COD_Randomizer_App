using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace COD_Randomizer_App.JsonGenerator.Models
{
    public abstract class BaseUnit
    {
        protected string name;
        public string Name { get => name; }

        protected bool visible = true;
        public bool Visible { get => visible; set => visible = value; }

        public BaseUnit(string name)
        {
            this.name = name;
        }

        public void ChangeVisibiliy()
        {
            visible = !visible;
        }

        public override string ToString()
        {
            return name;
        }
    }

    public abstract class Unit<T> : BaseUnit where T : BaseUnit
    {
        protected List<T> units;

        protected Random rng;

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
                throw new ArgumentException("Bisch du dumm oder so?", "GetRandom Draws: n is smaller than 1");

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
}
