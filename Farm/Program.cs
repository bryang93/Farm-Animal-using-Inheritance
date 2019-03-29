using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{

    // Help from -devu.com- Bob Tabor C# Inheritance Fundamentals, Intro
    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Horse()
            {
                AnimalName = "Horse",
                Sound = "NEIGH!!!",
                Speed = 55,
                JumpHeight = 5
            };
            horse.Speak();
            horse.Noise();
            horse.Run();
            horse.Jump();

            Console.ReadLine();
            Console.Clear();

            var cow = new Cow()
            {
                AnimalName = "Cow",
                Sound = "MOO!!!",
                Food = "Grass",
                MeatAmount = 500,
            };
            cow.Speak();
            cow.Noise();
            cow.Eat();
            cow.SlaughterHouse();

            Console.ReadLine();
            Console.Clear();

            var turkey = new Turkey()
            {
                AnimalName = "Turkey",
                Sound = "GOBBLE! GOBBLE!",
                Food = "Corn",
                Holiday = "Thanksgiving"
            };
            turkey.Speak();
            turkey.Noise();
            turkey.Eat();
            turkey.HolidayServed();

            Console.ReadLine();
            Console.Clear();

            var fox = new Fox()
            {
                AnimalName = "Fox",
                Sound = "........(silent)",
                Food = "Eggs",
                Smell = "Chickens",
            };
            fox.Speak();
            fox.Noise();
            fox.Search();
            fox.Eat();


            Console.ReadLine();
        }
    }
}
