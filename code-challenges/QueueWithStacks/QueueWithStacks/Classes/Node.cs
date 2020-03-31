using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Node
    {
        public int Value { get; set; }

        //value of the next node
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for nodes
        /// </summary>
        /// <param name="val">Value of the node</param>
        public Node(int val)
        {
            Value = val;
        }
    }
}
