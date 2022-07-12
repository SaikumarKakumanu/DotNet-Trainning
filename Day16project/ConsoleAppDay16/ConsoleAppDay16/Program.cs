using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalfactory = null;
            animalfactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine($"The Animal Factory Type : {animalfactory.GetType().Name}");
            Console.WriteLine();

            //get animal object
            animal = animalfactory.GetAnimal("Octopus");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine(animal.Speak());

            Console.WriteLine("-----------------------");

            animal = animalfactory.GetAnimal("Shark");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            
            Console.WriteLine(animal.Speak());

            Console.WriteLine("------------------------------");

            animalfactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine($"The Animal Factory Type : {animalfactory.GetType().Name}");
            Console.WriteLine();

            animal = animalfactory.GetAnimal("Dog");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine(animal.Speak());
            Console.WriteLine("--------------------------");

            animal = animalfactory.GetAnimal("Cat");
            Console.WriteLine($"Animal Type : {animal.GetType().Name}");
            Console.WriteLine(animal.Speak());

            Console.WriteLine("---------------------------------------------------------");

           

            Console.Read();
        }
    }
}
