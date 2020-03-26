using System;
using Xunit;
using LLMerge;
using LLMerge.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //tests that the method successfully merges lists of equal length
        [Fact]
        public void CanMergeEqualLengthLists()
        {
            LinkedList ll1 = new LinkedList();
            LinkedList ll2 = new LinkedList();

            //populate both lists
            for (int i = 2; i < 5; i++)
            {
                ll1.Append(i);
                ll2.Append(Convert.ToInt32(Math.Pow(i, 2)));
            }

            LinkedList mergedList = Program.MergeLists(ll1, ll2);

            Assert.Equal("2 -> 4 -> 3 -> 9 -> 4 -> 16 -> NULL", mergedList.ToString());
        }

        //tests that the method successfully merges lists of equal length
        [Fact]
        public void CanMergeDifferentLengthLists()
        {
            LinkedList ll1 = new LinkedList();
            LinkedList ll2 = new LinkedList();

            //populate both lists
            for (int i = 2; i < 5; i++)
            {
                ll1.Append(i);
            }
            for (int i = 2; i < 4; i++)
            {
                ll2.Append(Convert.ToInt32(Math.Pow(i, 2)));
            }

            LinkedList mergedList = Program.MergeLists(ll1, ll2);

            Assert.Equal("2 -> 4 -> 3 -> 9 -> 4 -> NULL", mergedList.ToString());
        }

        //tests that the method successfully merges lists of equal length
        [Fact]
        public void CanMergeBlankList()
        {
            LinkedList ll1 = new LinkedList();
            LinkedList ll2 = new LinkedList();

            //populate both lists
            for (int i = 2; i < 5; i++)
            {
                ll1.Append(i);
            }

            LinkedList mergedList = Program.MergeLists(ll1, ll2);

            Assert.Equal("2 -> 3 -> 4 -> NULL", mergedList.ToString());
        }
    }
}
