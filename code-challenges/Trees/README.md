# Trees

### Code

https://github.com/brody-rebne/data-structures-and-algorithms/tree/master/code-challenges/MultiBracketValidation/MultiBracketValidation

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

![BracketValidation Whiteboard](https://i.imgur.com/GF1atm6.jpg)

### Changelog

1.0: Initial version