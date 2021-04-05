using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> Top { get; set; }

        public bool IsEmpty => Top == null;

        public Stack()
        {
            Top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        public T Pop()
        {
            T result = Top.Value;
            Top = Top.Next;
            return result;
        }

        public T Peek()
        {
            return Top.Value;
        }
    }
}
