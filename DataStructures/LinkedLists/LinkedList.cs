using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; private set; }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }
        public override string ToString()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += $"{current.Value},";
                current = current.Next;
            }
            result += "NULL";

            return result;
        }
        public bool Includes(int value)
        {
            Node current = Head;
            if(current is null)
                return false;
            do
            {
                if(current.Value == value)
                    return true;
                else if (current.Next is null)
                    return false;
                else
                    current = current.Next;
            } while (true);
        }
        public void Append(int value)
        {
            
            if (Head == null)
            {
                Insert(value);
                return;
            }
            Node newNode = new Node(value);
            Node current = Head;

            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
        }

        public void InsertBefore(int valueBefore, int newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            if( Head == null)
                throw new ArgumentException("Value not found");
            if (current.Value == valueBefore)
            {
                newNode.Next = current;
                Head = newNode;
                return;
            }
            while(current != null)
            {
                if (current.Next == null)
                    throw new ArgumentException("Value not found");
                else if (current.Next.Value == valueBefore)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
        }

        public void InsertAfter(int valueAfter, int newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            while (current != null)
            {
                if (current.Value == valueAfter)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("Value not found");
        }
    }
}
