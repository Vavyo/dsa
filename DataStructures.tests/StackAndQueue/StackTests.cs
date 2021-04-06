using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.StackAndQueue
{
    public class StackTests
    {
        [Fact]
        public void Stack_is_empty_on_creation()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            // act
            // assert
            Assert.True(stack.IsEmpty);
        }
        [Fact]
        public void Push_adds_top_to_value()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            // act
            stack.Push(1);
            // assert
            Assert.False(stack.IsEmpty);
        }
        [Fact]
        public void Push_works_multiple_times()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            // act
            stack.Push(1);
            stack.Push(1);
            stack.Push(1);
            stack.Push(1);
            // assert
            Assert.False(stack.IsEmpty);
        }
        [Fact]
        public void Pop_returns_node_value()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // act
            int result = stack.Pop();
            // assert
            Assert.Equal(3, result);
            // act
            result = stack.Pop();
            // assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Pop_can_empty_stack()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.False(stack.IsEmpty);
            // act
            stack.Pop();
            stack.Pop();
            stack.Pop();
            // assert
            Assert.True(stack.IsEmpty);
        }
        [Fact]
        public void Peek_returns_next_value_on_the_stack()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // act
            stack.Peek();
            int result = stack.Peek();
            // assert
            Assert.Equal(3, result);
        }
        [Fact]
        public void Pop_or_Peek_on_empty_stack_throws_exception()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            // act
            // assert
            Assert.Throws<NullReferenceException>(() => stack.Pop());
            Assert.Throws<NullReferenceException>(() => stack.Peek());
        }
    }
}
