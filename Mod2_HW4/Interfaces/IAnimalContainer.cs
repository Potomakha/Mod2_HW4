using Mod2_HW4.AnimalsArchitectгre;

namespace Mod2_HW4.Interfaces
{
    public interface IAnimalContainer
    {
        public bool Add(Animals item);
        public void Clean();
        public Animals[] GetComponents();
    }
}
