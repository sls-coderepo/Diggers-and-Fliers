using System;

namespace DiggersandFliers
{
    public class Terrapins : IWalkingAnimal, ISwimmingAnimal
    {

        public void Swim()
        {
            Console.WriteLine("He's a good swimmer");
        }

        public void WalkRun()
        {
            Console.WriteLine("He's a slow little turtle");
        }
    }
}