﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T value)
        {
            Value = value;
        }
            
    }
}
