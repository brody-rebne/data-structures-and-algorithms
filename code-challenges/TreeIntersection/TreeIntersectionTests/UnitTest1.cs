using System;
using Xunit;
using TreeIntersection;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        Program testProgram = new Program();

        [Fact]
        public void CanFindMatchesArr2Bigger()
        {
            int[] testArr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] testArr2 = new int[] { 1, 3, 5, 7, 9 };

            int[] expected = new int[] { 1, 3, 5 };

            Assert.Equal(expected, testProgram.TreeIntersection(testArr1, testArr2));
        }
    }
}
