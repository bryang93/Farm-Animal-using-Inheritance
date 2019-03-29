using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Fox : FarmAnimal
    {
        public string Smell{get; set;}

        public override void Speak()
        {
            Console.WriteLine($"I am a {AnimalName} and I eat small farm animals!");
        }

        public void Search()
        {
            Console.WriteLine($"I smell {Smell}! Time to feast!");
        }
    }
}
