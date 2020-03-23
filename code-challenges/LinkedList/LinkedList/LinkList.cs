using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        private Node Current { get; set; }

        /// <summary>
        /// Inserts a new node into the list
        /// </summary>
        /// <param name="value">The node's contained value</param>
        public void Insert(int value)
        {
            //create a new node instance
            Node node = new Node();
            //set the new node's value to inputted value
            node.Value = value;
            //set this node as the one before the head
            node.Next = Head;
            //set this node as the new head
            Head = node;
        }

        /// <summary>
        /// Checks if a value is contained in any of the nodes in a list
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <returns>Bool indicating if value was found</returns>
        public bool Includes(int value)
        {
            //begin at the beginning
            Current = Head;

            //and go on till you come to the end
            while(Current != null)
            {
                //if the value of the current node equals the input, return true
                if (Current.Value == value)
                {
                    return true;
                }
                //otherwise, keep traversing the list
                Current = Current.Next;
            }

            //then stop
            return false;
        }

        /// <summary>
        /// Concatenates the values from each node in the list into a string
        /// </summary>
        /// <returns>A string of all the values from the list</returns>
        public override string ToString()
        {
            //starts at the beginning of the list
            Current = Head;
            //instantiates a new instance of a well named built in class
            StringBuilder sb = new StringBuilder();
            //traverse the list and concatenate values within the string builder
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }
            //appending this to mark the end of the list
            sb.Append("NULL");
            //returns the final concatenation converted to an actual string using the regular ToString() method
            return sb.ToString();
        }
    }
}
