# Stacks and Queues
<!-- Short summary or background information -->
This folder contains the classes needed to implement the queue and stack datastructures using generics.

## Challenge
<!-- Description of the challenge -->
Create a queue and stack class with methods to add, remove and get, just get, and check if empty.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
I utilized the same concepts from linked lists for both. With the queue I tracked the end as well so we can enqueue with better ease.

The big O for all the methods should be O(1) for both space and time.

## API
<!-- Description of each method publicly available to your Stack and Queue-->
### Stack
- `Push(T value)`
  - Creates a new node and puts it ontop of the stack.
- `Pop()`
  - Returns the value of the node on top and then removes the node.
  - Throws NullReferenceException
- `Peek()`
  - Returns the value of the node on top without removing it.
  - Throws NullReferenceException
- `isEmpty()`
  - Returns a true if top is null and false if it's not

### Queue
- `Enqueue(T value)`
  - Creates a new node and adds it to the end of the queue.
- `Dequeue()`
  - Returns the value of the node at the front of the queue and then removes the node.
  - Throws NullReferenceException
- `Peek()`
  - Returns the value of the node at the front of the queue without removing it.
  - Throws NullReferenceException
- `isEmpty()`
  - Returns a true if front is null and false if it's not
