using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.StackAndQueue
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_works()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            // act
            // assert
            Assert.IsType<Queue<int>>(queue);
        }
        [Fact]
        public void Enqueue_works_multiple_times()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            // act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            // assert
            Assert.False(queue.isEmpty());
        }
        [Fact]
        public void Dequeue_works_for_correct_value()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            // act
            int result = queue.Dequeue();
            // assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Peek_shows_the_next_value()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            // act
            int result = queue.Peek();
            // assert
            Assert.Equal(1, result);
            // act
            queue.Dequeue();
            result = queue.Peek();
            // assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Dequeue_multiple_times_can_empty_the_queue()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            // act
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            // assert
            Assert.True(queue.isEmpty());
        }
        [Fact]
        public void Can_instantiate_an_empty_queue()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            // act
            // assert
            Assert.True(queue.isEmpty());
        }
        [Fact]
        public void Dequeue_or_Peek_on_and_empty_queue_throws_exception()
        {
            // arrange
            Queue<int> queue = new Queue<int>();
            // act
            // assert
            Assert.Throws<NullReferenceException>(() => queue.Dequeue());
            Assert.Throws<NullReferenceException>(() => queue.Peek());
        }
    }
}
