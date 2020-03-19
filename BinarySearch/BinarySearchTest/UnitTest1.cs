using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindIndex()
        {
            // testing for a simple successful check
            // key should be found and index returned
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 3;
            int result = Program.BinarySearch(intArr, key);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CanFindMissing()
        {
            // testing for a simple failed check
            // key should be not found and -1 returned
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 10;
            int result = Program.BinarySearch(intArr, key);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void CanFindLastValue()
        {
            // testing to find last value in array
            // this causes some difficulties with the method
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 9;
            int result = Program.BinarySearch(intArr, key);
            Assert.Equal(8, result);
        }

        [Fact]
        public void CanFindFirstValue()
        {
            // same as above but for first value
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 1;
            int result = Program.BinarySearch(intArr, key);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CanFindDuplicate()
        {
            // testing array with multiple matches
            // should find first iteration, in this case it would find the match at index 1 first
            int[] intArr = { 1, 1, 3, 4, 5, 6, 7, 8, 9 };
            int key = 1;
            int result = Program.BinarySearch(intArr, key);
            Assert.Equal(1, result);
        }
    }
}
