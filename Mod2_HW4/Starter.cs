using System;
using System.Text;
using Mod2_HW4.AnimalsArchitectгre;
using Mod2_HW4.Services;
using Mod2_HW4.Extensions;

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
            Console.WriteLine(string.Empty);

            Array.Sort(animals, new AnimalsComparerService());
            Console.WriteLine("Массив отсортирован по возрасту: ");
            Display(animals);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Выборка животных: ");
            var filtered = animals.Filter("о", 19);
            Display(filtered);
        }

        private void Display(Animals[] animals)
        {
            var animalsInfo = new StringBuilder();

            foreach (var item in animals)
            {
                animalsInfo.AppendLine($"{item.Name}. Возраст - {item.Age}");
            }

            Console.Write(animalsInfo.ToString());
        }
    }
}
