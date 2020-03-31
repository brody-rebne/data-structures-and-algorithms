using System;
using Xunit;
using QueueWithStacks.Classes;

namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        //can enqueue node
        [Fact]
        public void CanEnqueue()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(1);
            string testString = pq.ToString();

            Assert.Equal("Top -> 1 -> null", testString);
        }

        //can enqueue multiple nodes
        [Fact]
        public void CanEnqueueMultiple()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(1);
            pq.Enqueue(2);
            string testString = pq.ToString();

            Assert.Equal("Top -> 1 -> 2 -> null", testString);
        }

        //can dequeue node
        [Fact]
        public void CanDequeue()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(1);
            pq.Enqueue(2);
            pq.Dequeue();
            string testString = pq.ToString();

            Assert.Equal("Top -> 2 -> null", testString);
        }

        //can dequeue multiple nodes
        [Fact]
        public void CanDequeueMultiple()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(1);
            pq.Enqueue(2);
            pq.Enqueue(3);
            pq.Dequeue();
            pq.Dequeue();
            string testString = pq.ToString();

            Assert.Equal("Top -> 3 -> null", testString);
        }

        //can dequeue nodes until list is empty
        [Fact]
        public void CanDequeueUntilEmpty()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(1);
            pq.Enqueue(2);
            pq.Dequeue();
            pq.Dequeue();
            string testString = pq.ToString();

            Assert.Equal("Top -> null", testString);
        }
    }
}
