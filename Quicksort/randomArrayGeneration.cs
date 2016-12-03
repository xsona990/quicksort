using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    public class randomArrayGeneration
    {
        randomArrayGeneration() { }

        public int[] generateArray(int elementsCount, int maxElementValue, int minElementValue)
        {
            Random rnd = new Random();
            int[] elements = new int[elementsCount];
            for (int i = 0; i <= elementsCount; i++)
            {
                elements[i] = rnd.Next(minElementValue, ++maxElementValue);
            }
            return elements;
        }
    }
}
