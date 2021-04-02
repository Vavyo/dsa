using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    public class Stack<T>
    {
        private Node<T> Top { get; set; }
        public Stack()
        {
            Top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            Top = node;
        }

        public bool isEmpty()
        {
            return Top == null;
        }

        public T Pop()
        {
            T result = Top.Value;
            
            return result;
        }

        public T Peek()
        {
            return Top.Value;
        }
    }
}
