using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class Node<T> where T : IComparable
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T value)
        {
            Value = value;
        }
        public void AddSearchNode(Node<T> node)
        {
            if(node.Value.CompareTo(Value) < 0)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.AddSearchNode(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.AddSearchNode(node);
                }
            }
        }
            
    }
}
