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

        public override bool Equals(object obj) => this.Equals(obj as BaseUnit);

        public bool Equals(BaseUnit unit)
        {
            if (unit is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, unit))
            {
                return true;
            }

            if (this.GetType() != unit.GetType())
            {
                return false;
            }

            return this.Name == unit.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(BaseUnit lhs, BaseUnit rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }

                return false;
            }

            return lhs.Equals(rhs);
        }

        public static bool operator !=(BaseUnit lhs, BaseUnit rhs) => !(lhs == rhs); 
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

        public virtual List<T> GetRandom(int n = 1)
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
