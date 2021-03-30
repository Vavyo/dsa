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
            string expected = "NULL";
            Assert.Equal(expected, result);
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
            string expected = "6,NULL";
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
            string expected = "4,3,2,1,NULL";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Append_adds_node_to_end_of_linked_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            // act
            list.Append(4);

            // assert
            string result = list.ToString();
            string expected = "1,2,3,4,NULL";
            Assert.Equal(expected, result);
            
        }
        [Fact]
        public void Append_adds_node_to_end_of_linked_list_after_having_been_appended()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            // act
            list.Append(4);
            list.Append(5);

            // assert
            string result = list.ToString();
            string expected = "1,2,3,4,5,NULL";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void InsertBefore_adds_node_to_linked_list_before_first_node_with_value()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            // act
            list.InsertBefore(3, 5);
            // assert
            string result = list.ToString();
            string expected = "1,2,5,3,3,NULL";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void InsertBefore_can_add_a_node_before_the_first_node()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            // act
            list.InsertBefore(1, 5);
            // assert
            string result = list.ToString();
            string expected = "5,1,NULL";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void InsertAfter_can_add_a_node_after_first_occurence_of_value()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(2);
            list.Insert(2);
            list.Insert(1);
            // act
            list.InsertAfter(2, 5);
            // assert
            string result = list.ToString();
            string expected = "1,2,5,2,4,NULL";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void InsertAfter_can_add_a_node_after_the_last_node()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            // act
            list.InsertAfter(1, 5);
            // assert
            string result = list.ToString();
            string expected = "1,5,NULL";
            Assert.Equal(expected, result);
        }
        [Fact]
        public void kthFromEnd_returns_correct_value_for_valid_args_on_list_greater_than_1()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            // act
            int result = list.KthFromEnd(2);
            // assert
            int expected = 3;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void kthFromEnd_returns_correct_value_for_valid_args_on_list_size_1()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(5);
            // act
            int result = list.KthFromEnd(0);
            // assert
            int expected = 5;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void kthFromEnd_throws_argument_exception_when_k_larger_than_list_size()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            // act
            // assert
            Assert.Throws<ArgumentException>(() => list.KthFromEnd(4));
        }
        [Fact]
        public void kthFromEnd_throws_argument_exception_when_list_is_null()
        {
            // arrange
            LinkedList list = new LinkedList();
            // act
            // assert
            Assert.Throws<ArgumentException>(() => list.KthFromEnd(4));
        }
        [Fact]
        public void kthFromEnd_returns_correct_value_when_k_is_list_size()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            // act
            int result = list.KthFromEnd(3);
            // assert
            int expected = 2;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void kthFromEnd_throws_argument_exception_when_k_is_negative()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            // act
            // assert
            Assert.Throws<ArgumentException>(() => list.KthFromEnd(-4));
        }

    }
}
