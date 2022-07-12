using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay16
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string Animaltype);

        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Land"))
                return new LandAnimalFactory();
            else
                return new SeaAnimalFactory();
        }
        //public static AnimalFactory GetAnimal(char ch)
        //{
        //    AnimalFactory animal;

        //    switch (ch)
        //    {
        //        case 'D': animal = new LandAnimalFactory();
        //            break;

        //        case 'C': animal = new LandAnimalFactory();
        //            break ;

        //        case 'S': animal = new SeaAnimalFactory();
        //            break;

        //        case 'O': animal= new SeaAnimalFactory();
        //            break;
        //    }
        //    return animal;
        //}
    }
}
