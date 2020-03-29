using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Pushes a node on the top of the stack
        /// </summary>
        /// <param name="val">The value of the node to be added</param>
        public void Push(int val)
        {

        }

        /// <summary>
        /// Pops the top node off of the stack
        /// </summary>
        public void Pop()
        {

        }

        /// <summary>
        /// Returns the value of the node on top of the stack
        /// </summary>
        /// <returns>The value of the node at the top of the stack</returns>
        public int Peek()
        {
            return 0;
        }

        /// <summary>
        /// Checks if the stack is empty
        /// </summary>
        /// <returns>True if stack is empty</returns>
        public bool IsEmpty()
        {
            return false;
        }
    }
}
