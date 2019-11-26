using System;
using System.Collections.Generic;

namespace DiggersandFliers
{
    class Program
    {
        static void Main(string[] args)

        {
            Ants ant = new Ants();
            BettaFish betta = new BettaFish();
            CopperheadSnake copper = new CopperheadSnake();
            Earthworms worm = new Earthworms();
            Finches finch = new Finches();
            Gerbils gerbil = new Gerbils();
            Mice mouse = new Mice();
            Parakeets bird = new Parakeets();
            Terrapins turtle = new Terrapins();
            TimberRattleSnake snake = new TimberRattleSnake();

            WalkContainer animals = new WalkContainer();
            animals.walkingAnimals.Add(ant);
            animals.walkingAnimals.Add(copper);
            animals.walkingAnimals.Add(worm);
            animals.walkingAnimals.Add(gerbil);
            animals.walkingAnimals.Add(mouse);
            animals.walkingAnimals.Add(snake);

            SwimContainer swimAnimal = new SwimContainer();
            swimAnimal.swimmingAnimals.Add(betta);
            swimAnimal.swimmingAnimals.Add(turtle);

            DigContainer diggingAnimals = new DigContainer();
            diggingAnimals.diggingAnimals.Add(worm);

            FlyContainer flyingAnimals = new FlyContainer();
            flyingAnimals.flyingAnimals.Add(finch);
            flyingAnimals.flyingAnimals.Add(bird);

            foreach (var animal in animals.walkingAnimals)
            {
                animal.WalkRun();
            }

            foreach (var animal in swimAnimal.swimmingAnimals)
            {
                animal.Swim();
            }

            foreach (var animal in diggingAnimals.diggingAnimals)
            {
                animal.Dig();
            }

            foreach (var animal in flyingAnimals.flyingAnimals)
            {
                animal.Fly();
            }

        }
    }
}