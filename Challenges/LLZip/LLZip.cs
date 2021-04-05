using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.LinkedLists;

namespace Challenges.LinkedListChallenges
{
    public class LLZip
    {
        public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            if(list1.Head == null) // would be something to check with interviewer about
            {
                return list2;
            }

            Node current1 = list1.Head;
            Node current2 = list2.Head;
            Node tempHead;

            while(current1 != null && current2 != null)
            {
                tempHead = current2.Next;
                current2.Next = current1.Next;
                current1.Next = current2;
                if (current2.Next == null)
                {
                    current2.Next = tempHead;
                    break;
                }
                current1 = current2.Next;
                current2 = tempHead;
            }
            return list1;
        }
    }
}
