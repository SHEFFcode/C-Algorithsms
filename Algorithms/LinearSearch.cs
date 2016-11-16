using System;
namespace Algorithms
{
    public static class LinearSearch
    {
        /// <summary>
        /// Use search value to find it is present in the collection
        /// </summary>
        /// <param name="collection">Collection the search will be executed on</param>
        /// <param name="searchNumber">Search number that we are trying to find in the collection</param>
        public static int Search(int[]collection, int searchNumber)
        {
            int i = 0;
            foreach (var item in collection)
            {
                if (item == searchNumber) {
                    return i;
                }
                i++;
            }

            return -1;
        }
    }
}
