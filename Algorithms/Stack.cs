using System;
using System.Collections;
namespace Algorithms
{
    public class Stack<T>
    {
        private T[] items;
        private int pointer = 0;
        public Stack(int size)
        {
            items = new T[size];
        }

        public void Push(T value)
        {
            if (pointer < items.Length)
            {
                items[pointer++] = value;
            }
            else 
            {
                Console.WriteLine("Maximum size reached, cannot push any more items into this stack.");
            }
        }

        public T Pop()
        {
            pointer -= 1;
            if (pointer >= 0)
            {
                items[pointer] = default(T);
                return items[pointer];
                //return items[--pointer];
            }
            else 
            {

                throw new Exception("Reached the last element in the stack, can't pop any more.");
            }

        }

        public void PrintStack()
        {
            for (int i = 0; i < pointer; i++)
            {
                Console.WriteLine(items[i]);
            }
        }


    }
}
