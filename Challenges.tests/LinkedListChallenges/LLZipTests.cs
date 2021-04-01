using DataStructures.LinkedLists;
using Challenges.LinkedListChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.LinkedListChallenges
{
    public class LLZipTests
    {
        [Fact]
        public void ZipLists_returns_list2_if_list1_is_empty() // would be something to check with interviewer about
        {
            // arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // act
            LinkedList result = LLZip.ZipLists(list1, list2);

            // assert
            Assert.Equal(list2, result);

        }
        [Fact]
        public void ZipLists_returns_list1_if_list2_is_empty_and_list1_is_not()
        {
            // arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(3);

            // act
            LinkedList result = LLZip.ZipLists(list1, list2);

            // assert
            Assert.Equal(list1, result);

        }
    }
}
