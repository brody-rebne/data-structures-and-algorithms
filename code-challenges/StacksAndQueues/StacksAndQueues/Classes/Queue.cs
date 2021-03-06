﻿using System;
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
                Rear.Next = newNode;
                Rear = newNode;
            }
            else
            {
                Front = newNode;
                Rear = newNode;
            }
        }

        /// <summary>
        /// Removes a node from the front of a queue
        /// </summary>
        public void Dequeue()
        {
            try
            {
                Node oldFront = Front;
                Front = oldFront.Next;
                oldFront.Next = null;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Null Reference Exception: {e}");
                throw;
            }
        }

        /// <summary>
        /// Returns the value of the node at the front of a queue
        /// </summary>
        /// <returns>The value of the node at the front of the queue</returns>
        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine($"Null Reference Exception: {e}");
                throw;
            }
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
