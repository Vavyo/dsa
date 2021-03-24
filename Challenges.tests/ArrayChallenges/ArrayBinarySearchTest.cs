using Challenges.ArrayChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.ArrayChallenges
{
    public class ArrayBinarySearchTest
    {
        [Fact]
        public void BinarySearch_returns_an_index_of_the_array_if_search_present()
        {
            // arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int search = 2;

            // act
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void BinarySearch_returns_negative_1_if_no_result()
        {
            // arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int search = 10;

            // act
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void BinarySearch_returns_the_index_of_the_first_occurence()
        {
            // arrange
            int[] arr = { 1, 2, 2, 2, 2, 2, 7 };
            int search = 2;

            // act
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void BinarySearch_returns_negative_1_if_array_is_null()
        {
            // arrange
            int[] arr = new int[0];
            int search = 2;

            // act
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(-1, result);
        }
        [Fact]
        public void BinarySearch_returns_searched_index_if_array_is_size_1()
        {
            // arrange
            int[] arr = new int[] { 7 };
            int search = 7;

            // act 
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void BinarySearch_returns_searched_index_if_search_is_at_index_0()
        {
            // arrange
            int[] arr = new int[] { 1, 2, 3, 5, 7, 9 };
            int search = 1;

            // act 
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void BinarySearch_returns_searched_index_if_search_is_at_max_index()
        {
            // arrange
            int[] arr = new int[] { 1, 2, 3, 5, 7, 9 };
            int search = 9;

            // act 
            int result = ArrayBinarySearch.BinarySearch(arr, search);

            // assert
            Assert.Equal(5, result);
        }
    }
}
