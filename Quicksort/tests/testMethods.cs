using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort.tests
{
    public class testMethods
    {
        public bool isInRange()
        {
            bool result = true;
            int min = -1000;
            int max = 1000;
            int count = 100000;
            int[] array = randomArrayGeneration.generateArray(count, min, max);
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] < min)
                    result = false;
                if (array[i] > max)
                    result = false;
            }
            return result;
        }
    }
}
