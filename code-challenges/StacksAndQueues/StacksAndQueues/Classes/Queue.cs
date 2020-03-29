using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        /// <summary>
        /// Adds a new node to the back of a queue
        /// </summary>
        /// <param name="val">The value of the node to be added</param>
        public void Enqueue(int val)
        {
            Node newNode = new Node(val);
            if(Rear != null)
            {
                Front = newNode;
                Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
            }
        }

        /// <summary>
        /// Removes a node from the front of a queue
        /// </summary>
        public void Dequeue()
        {

        }

        /// <summary>
        /// Returns the value of the node at the front of a queue
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

        /// <summary>
        /// Concatenates the values from each node in a queue into a string
        /// </summary>
        /// <returns>A string of all the values from the stack</returns>
        public override string ToString()
        {
            Node current = Front;

            StringBuilder sb = new StringBuilder();

            sb.Append("Front -> ");
            while (current != null)
            {
                sb.Append($"{current.Value} -> ");
                current = current.Next;
            }
            sb.Append("Rear");
            return sb.ToString();
        }
    }
}
