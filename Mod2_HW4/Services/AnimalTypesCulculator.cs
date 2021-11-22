using System.Text;
using Mod2_HW4.AnimalsArchitectгre;
using Mod2_HW4.Interfaces;

namespace Mod2_HW4.Services
{
    public class AnimalTypesCulculator : IAnimalTypesCalculator
    {
        public int TypesCount(Animals[] animals)
        {
            var numTypes = 0;
            var typesContainer = new StringBuilder();

            foreach (var item in animals)
            {
                var itemTypes = item.GetType().Name;
                if (!typesContainer.ToString().Contains(itemTypes))
                {
                    typesContainer.AppendLine(item.GetType().Name);
                    numTypes++;
                }
            }

            return numTypes;
        }
    }
}
