using System;
using System.Collections.Generic;

namespace DiggersandFliers
{
    public class WalkContainer
    {
        public List<IWalkingAnimal> walkingAnimals { get; set; } = new List<IWalkingAnimal>();
    }
}