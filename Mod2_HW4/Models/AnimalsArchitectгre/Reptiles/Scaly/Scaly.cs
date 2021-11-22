using Mod2_HW4.AnimalsArchitectгre.HelpTypes;

namespace Mod2_HW4.AnimalsArchitectгre.Reptiles.Scaly
{
    public abstract class Scaly : Reptiles
    {
        public Scaly()
        {
            CoverType = CoverTypes.Flakes;
        }

        public ScalyTypes ScalyType { get; init; }
    }
}
