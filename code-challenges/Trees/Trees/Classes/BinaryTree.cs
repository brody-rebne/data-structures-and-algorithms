using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Traverses the tree via pre-order traversal and returns the values
        /// </summary>
        /// <returns>An array of the values</returns>
        public int[] PreOrder()
        {
            List<int> values = new List<int>();
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
        public void PreOrderTraversal(Node current, List<int> list)
        {
            //add current, then go to left, then to right
            list.Add(current.Value);
            if (current.Left != null)
                PreOrderTraversal(current.Left, list);
            if (current.Right != null)
                PreOrderTraversal(current.Right, list);
        }

        /// <summary>
        /// Traverses the tree via in-order traversal and returns the values
        /// </summary>
        /// <returns>An array of the values</returns>
        public int[] InOrder()
        {
            //starts recursion at head
            //prevents trying to query properties of a null Root
            List<int> values = new List<int>();
            if (Root != null)
                InOrderTraversal(Root, values);
            return values.ToArray();
        }

        /// <summary>
        /// Recursive helper method for in-order traversal. Should not be called directly
        /// </summary>
        /// <param name="current">The current node being traversed</param>
        /// <param name="list">The list of values to be added to</param>
        public void InOrderTraversal(Node current, List<int> list)
        {
            //go to left, then add current, then go to right
            if (current.Left != null)
                InOrderTraversal(current.Left, list);
            list.Add(current.Value);
            if (current.Right != null)
                InOrderTraversal(current.Right, list);
        }

        /// <summary>
        /// Traverses the tree via post-order traversal and returns the values
        /// </summary>
        /// <returns>An array of the values</returns>
        public int[] PostOrder()
        {
            //starts recursion at head
            //prevents trying to query properties of a null Root
            List<int> values = new List<int>();
            if (Root != null)
                PostOrderTraversal(Root, values);
            return values.ToArray();
        }

        /// <summary>
        /// Recursive helper method for post-order traversal. Should not be called directly
        /// </summary>
        /// <param name="current">The current node being traversed</param>
        /// <param name="list">The list of values to be added to</param>
        public void PostOrderTraversal(Node current, List<int> list)
        {
            //go to left, then to right, then add current
            if (current.Left != null)
                PostOrderTraversal(current.Left, list);
            if (current.Right != null)
                PostOrderTraversal(current.Right, list);
            list.Add(current.Value);
        }
    }
}
