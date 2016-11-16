using System;
using System.Collections.Generic;
namespace Algorithms
{
    public class Sets
    {
        public static List<string> Intersection(List<string> a, List<string> b)
        {
            int intersection = 0;
            List<string> intersectionList = new List<string>();

            foreach (var item in b)
            {
                if (Contains(a, item))
                {
                    intersection++;
                    intersectionList.Add(item);
                }
            }




            return intersectionList;
        }

        public static List<string> Union(List<string> a, List<string> b)
        {

            List<string> result = new List<string>();

            result = a;

            foreach (var item in b)
            {
                if (!Contains(a, item))
                {
                    result.Add(item);
                }
            }




            return result;
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
