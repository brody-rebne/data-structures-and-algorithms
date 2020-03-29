using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        //test that an empty stack can be instantiated
        //relies on Stack.ToString method
        [Fact]
        public void CanInstantiateStack()
        {
            Stack stack = new Stack();
            string stackString = stack.ToString();

            Assert.Equal("Top -> null", stackString);
        }

        //test that a value can be pushed onto a stack
        [Fact]
        public void CanPushToStack()
        {
            Stack stack = new Stack();
            stack.Push(12);
            string stackString = stack.ToString();

            Assert.Equal("Top -> 12 -> null", stackString);
        }

        //test that multiple values can be pushed onto a stack
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

        //test that a value can be popped off of a stack
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

        //test that multiple values can be popped off of a stack
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

        //test that a stack top node's value can be peeked
        [Fact]
        public void CanPeekStack()
        {
            Stack stack = new Stack();
            stack.Push(33);
            stack.Push(37);
            int peekedVal = stack.Peek();

            Assert.Equal(37, peekedVal);
        }

        //test that peek throws an exception on empty stack
/*      [Fact]
        public void PeekEmptyThrowsException()
        {
            Stack stack = new Stack();

            Assert.Throws<NullReferenceException>(stack.Peek());
        }*/
        //i do not know how to test for exceptions
        //nor can i figure it out from any google search i can think of

        //test that an empty queue can be instantiated
        //relies on Queue.ToString method
        [Fact]
        public void CanInstantiateQueue()
        {
            Queue newQueue = new Queue();
            string testString = newQueue.ToString();

            Assert.Equal("Front -> Rear", testString);
        }
    }
}
