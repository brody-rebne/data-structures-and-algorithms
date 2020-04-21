using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class IntNode
    {
        public int Value { get; set; }
        public IntNode Left { get; set; }
        public IntNode Right { get; set; }

        public IntNode(int val)
        {
            Value = val;
            Left = null;
            Right = null;
        }
    }
}
