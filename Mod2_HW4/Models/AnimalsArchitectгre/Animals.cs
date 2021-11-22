using System;
using Mod2_HW4.AnimalsArchitectгre.HelpTypes;

namespace Mod2_HW4.AnimalsArchitectгre
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; init; }
        public DateTime BirthDate { get; init; }
        public MovementTypes MovementType { get; init; }
        public CoverTypes CoverType { get; init; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
    }
}
