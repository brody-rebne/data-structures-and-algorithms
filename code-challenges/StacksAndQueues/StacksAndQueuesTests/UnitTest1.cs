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
        public void PeekEmptyStackThrowsException()
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

        //test that a node can be enqueued to a stack
        [Fact]
        public void CanEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(7);
            string testString = queue.ToString();

            Assert.Equal("Front -> 7 -> Rear", testString);
        }

        //test that multiple nodes can be enqueued to a stack
        [Fact]
        public void CanEnqueueMultiple()
        {
            Queue queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            string testString = queue.ToString();

            Assert.Equal("Front -> 7 -> 8 -> 9 -> Rear", testString);
        }

        //test that a node can be dequeued
        [Fact]
        public void CanDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Dequeue();
            string testString = queue.ToString();

            Assert.Equal("Front -> 8 -> Rear", testString);
        }

        //test that all nodes in a list can be dequeued
        [Fact]
        public void CanDequeueAll()
        {
            Queue queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Dequeue();
            queue.Dequeue();
            string testString = queue.ToString();

            Assert.Equal("Front -> Rear", testString);
        }

        //test that queue can be peeked
        [Fact]
        public void CanPeekQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            int peekedVal = queue.Peek();

            Assert.Equal(7, peekedVal);
        }

        //test that peek throws an exception on empty queue
        /*      [Fact]
                public void PeekEmptyQueueThrowsException()
                {
                    Queue queue = new Queue();

                    Assert.Throws<NullReferenceException>(queue.Peek());
                }*/
        //i do not know how to test for exceptions
        //nor can i figure it out from any google search i can think of
    }
}
