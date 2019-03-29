using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{ 
    class Horse:FarmAnimal
    {
        public int Speed { get; set; }
        public int JumpHeight { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"I am a {AnimalName} and I enjoy running");
        }

        public void Run()
        {
            Console.WriteLine($"Running at {Speed} mph.");
        }

        public void Jump()
        {
            Console.WriteLine($"Jumping {JumpHeight} ft. high!");
        }
    }
}
