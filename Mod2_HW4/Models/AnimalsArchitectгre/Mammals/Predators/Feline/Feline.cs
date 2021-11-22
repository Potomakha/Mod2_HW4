using Mod2_HW4.AnimalsArchitectгre.HelpTypes;

namespace Mod2_HW4.AnimalsArchitectгre.Mammals.Predators.Feline
{
    public class Feline : Predators
    {
        public Feline()
        {
            SuborderPredator = SuborderPredatorTypes.Feline;
            CoverType = CoverTypes.Wool;
            MovementType = MovementTypes.Walking;
        }
    }
}
