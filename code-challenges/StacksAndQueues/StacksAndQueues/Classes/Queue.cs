using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }

        /// <summary>
        /// Adds a new node to the back of the queue
        /// </summary>
        /// <param name="val">The value of the node to be added</param>
        public void Enqueue(int val)
        {

        }

        /// <summary>
        /// Removes a node from the front of the queue
        /// </summary>
        public void Dequeue()
        {

        }

        /// <summary>
        /// Returns the value of the node at the front of the queue
        /// </summary>
        /// <returns>The value of the node at the front of the queue</returns>
        public int Peek()
        {
            return 0;
        }

        /// <summary>
        /// Checks if the queue is empty
        /// </summary>
        /// <returns>True if the queue is empty</returns>
        public bool IsEmpty()
        {
            return false;
        }
    }
}
