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

        public BinaryTree<T> FindMinimumValue(BinaryTree<T> tree)
        {
            BinaryTree<T> current = tree;
            while (current.Right != null)
            {
                current = current.Right;
            }

            return current;
        }

        public BinaryTree<T> FindMaximumValue(BinaryTree<T> tree)
        {
            BinaryTree<T> current = tree;
            while (current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }

        public BinaryTree<T> FindSuccessor(BinaryTree<T> tree)
        {
            if (tree.Right != null)
            {
                return FindMinimumValue(tree);
            }
            else 
            {
                BinaryTree<T> hub = tree;
                BinaryTree<T> current = this;

                List<KeyValuePair<BinaryTree<T>, bool>> nodes = new List<KeyValuePair<BinaryTree<T>, bool>>();

                while (!current.Value.Equals(tree.Value))
                {
                    if (current.Value.CompareTo(tree.Value) < 0)
                    {
                        current = current.Right;
                        nodes.Add(new KeyValuePair<BinaryTree<T>, bool>(current, false));
                    }
                    else if (current.Value.CompareTo(tree.Value) > 0)
                    {
                        current = current.Left;
                        nodes.Add(new KeyValuePair<BinaryTree<T>, bool>(current, true));
                    }
                }

                var tempArray = nodes.ToArray();
                for (int i = tempArray.Length; i >= 0; i--)
                {
                    if (tempArray[i].Value == true)
                    {
                        hub = tempArray[i].Key ;
                    }
                }

                return hub;
            }
        }
    }
}
