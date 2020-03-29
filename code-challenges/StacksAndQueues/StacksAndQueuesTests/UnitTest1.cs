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
    }
}
