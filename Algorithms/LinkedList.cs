using System;
namespace Algorithms
{
    public class LinkedList<T>
    {
        private ListItem<T> First { get; set; }
        public int Length = 0;

        //one way to initialize it
        public LinkedList(T initialValue)
        {
            First = new ListItem<T>() { Value = initialValue };
        }

        //another way to initialize it, calling the constructor with passed in value.
        public static LinkedList<T> CreateWithInitialValue(T initialValue) 
        {
            return new LinkedList<T>(initialValue);
        }

        public void Add(T item) 
        {
            ListItem<T> current = First;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new ListItem<T>() {Value = item};

            Length++;

        }

        public bool Contains(T value)
        {
            ListItem<T> current = First;
            while (current != null)
            {
                current = current.Next;

                if (current.Value.Equals(value))
                {
                    Console.WriteLine($"Linked List Contains {value}");
                    return true;
                }
            }

            Console.WriteLine($"Linked List does not contain {value}");
            return false;
        }

        public void PrintList() 
        {
            ListItem<T> current = First;
            while (current.Next != null)
            {
                Console.WriteLine($"Linked List Item {current.Value}");
                current = current.Next;
            }

        }
    }
}
