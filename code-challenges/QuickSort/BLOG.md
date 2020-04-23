# Insertion Sort

### Overview

Quick Sort is an efficient sorting algorithm based on recursively dividing the initial array based on a pivot value. The base function is given an array, and an initial pivot value. A starting point and end point, initially to the far left and right of the array respectively, are designated. They converge on eachother, swapping places at each step where the right value is larger. Once they meet, the pivot value swaps positions with the one where they met, the array divides itself on its new pivot, and the method calls itself recursively twice (once per half).

### Algorithm

#### Pseudocode

```
ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```

Let's run through what the pseudocode does with a step by step visualization. We'll use the array `[8,4,23,42,16,15]` for our test input.

#### 1st Pass

![First Pass](https://i.imgur.com/pSiU0em.png)

This visual demonstrates how the values are compared via multiple trackers, where and when they are swapped in places, and finally how the pivot index is re-determined. At the bottom you can see the two sub-sections which are re-sorted recursively. Let's take a look at how the second one is sorted.

#### 2nd Pass

![Second Pass A](https://i.imgur.com/CMv9xGD.png)

![Second Pass B](https://i.imgur.com/zOWDPQZ.png)

You can see how much sorting can get done in one pass with this sort here. At the end of the loop shown here this section would provide subsections of only 1 item, thus breaking the recursion loop and finishing the sort.

## Efficiency

#### Time

Although it has a very good average performance, Quick Sort still has a worst case performance of O(n)

#### Space

Due to recursion Quick Sort commands an O(log n) space complexity