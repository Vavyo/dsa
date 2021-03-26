using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructures.tests.LinkedLists
{

    public class LinkedListTests
    {
        [Fact]
        public void Empty_list_has_null_Head()
        {
            // arrange / act
            LinkedList list = new LinkedList();

            // assert
            Assert.Null(list.Head);
        }
        [Fact]
        public void Insert_works_for_empty_list()
        {
            //arrange
            LinkedList list = new LinkedList();
            int value = 5;

            //act
            list.Insert(value);

            //assert
            Assert.NotNull(list);
            Assert.Equal(value, list.Head.Value);
            Assert.Null(list.Head.Next);
        }
        [Fact]
        public void Insert_works_for_list_that_is_not_empty()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);

            int value = 9;

            list.Insert(value);

            Assert.NotNull(list.Head);
            Assert.Equal(value, list.Head.Value);
            Assert.NotNull(list.Head.Next);
            Assert.Equal(5, list.Head.Next.Value);
        }
        [Theory]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(1, false)]
        [InlineData(5, false)]
        [InlineData(7, false)]
        public void Inclue_works(int valueToFind, bool expected)
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(4);

            bool result = list.Includes(valueToFind);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void ToString_returns_null_with_empty_list()
        {
            // arrange
            LinkedList list = new LinkedList();

            // act
            string result = list.ToString();

            // assert
            Assert.Null(result);
        }
        [Fact]
        public void ToString_returns_one_value_with_single_node_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(6);

            // act
            string result = list.ToString();

            // assert
            string expected = "6";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ToString_returns_csv_with_list_greater_than_1()
        {
            // arange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            // act
            string result = list.ToString();

            // assert
            string expected = "4,3,2,1";
            Assert.Equal(expected, result);
        }
    }
}
