using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        //test that an empty stack can be instantiated
        //relies on ToString method
        [Fact]
        public void CanInstantiateStack()
        {
            Stack stack = new Stack();
            string stackString = stack.ToString();

            Assert.Equal("Top -> null", stackString);
        }

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

        //test that a value can be popped off of the stack
        [Fact]
        public void CanPopOffStack()
        {
            Stack stack = new Stack();
            stack.Push(12);
            stack.Push(13);
            stack.Pop();
            string stackString = stack.ToString();

            Assert.Equal("Top -> 12 -> null", stackString);
        }

        //test that multiple values can be popped off of the stack
        [Fact]
        public void CanPopMultipleOffStack()
        {
            Stack stack = new Stack();
            stack.Push(7);
            stack.Push(8);
            stack.Pop();
            stack.Pop();
            string stackString = stack.ToString();

            Assert.Equal("Top -> null", stackString);
        }
    }
}
