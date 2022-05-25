using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        public Node<T> Left { get => Root.Left; set => Root.Left = value; }
        public Node<T> Right { get => Root.Right; set => Root.Right = value; }

        public Tree(T rootValue)
        {
            Node<T> rootNode = new Node<T>(rootValue);
        }
        public Tree() { }

        public void AddValue(T value)
        {
            Node<T> node = new Node<T>(value);
            
        }


        public T[] PreOrder()
        {
            Queue<T> result = new Queue<T>();
            PreOrder(Root, result);
            T[] arr = new T[result.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = result.Dequeue();
            }
            return arr;
        }
        private void PreOrder(Node<T> node, Queue<T> list)
        {
            if (node == null)
                return;
            list.Enqueue(node.Value);
            if(node.Left != null)
            {
                PreOrder(node.Left, list);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right, list);
            }
            
        }
        // Returns the number of nodes in the tree.
        public int Count()
        {
            Queue<T> result = new Queue<T>();
            PreOrder(Root, result);

            return result.Count;
        }
    }
}
