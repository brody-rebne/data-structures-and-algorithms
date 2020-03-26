# Data Structures and Algorithms

### Coding Challenges for Code Fellows 301 and 401

## 02 - Shifted Array

### Problem Domain

Write a function which takes in an array and a value to be added. Return an identical array but with the value inserted in the middle. Do not use any built-in functions.

### Expected Inputs and Outputs

Input: ([1, 2, 3, 4], 0)

Output: [1, 2, 0, 3, 4]

Input: ([1, 2, 3, 4, 5], 0)

Output: [1, 2, 0, 3, 4, 5]

### Big O

O(n)

### Whiteboard Visual

![Whiteboard Visual](https://i.imgur.com/X0645P7.jpg)

### Change Log

1.0: Initial version

## 03 - Binary Search

### Code

https://github.com/brody-rebne/data-structures-and-algorithms/tree/master/code-challenges/LinkedList

### Problem Domain

Write a function which takes in a sorted array and a value to search. Return the index of the array value found to match the search value. If no matching value is found, return -1. Do not use any built-in helper methods.

### Expected Inputs and Outputs

Input: ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3)

Output: 2

Input: ([1, 2, 3, 4, 5, 6, 7, 8, 9], 9)

Output: 8

Input: ([1, 2, 3, 4, 5, 6, 7, 8, 9], 99)

Output: -1

### Big O

O(n)

### Whiteboard Visual

![Whiteboard Visual](https://i.imgur.com/bJsWW5t.jpg)

## 04 - Change Log

1.0: Initial version

## Singly Linked List

### Challenge
Create a singly linked list class, with methods to add an item, search the list's nodes for a value, and create a string of all the nodes' values.

### Approach & Efficiency
Our instructor, Amanda Iverson, provided some starter code to be implemented. We worked together as a class to fine tune the functionality, and individually recreated and documented it.

### API
`LinkList.Insert(int value)` - inserts a node with provided value at the beginning of the linked list

`LinkList.Includes(int value)` - searches the linked list for a node with a value matching the provided value

`LinkList.ToString()` - returns a string of the values of every node in a linked list (overrides default `ToString()`)

## Linked List Part 2 - Insert Before

### Problem Domain

Write a method which adds a new node with a given value before the first node in a list with a (different) given value

### Expected Inputs and Outputs

Input: 
- List: Head -> 10 -> 20 -> 30 -> null
- Val to add: 15
- Val to search: 20

Output:
- List: Head -> 10 -> 15 -> 20 -> 30 -> null

### Big O

Time: O(n)

### Whiteboard Visual

![Linked List 2 Whiteboard](https://i.imgur.com/mPC72I0.png)

### Changelog

1.0: Initial version

## Linked List Part 3 - Find Node from End

### Problem Domain

Write a method for the LinkedList class which takes a number as a parameter. It should return the value of the node which is [number] from the end of the list.

### Expected Input/Output

Input: 2 - called on linked list "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null"

Output: 4

Input: 20 - called on linked list "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null"

Output: Exception

### Big O

Time: O(n)

### Whiteboard Visual

![Linked List 3 Whiteboard](https://i.imgur.com/DclX4jJ.jpg)

### Changelog

1.0: Initial version

## Linked List Merge

### Problem Domain

Write a method which takes two linked lists as arguments. Zip the two linked lists together into one, alternating nodes between input lists. Return the zipped list.

### Expected Input/Output

Input:
- LinkedList1: "1 -> 2 -> 3 -> NULL"
- LinkedList2: "4 -> 5 -> 6 -> NULL"

Output:
- ReturnList: "1 -> 4 -> 2 -> 5 -> 3 -> 6 -> NULL"

Input: 20:
- LinkedList1: "1 -> 2 -> 3 -> NULL"
- LinkedList2: "4 -> NULL"

Output:
- ReturnList: "1 -> 4 -> 2 -> 3 -> NULL"

Input: 20:
- LinkedList1: "1 -> 2 -> 3 -> NULL"
- LinkedList2: "NULL"

Output:
- ReturnList: "1 -> 2 -> 3 -> NULL"

### Big O

Time: O(n)

### Whiteboard Visual

![Linked List Merge Whiteboard](https://i.imgur.com/fK5IIUY.jpg)

### Changelog

1.0: Initial version
