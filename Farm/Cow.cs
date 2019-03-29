using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Cow : FarmAnimal
    {
        public int MeatAmount { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"I am a {AnimalName} and I'll become your favorite steak soon!");
        }

        public void SlaughterHouse()
        {
            Console.WriteLine($"Taking a nail to the head to provide you {MeatAmount} pounds of meat!");
        }
    }
}
