using Challenges.ArrayChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.ArrayChallenges
{
    public class ArrayShiftTest
    {
        [Fact]
        public void InsertShiftArray_on_odd_size_returns_array_of_correct_size()
        {
            // arrange
            int[] arr = new int[4] { 1, 2, 3, 4 };
            int num = 5;

            // act
            int[] result = ArrayShift.InsertShiftArray(arr, num);

            // assert
            Assert.Equal(5, result.Length);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 4, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 5, new int[] { 1, 2, 5, 3, 4 })]
        [InlineData(new int[] { }, 5, new int[] { 5 })]
        public void InsertShiftArray_returns_array_with_correct_values(int[] arr, int num, int[] expected)
        {
            // act
            int[] result = ArrayShift.InsertShiftArray(arr, num);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
