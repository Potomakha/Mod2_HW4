using Mod2_HW4.AnimalsArchitectгre.HelpTypes;

namespace Mod2_HW4.AnimalsArchitectгre.Reptiles
{
    public abstract class Reptiles : Animals
    {
        public Reptiles()
        {
            MovementType = MovementTypes.Grovel;
        }
    }
}
