using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.StackAndQueueChallenges
{
    public class FIFOAnimalShelter
    {
        private Queue<Cat> catStorage = new Queue<Cat>();
        private Queue<Dog> dogStorage = new Queue<Dog>();
        public void Enqueue(Cat cat)
        {
            catStorage.Enqueue(cat);
        }
        public void Enqueue(Dog dog)
        {
            dogStorage.Enqueue(dog);
        }
        public Object Dequeue(string param)
        {
            if(param == "cat")
            {
                return catStorage.Dequeue();
            }
            else if (param == "dog")
            {
                return dogStorage.Dequeue();
            }
            return null;
        }
    }
}
