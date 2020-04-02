using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation
{
    public class Node
    {
        public string Value { get; set; }

        //value of the next node
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for nodes
        /// </summary>
        /// <param name="val">Value of the node</param>
        public Node(string val)
        {
            Value = val;
        }
    }
}
