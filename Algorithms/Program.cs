using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            var result = Sum(new int[] {1, 3, 2});
            Console.WriteLine(result);


            var fibresult = Fib(4);
            Console.WriteLine(fibresult);


            //we will make a decision whether a collection has a certain element or not
            int[] arrayOfIntegers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool gtt = HasValueGreaterThenTen(arrayOfIntegers);
            Console.WriteLine(gtt);


            int res = LinearSearch.Search(arrayOfIntegers, 11);
            Console.WriteLine(res);


            int binaryRes = BinarySearch.Search(arrayOfIntegers, 3);
            Console.WriteLine($"binary search result = {binaryRes}");

		}

        static bool HasValueGreaterThenTen(int[] arr)
        {

            foreach (var number in arr)
            {
                if (number > 10) {
                    return true;
                }
            }


            return false;
            
        }

		static int Sum(int[] array) 
		{
			int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            return sum;
		}

        static int Fib(int index) 
        {

            int first = 0;
            int second = 1;

            for (int i = 0; i < index; i++)
            {
                int temp = first;
                first = second;
                second = temp + first;
            }

            return first;
        }


       



	}
}
