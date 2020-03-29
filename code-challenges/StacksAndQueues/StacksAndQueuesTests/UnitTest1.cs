using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        //test that a value can be pushed onto the stack
        [Fact]
        public void CanPushToStack()
        {
            Stack stack = new Stack();
            stack.Push(12);
            string stackString = stack.ToString();

            Assert.Equal("Top -> 12 -> null", stackString);
        }

        //test that multiple values can be pushed onto the stack
        [Fact]
        public void CanPushMultipleToStack()
        {
            Stack stack = new Stack();
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            string stackString = stack.ToString();

            Assert.Equal("Top -> 9 -> 8 -> 7 -> null", stackString);
        }
    }
}
