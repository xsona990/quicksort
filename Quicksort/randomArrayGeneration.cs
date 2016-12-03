using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    public static class randomArrayGeneration
    {
        public static int[] generateArray(int elementsCount, int minElementValue,int maxElementValue)
        {
            if (elementsCount <= 0)
                return null;
            else { 
            Random rnd = new Random();
            int[] elements = new int[elementsCount];
            for (int i = 0; i < elementsCount; i++)
            {
                elements[i] = rnd.Next(minElementValue, maxElementValue+1);
                    
                //result += " " + elements[i].ToString();
            }
            return elements;
            }
        }
    }
}
