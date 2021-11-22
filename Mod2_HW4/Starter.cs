using System;
using System.Text;
using Mod2_HW4.AnimalsArchitectгre;
using Mod2_HW4.Services;

namespace Mod2_HW4
{
    public class Starter
    {
        private readonly AnimalParkService _animalParkService;
        private readonly ParkInitService _parkInitService;
        private readonly AnimalTypesCulculator _animalTypesCulculator;

        public Starter()
        {
            _animalParkService = new AnimalParkService();
            _parkInitService = new ParkInitService();
            _animalTypesCulculator = new AnimalTypesCulculator();
        }

        public void Run()
        {
            var animals = _parkInitService.GetAll();

            for (int i = 0; i < animals.Length; i++)
            {
                _animalParkService.Add(animals[i]);
            }

            animals = _animalParkService.GetComponents();
            var numTypes = _animalTypesCulculator.TypesCount(animals);
            Display(animals);
            Console.WriteLine($"Количетво видов {numTypes}");
        }

        private void Display(Animals[] animals)
        {
            var animalsInfo = new StringBuilder();

            foreach (var item in animals)
            {
                animalsInfo.AppendLine($"{item.Name}. Возраст - {item.Age}");
            }

            Console.WriteLine(animalsInfo.ToString());
        }
    }
}
