using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
        private Node<int> Root { get; set; }
        public void Add(int value)
        {
            if (AddHelper(Root, value))
                Root = new Node<int>(value);
        }
        private bool AddHelper(Node<int> node, int value)
        {
            if (node == null)
                return true;
            if (node.Value > value)
                if (AddHelper(node.Left, value))
                    node.Left = new Node<int>(value);
            if (node.Value < value)
                if (AddHelper(node.Right, value))
                    node.Right = new Node<int>(value);
            return false;
        }
        public bool Contains(int value)
        {
            return ContainsHelper(Root, value);
        }

        private bool ContainsHelper(Node<int> node, int value)
        {
            if (node == null)
                return false;
            if (node.Value == value)
                return true;
            if (node.Value > value)
                return ContainsHelper(node.Left, value);
            if (node.Value < value)
                return ContainsHelper(node.Right, value);
            throw new InvalidOperationException("Unexpected error.");
        }
    }
}
