using System;
using System.Collections.Generic;
namespace Algorithms
{
    public class LinkedList<T> : IEnumerable<T>
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
                

                if (current.Value.Equals(value))
                {
                    Console.WriteLine($"Linked List Contains {value}");
                    return true;
                }

                current = current.Next;
            }

            Console.WriteLine($"Linked List does not contain {value}");
            return false;
        }

        public bool TryDelete(T item)
        {
            if (Contains(item))
            {
                if (First.Value.Equals(item))
                {
                    First = First.Next;
                }
                else 
                {
                    ListItem<T> current = First;
                    while (current.Value != null)
                    {
                        if (current.Next.Value.Equals(item))
                        {
                            current.Next = current.Next.Next;
                            break;
                        }
                        else 
                        {
                            current = current.Next;
                        }


                    }
                }
                Console.WriteLine($"Deleted Linked List item {item}");
                return true;
            }
            Console.WriteLine($"Could not find Linked List Item {item}");
            return false;

        }


        public IEnumerator<T> GetEnumerator()
        {
            ListItem<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
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
