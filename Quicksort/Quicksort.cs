using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    public class Quicksort
    {
        private int temp;
        private int i, j;
       // int[] unsortedArray;
        //public Quicksort(int[] array) { this.unsortedArray = array; }
        public Quicksort() { }

        public int[] sorting(int[] unsortedArray, int left, int right)
        {
            
            int middle_element = unsortedArray[left + (right - left) / 2];
            i = left;
            j = right;
            participle(unsortedArray, middle_element);
            if (i < right)
                sorting(unsortedArray, i, right);
            if (left < j)
                sorting(unsortedArray, left, j);
            return unsortedArray;
        }

        private void participle(int[] unsortedArray, int middle_element)
        {
            while (i < j)
            {
                while (unsortedArray[i] < middle_element) i++;
                while (unsortedArray[j] > middle_element) j--;
                if (i <= j)
                {
                    temp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = temp;
                    i++;
                    j--;
                }
            }
        }



    }
}
