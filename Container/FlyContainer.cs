using System;
using System.Collections.Generic;

namespace DiggersandFliers
{
    public class FlyContainer
    {
        public List<IFlyingAnimal> flyingAnimals { get; set; } = new List<IFlyingAnimal>();
    }
}