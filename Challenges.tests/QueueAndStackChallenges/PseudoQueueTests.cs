using Challenges.StackAndQueueChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.QueueAndStackChallenges
{
    public class PseudoQueueTests
    {
        [Fact]
        public void Enqueue_and_IsEmpty_works()
        {
            // arrange
            PseudoQueue<int> queue = new PseudoQueue<int>();
            // assert
            Assert.True(queue.IsEmpty);
            // act
            queue.Enqueue(1);
            // assert
            Assert.False(queue.IsEmpty);
        }
        [Fact]
        public void Dequeue_works()
        {
            // arrange
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.Enqueue(1);
            // act
            int result = queue.Dequeue();
            // assert
            Assert.True(queue.IsEmpty);
            Assert.Equal(1, result);
            // arrange
            queue.Enqueue(3);
            queue.Enqueue(5);
            // act
            result = queue.Dequeue();
            // assert
            Assert.False(queue.IsEmpty);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Peek_works()
        {
            // arrange
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.Enqueue(1);
            // act
            int result = queue.Peek();
            // assert
            Assert.False(queue.IsEmpty);
            Assert.Equal(1, result);
            // arrange
            queue.Enqueue(4);
            // act
            result = queue.Peek();
            // assert
            Assert.Equal(4, result);
            // act
            result = queue.Peek();
            // assert
            Assert.Equal(4, result);
        }
    }
}
