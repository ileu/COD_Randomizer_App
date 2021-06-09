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
            this.name = name;
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
}
