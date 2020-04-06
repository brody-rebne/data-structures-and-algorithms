using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        /// <summary>
        /// Inserts a new node into its sorted location the tree
        /// </summary>
        /// <param name="val">The value of the node to be added</param>
        public void Insert(int val)
        {
            //if the tree is empty, add the node as root
            if (Root == null)
                Root = new Node(val);
            //otherwise, find where to add it
            else
                InsertNode(Root, val);
        }

        /// <summary>
        /// Recursive helper method for node insertion. Should not be called directly.
        /// </summary>
        /// <param name="current">The node to try an insertion on</param>
        /// <param name="val">The value of the node to be added</param>
        /// <returns></returns>
        public Node InsertNode(Node current, int val)
        {
            //if you've found a blank spot, add the value
            if (current == null)
                current = new Node(val);
            //go to the left if the value is smaller than current
            else if (current.Value > val)
                current.Left = InsertNode(current.Left, val);
            //go to the right if the value is larger than current
            else
                current.Right = InsertNode(current.Right, val);

            return current;
        }

        /// <summary>
        /// Searches the tree for a value
        /// </summary>
        /// <param name="val">True if value is found</param>
        /// <returns></returns>
        public bool Contains(int val)
        {
            //starts the search at the root
            return ContainsNode(Root, val);
        }

        /// <summary>
        /// Recursive helper method for node search. Should not be called directly.
        /// </summary>
        /// <param name="current">The current node to be searched</param>
        /// <param name="val">The searched value</param>
        /// <returns></returns>
        public bool ContainsNode(Node current, int val)
        {
            //if you've found the value, you've found it
            if (current.Value == val)
                return true;
            //if the value is smaller than the current, go to the left
            //skips if there is no left to go to
            else if (current.Value > val && current.Left != null)
                return ContainsNode(current.Left, val);
            //if the value is larger than the current, go to the right
            //skips if there is no right to go to
            else if (current.Right != null)
                return ContainsNode(current.Right, val);
            return false;
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
    }
}
