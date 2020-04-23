using QuickSort;
using System;
using Xunit;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanQuickSort()
        {
            int[] testArr = new int[] { 8, 4, 23, 42, 16, 15 };
            Program.QuickSort(testArr);
            Assert.Equal("4,8,15,16,23,42", String.Join(",", testArr));
        }

        [Fact]
        public void CanQuickSortReverseOrder()
        {
            int[] testArr = new int[] { 6, 5, 4, 3, 2, 1 };
            Program.QuickSort(testArr);
            Assert.Equal("1,2,3,4,5,6", String.Join(",", testArr));
        }

        [Fact]
        public void CanQuickSortInOrder()
        {
            int[] testArr = new int[] { 1, 2, 3, 4, 5, 6 };
            Program.QuickSort(testArr);
            Assert.Equal("1,2,3,4,5,6", String.Join(",", testArr));
        }
    }
}
