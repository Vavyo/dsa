using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.StackAndQueue;

namespace Challenges.StackAndQueueChallenges
{
    public class PseudoQueue<T> : IQueue<T>
    {
        private DataStructures.StackAndQueue.Stack<T> Storage = new DataStructures.StackAndQueue.Stack<T>();
        private DataStructures.StackAndQueue.Stack<T> Reverse = new DataStructures.StackAndQueue.Stack<T>();
        public bool IsEmpty => Storage.IsEmpty && Reverse.IsEmpty;

        public T Dequeue()
        {
            ReverseStorage(false);
            return Reverse.Pop();
        }

        public void Enqueue(T value)
        {
            ReverseStorage(true);
            Storage.Push(value);
        }

        public T Peek()
        {
            ReverseStorage(false);
            return Reverse.Peek();
        }
        private void ReverseStorage(bool setToInput)
        {
            if (IsEmpty)
                return;
            if (setToInput) // set true for enqueue
            {
                if (Storage.IsEmpty)
                {
                    while (!Reverse.IsEmpty)
                        Storage.Push(Reverse.Pop());
                }
            }
            else // 
            {
                if (Reverse.IsEmpty)
                {
                    while (!Storage.IsEmpty)
                        Reverse.Push(Storage.Pop());
                }
            }
        }


    }
}
