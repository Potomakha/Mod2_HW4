using System.Collections.Generic;
using Mod2_HW4.AnimalsArchitectгre;

namespace Mod2_HW4.Services
{
    public class AnimalsComparerService : IComparer<Animals>
    {
        public int Compare(Animals x, Animals y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
