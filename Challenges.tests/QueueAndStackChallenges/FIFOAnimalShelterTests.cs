using Challenges.StackAndQueueChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.tests.QueueAndStackChallenges
{
    public class FIFOAnimalShelterTests
    {
        [Fact]
        public void Can_store_and_retrieve_cats()
        {
            // arrange
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            // act
            Cat expected = new Cat("sam");
            shelter.Enqueue(expected);
            Cat result = (Cat)shelter.Dequeue("cat");
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Can_store_and_retrieve_dogs()
        {
            // arrange
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            // act
            Dog expected = new Dog("Doug");
            shelter.Enqueue(expected);
            Dog result = (Dog)shelter.Dequeue("dog");
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Dequeue_returns_null_object_when_param_is_invalid()
        {
            // arrange
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            // act
            Cat expected = new Cat("sam");
            shelter.Enqueue(expected);
            Cat result = (Cat)shelter.Dequeue("parrot");
            // assert
            Assert.Null(result);
        }
    }
}
