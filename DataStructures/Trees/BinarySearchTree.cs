using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T> : Tree<T> where T : IComparable
    {
        public void AddNode(T value)
        {
            Node<T> node = new Node<T>(value);
            if(Root == null)
            {
                Root = node;
            }
            Root.AddSearchNode(node);
        }
    }
}
