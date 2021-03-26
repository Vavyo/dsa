# Singly Linked List
<!-- Short summary or background information -->
Node based list to track integer elements

## Challenge
<!-- Description of the challenge -->
Figure out how to convert to string, find in list, and add to the list.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
I used a new property Current to track the current node separate from the Head. Using current I check through the list with a while loop goin until `Current.Next == Null`.
The Big O for time should be O(n) and for space it should be O(n) where n is the length of the list.

## API
<!-- Description of each method publicly available to your Linked List -->
- `Insert(int value)`
  - Adds a new node to the list with the value specified
- `Included(int value)`
  - Returns true if the value is found in the list.
- `ToString()`
  - Returns the values in order, starting from the head, as a CSV.
