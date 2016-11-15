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
