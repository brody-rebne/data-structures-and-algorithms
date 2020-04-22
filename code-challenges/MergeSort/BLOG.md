# Insertion Sort

### Overview

Merge Sort is a simple sorting algorithm which essentially works by splitting an array into smaller arrays until only one value remains, and then sorting them back together one level at a time. When the arrays are smallest, two can be sorted and merged together simply, since only one set of numbers needs to be checked. Starting at the smallest point allows us to sort each next level into longer arrays, since we know we can traverse each array from left to right and only move to the next value in either once it is sorted into the new longer array. By having the method call itself recursively we can use the callstack to work through the whole array progressively.

### Algorithm

#### Pseudocode

```
Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```

Let's run through what the pseudocode does with a step by step visualization. We'll use the array `[8,4,23,42,16,15]` for our test input.

#### Step 1

![Step 1](https://i.imgur.com/Xlgr1Zb.png)

The initial array is divided in two. It's midpoint is determined, and two temp arrays are created—one half the length of the array (rounded up), and the other half the length rounded down. The values from index[first] to index[mid] are fed to the first array, and the values from index[mid+1] to index[last] into the second.

#### Step 2

![Step 2](https://i.imgur.com/bHBdmTS.png)

This process is repeated recursively on any array with more than one value. This means at the end, we will have a bunch of arrays with one value each.

#### Step 3

![Step 3](https://i.imgur.com/fPQhykh.png)

The first set of arrays are sorted and merged. The values are compared between arrays starting at the first index. Each array's loop's index is only increased when a value from it is sorted, so values will never be skipped. Here each array has only 1 value, so it's very straightforward.

#### Step 4

![Step 4](https://i.imgur.com/lt3WfNO.png)

Here some longer arrays are sorted. Note that the third array's current compared value stays at 16 once 15 is sorted. Note also that once all values from array 4 are sorted, the values from array 3 can be added on without further checks. This is done via a while loop checking for indeces outside of range.

#### Step 5

![Step 5](https://i.imgur.com/nbLTdRW.png)

The final sort. Nothing here is any different from the functionality in the previous 2 steps, it just goes on for longer.

## Efficiency

#### Time

O(n * log n). It is not wholly recursive, but the "tree" of sub-arrays gets both wider and deeper the longer the array is.

#### Space

O(n)