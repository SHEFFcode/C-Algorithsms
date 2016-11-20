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

            int numbersAbove = Counting.CountIfAbove(collection: arrayOfIntegers, key: 5);
            Console.WriteLine($"numbers above 5 are {numbersAbove}");


            int maxNumber = Counting.FindMax(arrayOfIntegers);
            Console.WriteLine($"the maximum value of this collection is {maxNumber}");


            //Find an a common object in two collections.
            List<string> westCoastCities = new List<string>() { "San Francisco", "San Jose", "Oakland", "Los Angeles", "San Diego", "Portland", "Seattle" };
            List<string> coolCities = new List<string>() { "San Francisco", "Seattle", "Boston", "Chicago", "New York City" };

            var intersectionResult = Sets.Intersection(westCoastCities, coolCities);
            intersectionResult.ForEach(x => Console.WriteLine($"{x} is on both lists."));
            //Console.WriteLine($"The number of cities on both lists is {intersectionResult.ToString()}");


            //Here we want to return the union of both lists, such that no item is doubled up.

            var unionResult = Sets.Union(coolCities, westCoastCities);
            unionResult.ForEach(x => Console.WriteLine($"{x}"));


            //create a stack

            Stack<int> stack = new Stack<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.PrintStack();

            stack.Pop();

            stack.PrintStack();

            //create a linked list of integers

            LinkedList<int> integerLinkedList = new LinkedList<int>(5);
            integerLinkedList.Add(1);
            integerLinkedList.Add(2);
            integerLinkedList.Add(3);
            integerLinkedList.Add(4);
            integerLinkedList.Add(5);

            integerLinkedList.PrintList();

            integerLinkedList.Contains(3);

            integerLinkedList.TryDelete(3);

            foreach (var item in integerLinkedList)
            {
                Console.WriteLine($"Item {item} is in the linked list");
            }


            //Binary tree
            BinaryTree<int> myBinaryTree = new BinaryTree<int>(10);
            myBinaryTree.Add(5);
            myBinaryTree.Add(15);
            myBinaryTree.Add(2);
            myBinaryTree.Add(6);
            myBinaryTree.Add(14);
            myBinaryTree.Add(16);
            myBinaryTree.Add(1);
            myBinaryTree.Add(3);

            Console.WriteLine($"My Binary Search Tree Search for 16 returns {myBinaryTree.Search(16)}");
            Console.WriteLine($"My Binary Search Tree Search for 17 returns {myBinaryTree.Search(17)}");

            myBinaryTree.Delete(1);
            myBinaryTree.Delete(15);


            foreach (var item in myBinaryTree)
            {
                Console.WriteLine($"{item} ->");
            }


            Console.ReadLine();



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
