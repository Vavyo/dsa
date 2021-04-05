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
        public bool IsEmpty => throw new NotImplementedException();

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T value)
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
