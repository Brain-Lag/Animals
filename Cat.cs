using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public override string TypeName => "cat";

        public override void Eat(Food food)
        {
            base.Eat(food);
            Console.WriteLine($"cat eats {food.TypeName}. {food.Health} hp.");
        }

        public void Meow() => Console.WriteLine("meow!");

        public override void Voice()
        {
            this.Meow();
        }
    }
}
