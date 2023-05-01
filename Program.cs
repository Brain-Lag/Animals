using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var barsik = new Cat() { Name = "Барсик", Hunger = 5 };
            barsik.Meow();
            var apple = new Apple { Health = 10 };
            var orange = new Orange { Health = 5 };
            DoMeal(barsik, apple);
            DoMeal(barsik, apple);
            DoMeal(barsik, orange);

            var baron = new Dog() { Name = "Барон", Hunger = 4 };
        }

        static void DoMeal(Pet pet, Food food)
        {
            pet.Eat(food);
        }
    }
}