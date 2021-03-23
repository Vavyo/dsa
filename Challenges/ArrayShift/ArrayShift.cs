using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.ArrayChallenges
{
    public class ArrayShift
    {
        public static int[] InsertShiftArray(int[] oldArr, int num)
        {
            int[] newArr = new int[oldArr.Length+1];
            int halfwayIndex = newArr.Length / 2;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < halfwayIndex)
                {
                    newArr[i] = oldArr[i];
                }
                else if (i == halfwayIndex)
                {
                    newArr[i] = num;
                }
                else if (i > halfwayIndex)
                {
                    newArr[i] = oldArr[i - 1];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index doesnt compare to halfway index");
                }
            }
            return newArr;
        }
    }
}
