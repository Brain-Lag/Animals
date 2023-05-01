using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public override string TypeName => "dog";

        public override void Eat(Food food)
        {
            base.Eat(food);
            Console.WriteLine($"dog eats {food.TypeName}. {food.Health} hp.");
        }

        public void Woof() => Console.WriteLine("woof!");

        public override void Voice()
        {
            this.Woof();
        }
    }
}
