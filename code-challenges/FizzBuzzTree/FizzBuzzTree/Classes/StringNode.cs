using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class StringNode
    {
        public string Value { get; set; }
        public StringNode Left { get; set; }
        public StringNode Right { get; set; }

        public StringNode(string val)
        {
            Value = val;
            Left = null;
            Right = null;
        }
    }
}
