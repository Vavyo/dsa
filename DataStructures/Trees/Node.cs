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
        // Adds a node using a binary search tree sorting
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
        // Uses FindEmptyNode() to find the first empty node and then adds the new node to it
        public void AddNode(Node<T> node)
        {
            Node<T> parent = FindEmptyNode();
            if (parent.Left == null)
            {
                parent.Left = node;
            }
            else if(parent.Right == null)
            {
                parent.Right = node;
            }
        }
        // Performs a depth first traversal to find the first empty node and returns it
        public Node<T> FindEmptyNode()
        {
            if(Left == null || Right == null)
            {
                return this;
            }
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(Left);
            queue.Enqueue(Right);
            return queue.Dequeue().FindEmptyNode(queue);
        }
        // Helper method for the traversal.
        public Node<T> FindEmptyNode(Queue<Node<T>> queue)
        {
            if (Left == null || Right == null)
            {
                return this;
            }
            queue.Enqueue(Left);
            queue.Enqueue(Right);
            return queue.Dequeue().FindEmptyNode(queue);
        }
    }
}
