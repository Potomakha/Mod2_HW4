using Mod2_HW4.AnimalsArchitectгre;
using Mod2_HW4.Configs;
using Mod2_HW4.Interfaces;

namespace Mod2_HW4.Services
{
    public class AnimalParkService : IAnimalContainer
    {
        private int _capacity;
        private Animals[] _animals;

        public AnimalParkService()
        {
            Init();
        }

        public bool Add(Animals item)
        {
            if (_capacity == _animals.Length)
            {
                return false;
            }

            _animals[_capacity] = item;
            _capacity++;

            return true;
        }

        public void Clean()
        {
            Init();
        }

        public Animals[] GetComponents()
        {
            var animals = new Animals[_capacity];

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = _animals[i];
            }

            return animals;
        }

        private void Init()
        {
            _capacity = 0;
            _animals = new Animals[ParkConfig.ParkCapacity];
        }
    }
}
