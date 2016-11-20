using System;
using System.Collections;
using System.Collections.Generic;
namespace Algorithms
{
    public class BinaryTree<T> : IEnumerable<T> where T: IComparable
    {
        public T Value
        {
            get;
            set;
        }

        public BinaryTree<T> Left
        {
            get;
            set;
        }

        public BinaryTree<T> Right
        {
            get;
            set;
        }

        public BinaryTree(T value)
        {
            Value = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Add(T newValue)
        {
            AddToNode(this, newValue);
        }

        private void AddToNode(BinaryTree<T> node, T newValue)
        {
            if (node.Value.CompareTo(newValue) < 0)
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTree<T>(newValue);
                }
                else 
                {
                    AddToNode(node.Right, newValue);
                }
            }
            if (node.Value.CompareTo(newValue) > 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTree<T>(newValue);
                }
                else
                {
                    AddToNode(node.Left, newValue);
                }
            }
        }

        public bool Search(T value)
        {
            return SearchInNodes(this, value);
        }

        private bool SearchInNodes(BinaryTree<T> tree, T value)
        {
            if (tree.Value.Equals(value))
            {
                return true;
            }
            else if (tree.Right == null && tree.Left == null)
            {
                return false;
            }
            else if (tree.Value.CompareTo(value) < 0)
            {
                return SearchInNodes(tree.Right, value);
            }
            else if (tree.Value.CompareTo(value) > 0)
            {
                return SearchInNodes(tree.Left, value);
            }
            else
            {
                return false;
            }
        }
    }
}
