using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
