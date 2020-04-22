# Insertion Sort

### Overview

Insertion Sort is a simple and rather manual sorting algorithm. It checks each number in the array to see if it is smaller than the preceding number, and then moves it forward until it isn't. It traverses the array once over with the outer loop. The inner loop, while it repeats many times, only traverses segments of the array, and thus does as little work as possible, improving the performance of an inherently unperformant solution greatly.

### Algorithm

#### Pseudocode

```
InsertionSort(int[] arr)
  
FOR i = 1 to arr.length
    
  int j <-- i - 1
  int temp <-- arr[i]
      
  WHILE j >= 0 AND temp < arr[j]
  arr[j + 1] <-- arr[j]
  j <-- j - 1

  arr[j + 1] <-- temp
```

Let's run through what the pseudocode does with a step by step visualization. We'll use the array `[8,4,23,42,16,15]` for our test input.

#### 1st Pass

![First Pass](https://i.imgur.com/ViBKF0Y.png)

The j value (number to check current value against), and the i value (current value, reassigned via a temp value container) begin at indeces 0 and 1 respectively. At this point, only the first value in the array can be considered sorted. The temp (4) is compared against the j (8), and, since it is smaller, moved left. Since this is the beginning of the array, no further checks are made.

#### 2nd Pass

![Second Pass](https://i.imgur.com/oUFKK5P.png)

We can now say the first 2 values in the array are sorted. The j (8) value is now the last of the sorted values, and the i/temp (4) is the next. Since the temp value (23) is not smaller than the j (8) value, no change is made.

#### 3rd Pass

The third pass resembles the 2nd exactly, but with both j (23) and i (42) moved 1 index to the right. In interest of paper space I skipped visualizing it.

#### 4th Pass

![Fourth Pass](https://i.imgur.com/kVT55hM.png)

The fourth pass is our largest move yet. With the first 4 values now sorted, j (42) is last of those and i/temp (16) is the next. The temp (16) is smaller than j (42) at first check, and is moved left. It is smaller than the next j (23) as well, and is moved left once more. It finally comes to rest, as it is now larger than its j value (8).

![Fifth Pass](https://i.imgur.com/EW8cqq4.png)

The fifth pass resembles the fourth, but with one more move, more scribbles, and a worse cropping job. All but the final value are sorted, and our temp value must make a long journey. It begins less than its initial j (42), moves left and remains less than its new j (23). Moving left again, it finds itself less than its new j (16) one last time, and is moved left to the third position. Here it is finally larger than its j (8), and so remains in third.

![Final Array](https://i.imgur.com/AkG1Wov.png)

As sneak previewed in the screenshot for the fifth pass, our final array is sorted! After the fifth pass, the i index counter reaches the end of the array, and so the loop stops. The j index would remain valid, but since the loop is defined by the i index, and the j value inherits its index from i, the loop is closed.

## Efficiency

#### Time

O(n^2), since there are 2 nested loops. While the realistic time for the algorithm is better than the worst possible sorting algorithm, its worst case scenario is still nearly as bad.

#### Space

O(1), since no additional objects need to be made.