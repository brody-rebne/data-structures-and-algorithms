using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class BinaryStringTree
    {
        public StringNode Root { get; set; }

        public BinaryStringTree()
        {
            Root = null;
        }

        /// <summary>
        /// Traverses the tree via pre-order traversal and returns the values
        /// </summary>
        /// <returns>An array of the values</returns>
        public string[] PreOrder()
        {
            List<string> values = new List<string>();
            //starts recursion at head
            //prevents trying to query properties of a null Root
            if (Root != null)
                PreOrderTraversal(Root, values);
            return values.ToArray();
        }

        /// <summary>
        /// Recursive helper method for pre-order traversal. Should not be called directly
        /// </summary>
        /// <param name="current">The current node being traversed</param>
        /// <param name="list">The list of values to be added to</param>
        public void PreOrderTraversal(StringNode current, List<string> list)
        {
            //add current, then go to left, then to right
            list.Add(current.Value);
            if (current.Left != null)
                PreOrderTraversal(current.Left, list);
            if (current.Right != null)
                PreOrderTraversal(current.Right, list);
        }
    }
}
