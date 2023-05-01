using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        private int _hunger;

        public int Hunger
        {
            get => this._hunger;
            init => this._hunger = value;
        }
        public string Name { get; init; }
        public abstract string TypeName { get; }
        public abstract void Voice();

        public virtual void Eat(Food food)
        {
            this._hunger += food.Health;
        }
    }
}
