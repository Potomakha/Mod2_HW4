using System;
using Mod2_HW4.AnimalsArchitectгre;

namespace Mod2_HW4.Extensions
{
    public static class ArrayExtension
    {
        public static Animals[] Filter(this Animals[] array, string name, int? maxAge = null)
        {
            var result = new Animals[array.Length];
            int resultCapacity = 0;

            if (string.IsNullOrEmpty(name) && maxAge.Equals(null))
            {
                return array;
            }

            if (maxAge.Equals(null))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                    {
                        result[resultCapacity] = array[i];
                        resultCapacity++;
                    }
                }

                Array.Resize(ref result, resultCapacity);
                return result;
            }

            if (string.IsNullOrEmpty(name))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Age <= maxAge)
                    {
                        result[resultCapacity] = array[i];
                        resultCapacity++;
                    }
                }

                Array.Resize(ref result, resultCapacity);
                return result;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i].Age <= maxAge) && array[i].Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    result[resultCapacity] = array[i];
                    resultCapacity++;
                }
            }

            Array.Resize(ref result, resultCapacity);
            return result;
        }
    }
}
