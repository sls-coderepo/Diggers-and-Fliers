using System;

namespace DiggersandFliers
{
    public class Earthworms : IWalkingAnimal, IDiggingAnimal
    {

        public void Dig()
        {
            Console.WriteLine("He digs underground when it rains");
        }

        public void WalkRun()
        {
            Console.WriteLine("He slithers on the ground");
        }
    }
}