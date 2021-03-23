using Challenges.ArrayChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.ArrayChallenges
{
    public class ArrayReverseTest
    {
        [Fact]
        public void Reverse_returns_empty_array_given_empty_array()
        {
            // Arrange
            int[] arr = new int[0];

            // Act
            int[] result = ArrayReverse.Reverse(arr);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Reverse_returns_reversed_array_given_odd_length_array()
        {
            // Arrange
            int[] arr = new int[3] { 1, 2, 3 };

            // Act
            int[] result = ArrayReverse.Reverse(arr);

            // Assert
            Assert.Equal(3, result.Length);

            Assert.Equal(3, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(1, result[2]);
        }

        [Fact]
        public void Reverse_returns_reversed_array_given_even_length_array()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 3 , 4 };

            // Act
            int[] result = ArrayReverse.Reverse(arr);

            // Assert
            int[] expected = new int[] { 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }

    }
}
