using System;
using Mod2_HW4.AnimalsArchitectгre;
using Mod2_HW4.AnimalsArchitectгre.Mammals.Artiodactyls;
using Mod2_HW4.AnimalsArchitectгre.Mammals.Predators.Canine;
using Mod2_HW4.AnimalsArchitectгre.Mammals.Predators.Feline;
using Mod2_HW4.AnimalsArchitectгre.Reptiles;
using Mod2_HW4.AnimalsArchitectгre.Reptiles.Scaly;

namespace Mod2_HW4.Services
{
    public class ParkInitService
    {
        private readonly Animals[] _animals;

        public ParkInitService()
        {
            _animals = new Animals[]
            {
                new Turtle { Name = "Леонардо", BirthDate = new DateTime(2001, 11, 13), Weight = 100 },
                new Turtle { Name = "Рафаэлло", BirthDate = new DateTime(2001, 11, 13), Weight = 105 },
                new Turtle { Name = "Микилянджело", BirthDate = new DateTime(2001, 11, 13), Weight = 90 },
                new Turtle { Name = "Донателло", BirthDate = new DateTime(2001, 11, 13), Weight = 95 },
                new Amphisbene { Name = "Амфисбена?!", BirthDate = new DateTime(2011, 6, 13), Weight = 5 },
                new Lizard { Name = "Ящерица-1", BirthDate = new DateTime(2011, 6, 13), Weight = 5 },
                new Lizard { Name = "Ящерица-2", BirthDate = new DateTime(2000, 6, 13), Weight = 15 },
                new Snake { Name = "Змейка (та самая)", BirthDate = new DateTime(1995, 6, 13), Weight = 150 },
                new Snake { Name = "Питон)", BirthDate = new DateTime(2015, 6, 13), Weight = 666 },
                new Ungulates { Name = "Антилопа", BirthDate = new DateTime(2020, 6, 13), Weight = 76 },
                new Ungulates { Name = "Бык", BirthDate = new DateTime(2002, 6, 13), Weight = 81 },
                new Ungulates { Name = "Корова", BirthDate = new DateTime(2020, 6, 13), Weight = 75 },
                new Feline { Name = "Лев", BirthDate = new DateTime(1990, 6, 13), Weight = 100 },
                new Feline { Name = "Багира", BirthDate = new DateTime(2007, 6, 13), Weight = 44 },
                new Feline { Name = "Гепард", BirthDate = new DateTime(2016, 6, 13), Weight = 33 },
                new Canine { Name = "Dogo", BirthDate = new DateTime(2020, 6, 13), Weight = 81 },
                new Canine { Name = "Волк", BirthDate = new DateTime(2004, 6, 13), Weight = 81 }
            };
        }

        public Animals[] GetAll()
        {
            return _animals;
        }
    }
}
