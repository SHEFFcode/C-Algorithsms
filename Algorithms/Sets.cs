using System;
using System.Collections.Generic;
namespace Algorithms
{
    public class Sets
    {
        public static int Intersection(List<string> a, List<string> b)
        {
            int intersection = 0;

            foreach (var item in b)
            {
                if (Contains(a, item))
                {
                    intersection++;
                }
            }




            return intersection;
        }

        private static bool Contains(List<string> array, string key)
        {

            foreach (var item in array)
            {
                if (item == key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
