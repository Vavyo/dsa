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

            while(current1 != null)
            {
                current1 = current1.Next;
            }
            return list1;
        }
    }
}
