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
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Head = new Node(value);
            Head.Next = Current;
            Current = Head;
        }
        public string ToString()
        {
            Current = Head;
            string result = "";
            if (Current is null)
                return null;
            do
            {
                result += Current.Value;
                if(Current.Next is null)
                    break;
                result += ",";
                Current = Current.Next;

            } while (true);
            return result;
        }
        public bool Includes(int value)
        {
            Current = Head;
            if(Current is null)
                return false;
            do
            {
                if(Current.Value == value)
                    return true;
                else if (Current.Next is null)
                    return false;
                else
                    Current = Current.Next;
            } while (true);
        }
    }
}
