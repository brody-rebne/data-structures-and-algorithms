# Trees

### Code

https://github.com/brody-rebne/data-structures-and-algorithms/tree/master/code-challenges/Trees/Trees

## Traversal and Search

### Problem Domain

Create a BinaryTree class with methods for PreOrder, InOrder, and PostOrder traversals. The tree should be comprised of Nodes, and each traversal method should return an array.

Create a BinarySearchTree class with methods for Adding a node, and searching for a Contained node by value. The search method should return a bool.

### Expected Input/Output

Input:
```
    1
 2     3
4 5   6 7
```

Output:
- PreOrder(): `[1, 2, 4, 5, 3, 6, 7]`
- InOrder(): `[4, 2, 5, 1, 3, 6, 7]`
- PostOrder(): `[4, 5, 2, 6, 7, 3, 1]`
- Search(3) *(if it were a Search tree)*: `true`

### Big O

Time: O(n)
Space: O(1)

### Whiteboard Visual

Whiteboard for BinarySearchTree Add method:

![Binary Search Tree Add Whiteboard](https://i.imgur.com/GF1atm6.jpg)

## Breadth-First Traversal

### Problem Domain

Write a breadth first traversal method which takes in a binary tree. Return a list of the tree's node's values in the order in which they were traversed

#### Edge Cases:

Empty tree

Null value in node

### Expected Input/Output

Input:
```
    1
 2     3
4 5   6 7
```

Output:

List: `1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7`

### Big O

Time: O(n)
Space: O(n)

### Whiteboard Visual

![Breadth-First Traversal Whiteboard](https://i.imgur.com/M5gn0Lh.png)

*Whiteboarding done collaboratively with Sue Tarazi*

### Changelog

1.0: Initial version

2.0 Adding breadth-first traversal