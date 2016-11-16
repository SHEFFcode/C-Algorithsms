using System;
namespace Algorithms
{
    public class Counting
    {
        public static int CountIfAbove(int[] collection, int key)
        {
            int counter = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] > key)
                {
                    counter++;
                }
            }


            return counter;
        }

        public static int FindMax(int[] collection)
        {
            int max = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[max] < collection[i])
                {
                    max = i;
                }
            }

            return max;
        }
    }
}
