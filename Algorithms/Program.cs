using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//collections

			//1. Array - you must know it's size and type

			string[] ArrayOfStrings = { "Jeremy", "James", "John" };

			foreach (var element in ArrayOfStrings)
			{
				Console.WriteLine(element);
			}

			Console.WriteLine(ArrayOfStrings.FirstOrDefault());

			//2. List - can be of different sizes, but of the same type
			List <string> stringList = new List<string>();


		}
	}
}
