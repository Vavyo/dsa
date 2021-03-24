using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.ArrayChallenges
{
    public class ArrayBinarySearch
    {
        public static int BinarySearch(int[] arr, int searchNum)
        {
            int result = -1;

            int low = 0;
            int high = arr.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (high + low) / 2;

                if (arr[mid] == searchNum)
                {
                    result = mid;
                    for (int i = mid; i >= 0 && arr[i] == searchNum; --i)
                    {
                        result =  i;
                    }
                    return result;
                }
                else if (arr[mid] > searchNum)
                {
                    high = mid - 1;
                }
                else if (arr[mid] < searchNum)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return result;
        }
    }
}
