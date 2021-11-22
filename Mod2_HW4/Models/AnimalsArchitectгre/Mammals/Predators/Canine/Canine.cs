using Mod2_HW4.AnimalsArchitectгre.HelpTypes;

namespace Mod2_HW4.AnimalsArchitectгre.Mammals.Predators.Canine
{
    public class Canine : Predators
    {
        public Canine()
        {
            SuborderPredator = SuborderPredatorTypes.Canine;
            CoverType = CoverTypes.Wool;
            MovementType = MovementTypes.Walking;
        }
    }
}
