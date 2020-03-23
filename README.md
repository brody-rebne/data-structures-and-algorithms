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

# Singly Linked List

## Challenge
Create a singly linked list class, with methods to add an item, search the list's nodes for a value, and create a string of all the nodes' values.

## Approach & Efficiency
Our instructor, Amanda Iverson, provided some starter code to be implemented. We worked together as a class to fine tune the functionality, and individually recreated and documented it.

## API
`LinkList.Insert(int value)` - inserts a node with provided value at the beginning of the linked list

`LinkList.Includes(int value)` - searches the linked list for a node with a value matching the provided value

`LinkList.ToString()` - returns a string of the values of every node in a linked list (overrides default `ToString()`)