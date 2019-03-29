using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    // BASE CLASS
    class FarmAnimal
    {
        public string AnimalName { get; set; }
        public string Sound { get; set; }
        public string Food { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"I am a {AnimalName}.");
        }

        public void Noise()
        {
            Console.WriteLine(Sound);
        }

        public void Eat()
        {
            Console.WriteLine($"Eating {Food}.");
        }
    }
}
