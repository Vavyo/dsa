using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.StackAndQueue;

namespace Challenges.StackAndQueueChallenges
{
    public class PseudoQueue<T> : IQueue<T>
    {
        private DataStructures.StackAndQueue.Stack<T> storage = new DataStructures.StackAndQueue.Stack<T>();
        private DataStructures.StackAndQueue.Stack<T> offLoad = new DataStructures.StackAndQueue.Stack<T>();
        public bool IsEmpty => storage.IsEmpty && offLoad.IsEmpty;

        public T Dequeue()
        {
            SwapStorage(false);
            return offLoad.Pop();
        }

        public void Enqueue(T value)
        {
            SwapStorage(true);
            storage.Push(value);
        }

        public T Peek()
        {
            SwapStorage(false);
            return offLoad.Peek();
        }
        private void SwapStorage(bool setToInput)
        {
            if (IsEmpty)
                return;
            if (setToInput)
            {
                if (storage.IsEmpty)
                {
                    while (!offLoad.IsEmpty)
                        storage.Push(offLoad.Pop());
                }
            }
            else
            {
                if (offLoad.IsEmpty)
                {
                    while (!storage.IsEmpty)
                        offLoad.Push(storage.Pop());
                }
            }
        }


    }
}
