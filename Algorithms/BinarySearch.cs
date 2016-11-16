using System;
namespace Algorithms
{
    public class BinarySearch
    {

        public static int Search(int[] collection, int valueToFind)
        {
            int first = 0;
            int last = collection.Length - 1;

            while (first <= last)
            {
                int middle = (first + last) / 2;
                if (collection[middle] == valueToFind) {
                    return middle;
                }
                else if (valueToFind < collection[middle])
                {
                    last = middle - 1;

                }
                else 
                {
                    first = middle + 1;

                }
            }


            return -1;
        }
        
    }
}
