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
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 3;
            int result = Program.BinarySearch(intArr, key);
            Assert.Equal(2, result);
        }
    }
}
