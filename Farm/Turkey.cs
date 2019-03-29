using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Turkey : FarmAnimal
    {
        public string Holiday { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"I am a {AnimalName} and you know what happens to me yearly....");
        }

        public void HolidayServed()
        {
            Console.WriteLine($"I'll be on your dinner table on {Holiday}");
        }
    }
}
