using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> Left { get => Root.Left; set => Root.Left = value; }
        public Node<T> Right { get => Root.Right; set => Root.Right = value; }

        public T[] PreOrder()
        {
            if (Root == null)
                throw new InvalidOperationException("Tree is empty");
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
    }
}
