using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.ArrayChallenges
{
    class ArrayReverse
    {
        public static int[] Reverse(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[arr.Length - 1 - i];
            }
            return newArr;
        }
    }
}
