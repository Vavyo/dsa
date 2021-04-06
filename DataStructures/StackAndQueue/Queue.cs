using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    public class Queue<T> : IQueue<T>
    {
        private Node<T> Front { get; set; }
        private Node<T> End { get; set; } // don't know how you would enqueue with O(1) without this
        public bool IsEmpty => Front == null;

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if(Front == null)
                Front = node;
            else
                End.Next = node;
            End = node;
        }
        public T Dequeue()
        {
            T result = Front.Value;
            if (Front == End) // not necessary for now but may be useful later
                End = null;
            Front = Front.Next;
            return result;
        }
        public T Peek()
        {
            return Front.Value;
        }
    }
}
